using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BTC_Client.Dtos;
using BTC_Client.Models;
using BTC_Client.Services;
using Microsoft.Extensions.DependencyInjection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BTC_Client
{
    public partial class Main : Form
    {
        private readonly BtcTrackerService? _btcTrackerService;
        private readonly ExchangeRateService? _exchangeRateService;
        private readonly ApiService? _apiService;
        private readonly BindingList<PriceGridItem> _items = new();
        private readonly BindingList<PriceGridItem> _savedItems = new();

        private const int RefreshIntervalSecs = 10;

        private float _exchangeRate = 0;

        public Main(IServiceProvider serviceProvider)
        {
            _btcTrackerService = serviceProvider.GetService<BtcTrackerService>();
            _exchangeRateService = serviceProvider.GetService<ExchangeRateService>();
            _apiService = serviceProvider.GetService<ApiService>();

            InitializeComponent();

            dataGridView_liveItems.DataSource = _items;
            dataGridView_liveItems.Columns["Comment"].Visible = false;
            dataGridView_savedItems.DataSource = _savedItems;
            dataGridView_savedItems.ReadOnly = false;



        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshData();
            Task.Run(RunBtcDownloader);
        }


        private async Task RunBtcDownloader()
        {
            _exchangeRate = await _exchangeRateService?.GetRateForCZKEURAsync()!;
            while (true)
            {
                var data = await _btcTrackerService?.GetBitcoinDataAsync()!;
                var item = new PriceGridItem(new BtcPriceDto
                {
                    Id = 0,
                    Price = data.Bpi.EUR.Rate_float * _exchangeRate,
                    Time = data.Time.UpdatedISO,
                    Comment = string.Empty
                });
                toolStripLabel_btcPrice.Text = item.Price;

                Invoke(() =>
                {

                    if (_items.FirstOrDefault(x => x.Time == data?.Time.UpdatedISO) != default)
                        return;
                    _items.Add(item);
                    RedrawChart();

                });
                await Task.Delay(RefreshIntervalSecs * 1000);
            }
        }

        private void RedrawChart()
        {
            var tenPoints = _items.Skip(Math.Max(0, _items.Count - 10)).ToList();

            int width = pictureBox_liveChart.Width;
            int height = pictureBox_liveChart.Height;
            Bitmap image = new Bitmap(width, height);

            var graphics = Graphics.FromImage(image);
            if (tenPoints.Count > 1)
            {
                float padding = width / (float)(tenPoints.Count - 1);
                var minY = tenPoints.Select(x=>x.GetDto().Price).Min();
                var maxY = tenPoints.Select(x=>x.GetDto().Price).Max();
                List<PointF> points = new List<PointF>();
                for (int i = 0; i < tenPoints.Count; i++)
                {
                    float x = i * padding;
                    float y = (tenPoints[i].GetDto().Price - minY) / (float)(maxY - minY) * height;
                    y = height - y;
                    points.Add(new PointF(x, y));

                    graphics.DrawString($"{tenPoints[i].Price} \n {tenPoints[i].Time}", new Font("Arial", 9), Brushes.Black, x + 5, y - 10);

                }

                for (int i = 0; i < points.Count - 1; i++)
                {
                    graphics.DrawLine(Pens.Black, points[i], points[i + 1]);
                }

                foreach (var point in points)
                {
                    graphics.FillEllipse(Brushes.Red, point.X - 3, point.Y - 3, 6, 6);
                }
            }
            pictureBox_liveChart.Image = image;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveCurrentData();
        }

        private async Task SaveCurrentData()
        {
            await _apiService.AddBtcDataRangeAsync(_items.Select(x => x.GetDto()));
            RefreshData();
            MessageBox.Show("Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private async Task RefreshData()
        {
            var data = await _apiService.GetBtcSavedDataAsync();
            if (data != null)
            {
                _savedItems.Clear();
                foreach (var item in data)
                {
                    _savedItems.Add(new PriceGridItem(item));
                }
            }
        }

        private void dataGridView_savedItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _apiService.SaveBtcDataAsync(_savedItems[e.RowIndex].GetDto());
        }

        private void dataGridView_savedItems_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var result = MessageBox.Show("You sure?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            _apiService.DeleteBtcDataAsync(((PriceGridItem)e.Row.DataBoundItem).GetDto().Id);

        }

        private void saveSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_savedItems.SelectedRows.Count == 0)
                return;
            _apiService.SaveBtcDataAsync(_savedItems[dataGridView_savedItems.SelectedRows[0].Index].GetDto());
        }

        private void DeleteSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView_savedItems.SelectedRows.Count == 0)
                return;
            _apiService.DeleteBtcDataAsync(_savedItems[dataGridView_savedItems.SelectedRows[0].Index].GetDto().Id);
            dataGridView_savedItems.Rows.RemoveAt(dataGridView_savedItems.SelectedRows[0].Index);
        }
    }

}


namespace BTC_Client
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tabControl = new TabControl();
            tabPage_liveData = new TabPage();
            dataGridView_liveItems = new DataGridView();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel_btcPrice = new ToolStripLabel();
            menuStrip2 = new MenuStrip();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            tabPage_savedData = new TabPage();
            dataGridView_savedItems = new DataGridView();
            menuStrip1 = new MenuStrip();
            DeleteSelectedRowToolStripMenuItem = new ToolStripMenuItem();
            saveSelectedRowToolStripMenuItem = new ToolStripMenuItem();
            tabPage_liveChart = new TabPage();
            pictureBox_liveChart = new PictureBox();
            tabControl.SuspendLayout();
            tabPage_liveData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_liveItems).BeginInit();
            toolStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            tabPage_savedData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_savedItems).BeginInit();
            menuStrip1.SuspendLayout();
            tabPage_liveChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_liveChart).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage_liveData);
            tabControl.Controls.Add(tabPage_savedData);
            tabControl.Controls.Add(tabPage_liveChart);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(642, 464);
            tabControl.TabIndex = 0;
            // 
            // tabPage_liveData
            // 
            tabPage_liveData.Controls.Add(dataGridView_liveItems);
            tabPage_liveData.Controls.Add(toolStrip1);
            tabPage_liveData.Controls.Add(menuStrip2);
            tabPage_liveData.Location = new Point(4, 24);
            tabPage_liveData.Name = "tabPage_liveData";
            tabPage_liveData.Padding = new Padding(3);
            tabPage_liveData.Size = new Size(634, 436);
            tabPage_liveData.TabIndex = 0;
            tabPage_liveData.Text = "Live Data";
            tabPage_liveData.UseVisualStyleBackColor = true;
            // 
            // dataGridView_liveItems
            // 
            dataGridView_liveItems.AllowUserToAddRows = false;
            dataGridView_liveItems.AllowUserToDeleteRows = false;
            dataGridView_liveItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_liveItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_liveItems.Dock = DockStyle.Fill;
            dataGridView_liveItems.Location = new Point(3, 27);
            dataGridView_liveItems.Name = "dataGridView_liveItems";
            dataGridView_liveItems.ReadOnly = true;
            dataGridView_liveItems.Size = new Size(628, 381);
            dataGridView_liveItems.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel_btcPrice });
            toolStrip1.Location = new Point(3, 408);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(628, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(62, 22);
            toolStripLabel1.Text = "Price now:";
            // 
            // toolStripLabel_btcPrice
            // 
            toolStripLabel_btcPrice.Name = "toolStripLabel_btcPrice";
            toolStripLabel_btcPrice.Size = new Size(13, 22);
            toolStripLabel_btcPrice.Text = "0";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem1 });
            menuStrip2.Location = new Point(3, 3);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(628, 24);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Image = Properties.Resources.floppy_disk;
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(59, 20);
            saveToolStripMenuItem1.Text = "Save";
            saveToolStripMenuItem1.Click += saveToolStripMenuItem1_Click;
            // 
            // tabPage_savedData
            // 
            tabPage_savedData.Controls.Add(dataGridView_savedItems);
            tabPage_savedData.Controls.Add(menuStrip1);
            tabPage_savedData.Location = new Point(4, 24);
            tabPage_savedData.Name = "tabPage_savedData";
            tabPage_savedData.Padding = new Padding(3);
            tabPage_savedData.Size = new Size(634, 436);
            tabPage_savedData.TabIndex = 1;
            tabPage_savedData.Text = "Saved Data";
            tabPage_savedData.UseVisualStyleBackColor = true;
            // 
            // dataGridView_savedItems
            // 
            dataGridView_savedItems.AllowUserToAddRows = false;
            dataGridView_savedItems.AllowUserToOrderColumns = true;
            dataGridView_savedItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_savedItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_savedItems.Dock = DockStyle.Fill;
            dataGridView_savedItems.Location = new Point(3, 27);
            dataGridView_savedItems.MultiSelect = false;
            dataGridView_savedItems.Name = "dataGridView_savedItems";
            dataGridView_savedItems.Size = new Size(628, 406);
            dataGridView_savedItems.TabIndex = 1;
            dataGridView_savedItems.CellEndEdit += dataGridView_savedItems_CellEndEdit;
            dataGridView_savedItems.UserDeletingRow += dataGridView_savedItems_UserDeletingRow;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { DeleteSelectedRowToolStripMenuItem, saveSelectedRowToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(628, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // DeleteSelectedRowToolStripMenuItem
            // 
            DeleteSelectedRowToolStripMenuItem.Image = Properties.Resources.trash;
            DeleteSelectedRowToolStripMenuItem.Name = "DeleteSelectedRowToolStripMenuItem";
            DeleteSelectedRowToolStripMenuItem.Size = new Size(137, 20);
            DeleteSelectedRowToolStripMenuItem.Text = "Delete selected row";
            DeleteSelectedRowToolStripMenuItem.Click += DeleteSelectedRowToolStripMenuItem_Click;
            // 
            // saveSelectedRowToolStripMenuItem
            // 
            saveSelectedRowToolStripMenuItem.Image = Properties.Resources.floppy_disk;
            saveSelectedRowToolStripMenuItem.Name = "saveSelectedRowToolStripMenuItem";
            saveSelectedRowToolStripMenuItem.Size = new Size(128, 20);
            saveSelectedRowToolStripMenuItem.Text = "Save selected row";
            saveSelectedRowToolStripMenuItem.Click += saveSelectedRowToolStripMenuItem_Click;
            // 
            // tabPage_liveChart
            // 
            tabPage_liveChart.Controls.Add(pictureBox_liveChart);
            tabPage_liveChart.Location = new Point(4, 24);
            tabPage_liveChart.Name = "tabPage_liveChart";
            tabPage_liveChart.Padding = new Padding(3);
            tabPage_liveChart.Size = new Size(634, 436);
            tabPage_liveChart.TabIndex = 2;
            tabPage_liveChart.Text = "Live Chart";
            tabPage_liveChart.UseVisualStyleBackColor = true;
            // 
            // pictureBox_liveChart
            // 
            pictureBox_liveChart.Dock = DockStyle.Fill;
            pictureBox_liveChart.Location = new Point(3, 3);
            pictureBox_liveChart.Name = "pictureBox_liveChart";
            pictureBox_liveChart.Size = new Size(628, 430);
            pictureBox_liveChart.TabIndex = 0;
            pictureBox_liveChart.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 464);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "BTC Client";
            Load += Main_Load;
            tabControl.ResumeLayout(false);
            tabPage_liveData.ResumeLayout(false);
            tabPage_liveData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_liveItems).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            tabPage_savedData.ResumeLayout(false);
            tabPage_savedData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_savedItems).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabPage_liveChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_liveChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage_liveData;
        private TabPage tabPage_savedData;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem DeleteSelectedRowToolStripMenuItem;
        private DataGridView dataGridView_liveItems;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel_btcPrice;
        private DataGridView dataGridView_savedItems;
        private ToolStripMenuItem saveSelectedRowToolStripMenuItem;
        private TabPage tabPage_liveChart;
        private PictureBox pictureBox_liveChart;
    }
}

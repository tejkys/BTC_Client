namespace BTC_Client.Dtos;

public class BtcPriceDto
{
    public long Id { get; set; }
    public float Price { get; set; }
    public DateTime Time { get; set; }
    public string? Comment { get; set; }

}
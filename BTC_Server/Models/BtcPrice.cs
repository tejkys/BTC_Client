using System.ComponentModel.DataAnnotations;

namespace BTC_Server.Models;

public class BtcPrice
{
    [Key]

    public long Id { get; set; }
    public float Price { get; set; }
    public DateTime Time { get; set; }
    public string? Comment { get; set; }
}
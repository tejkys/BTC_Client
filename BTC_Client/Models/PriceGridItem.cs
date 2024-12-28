using System.Globalization;
using BTC_Client.Dtos;

namespace BTC_Client.Models;

public class PriceGridItem
{
    private readonly BtcPriceDto _btcPriceDto = new();

    public DateTime Time => _btcPriceDto.Time;
    public string Price => _btcPriceDto.Price.ToString("C2", new CultureInfo("cs-CZ"));
    public string Comment
    {
        get => _btcPriceDto.Comment ?? string.Empty; set => _btcPriceDto.Comment = value;
    }

    public PriceGridItem()
    {
    }
    public PriceGridItem(BtcPriceDto priceDto)
    {
        _btcPriceDto = priceDto;
    
    }
    public BtcPriceDto GetDto()
    {
        return _btcPriceDto;
    }
}
using BTC_Client.Dtos;
using BTC_Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BTC_Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DataController : ControllerBase
    {
        private readonly Context _context;

        public DataController(Context context)
        {
            _context = context;
        }
        [HttpPost]

        public async Task<IActionResult> Save(BtcPriceDto data)
        {
            if(data.Id == 0)
            {
                _context.BtcPrices.Add(new BtcPrice
                {
                    Price = data.Price,
                    Time = data.Time,
                    Comment = data.Comment
                });
            }
            else
            {
                var btcPrice = await _context.BtcPrices.FindAsync(data.Id);
                if (btcPrice != null)
                {
                    btcPrice.Price = data.Price;
                    btcPrice.Time = data.Time;
                    btcPrice.Comment = data.Comment;
                }
            }
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost]

        public async Task<IActionResult> AddRange(List<BtcPriceDto> data)
        {
            var btcPrices = await _context.BtcPrices.ToListAsync();
            _context.BtcPrices.AddRange(data.Where(x=> btcPrices.All(y => y.Time != x.Time)).Select(x => new BtcPrice
            {
                Id = x.Id,
                Price = x.Price,
                Time = x.Time,
                Comment = x.Comment
            }));
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<List<BtcPriceDto>> Load()
        {
            return await _context.BtcPrices.Select(x=>new BtcPriceDto
            {
                Id = x.Id,
                Price = x.Price,
                Time = x.Time,
                Comment = x.Comment
            }).ToListAsync();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            _context.BtcPrices.Remove(new BtcPrice { Id = id });
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

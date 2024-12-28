using BTC_Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BTC_Server;

public class Context: DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    public DbSet<BtcPrice>? BtcPrices { get; set; }
}
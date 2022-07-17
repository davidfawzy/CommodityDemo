namespace AA.CommoditiesDashboard.Api.DAL
{
    using AA.CommoditiesDashboard.Api.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using System.IO;

    public class CommodityDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        

        public CommodityDbContext(DbContextOptions<CommodityDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("CommoditiesDatabase");
            optionsBuilder.UseSqlServer(connectionString);
        }
         
        public DbSet<Commodity> Commodities { get; set; }
    }
}

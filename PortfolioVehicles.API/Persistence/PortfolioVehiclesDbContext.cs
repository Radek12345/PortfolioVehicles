using Microsoft.EntityFrameworkCore;
using PortfolioVehicles.API.Core.Models;

namespace PortfolioVehicles.API.Persistence
{
    public class PortfolioVehiclesDbContext : DbContext
    {
        public PortfolioVehiclesDbContext(DbContextOptions<PortfolioVehiclesDbContext> options)
            : base(options) {}

        public DbSet<Make> Makes { get; set; }
        public DbSet<VehicleModel> Models { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}
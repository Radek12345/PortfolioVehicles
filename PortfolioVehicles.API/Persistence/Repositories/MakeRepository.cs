using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortfolioVehicles.API.Core.Models;
using PortfolioVehicles.API.Core.Repositories;

namespace PortfolioVehicles.API.Persistence.Repositories
{
    public class MakeRepository : Repository<Make>, IMakeRepository
    {
        public MakeRepository(PortfolioVehiclesDbContext context) : base(context) {}

        public async override Task<IEnumerable<Make>> GetAll()
        {
            return await context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}
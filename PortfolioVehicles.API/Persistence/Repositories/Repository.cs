using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PortfolioVehicles.API.Core.Repositories;

namespace PortfolioVehicles.API.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly PortfolioVehiclesDbContext context;

        public Repository(PortfolioVehiclesDbContext context)
        {
            this.context = context;
        }

        public async virtual Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().AsNoTracking().ToListAsync();
        }
    }
}
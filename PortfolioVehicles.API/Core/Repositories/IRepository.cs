using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioVehicles.API.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PortfolioVehicles.API.Controllers.Resources
{
    public class MakeResource : BaseResource
    {
        public ICollection<BaseResource> Models { get; set; } = 
            new Collection<BaseResource>();
    }
}
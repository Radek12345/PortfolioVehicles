using AutoMapper;
using PortfolioVehicles.API.Controllers.Resources;
using PortfolioVehicles.API.Core.Models;

namespace PortfolioVehicles.API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<VehicleModel, BaseResource>();
            CreateMap<Feature, BaseResource>();
        }
    }
}
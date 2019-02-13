using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioVehicles.API.Controllers.Resources;
using PortfolioVehicles.API.Persistence;

namespace PortfolioVehicles.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly PortfolioVehiclesDbContext context;
        private readonly IMapper mapper;

        public FeaturesController(PortfolioVehiclesDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetFeatures()
        {
            var features = await context.Features.ToListAsync();
            var featureResources = mapper.Map<IEnumerable<BaseResource>>(features);
            return Ok(featureResources);
        }
    }
}
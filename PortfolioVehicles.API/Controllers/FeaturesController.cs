using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioVehicles.API.Controllers.Resources;
using PortfolioVehicles.API.Core.Models;
using PortfolioVehicles.API.Core.Repositories;
using PortfolioVehicles.API.Persistence;

namespace PortfolioVehicles.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IRepository<Feature> repo;

        public FeaturesController(IMapper mapper, IRepository<Feature> repo)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetFeatures()
        {
            var features = await repo.GetAll();
            var featureResources = mapper.Map<IEnumerable<BaseResource>>(features);
            return Ok(featureResources);
        }
    }
}
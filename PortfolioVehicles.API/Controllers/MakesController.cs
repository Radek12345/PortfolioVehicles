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
    public class MakesController : ControllerBase
    {
        private readonly PortfolioVehiclesDbContext context;
        private readonly IMapper mapper;

        public MakesController(PortfolioVehiclesDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            var makeResources = mapper.Map<IEnumerable<MakeResource>>(makes);
            return Ok(makeResources);
        }
    }
}
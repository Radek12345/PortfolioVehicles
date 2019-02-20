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
    public class MakesController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMakeRepository repo;

        public MakesController(IMapper mapper, IMakeRepository repo)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMakes()
        {
            var makes = await repo.GetAll();
            var makeResources = mapper.Map<IEnumerable<MakeResource>>(makes);
            return Ok(makeResources);
        }
    }
}
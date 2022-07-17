using AA.CommoditiesDashboard.Api.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AA.CommoditiesDashboard.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommoditiesController : ControllerBase
    {        
        private readonly ILogger<CommoditiesController> _logger;
        private readonly CommodityDbContext _dbContext;
        public CommoditiesController(CommodityDbContext dbContext,ILogger<CommoditiesController> logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            var commodities = _dbContext.Commodities;
            return new OkObjectResult(commodities);
        }
 
    }
   
}

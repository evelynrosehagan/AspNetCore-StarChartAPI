using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using StarChart.Data;

namespace StarChart.Controllers
{
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        RouteAttribute route = new RouteAttribute("");
        ApiControllerAttribute apiControllerAttribute;

        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }
        
    }
}

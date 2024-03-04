using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mvc.Controllers
{
    [Route("[controller]")]
    public class ArtistController : Controller
    {
        private readonly ILogger<ArtistController> _logger;

        public ArtistController(ILogger<ArtistController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
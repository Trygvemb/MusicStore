using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mvc.Data;

namespace mvc.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtistController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("Artist")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var artists = _context.Artists.ToList();
            return View(artists);
        }

        [Route("Artist/Detail/{id}")]
        public IActionResult Detail(int id)
        {
            var artist = _context.Artists.Include(a => a.Albums).FirstOrDefault(x => x.ArtistId == id);
            return View(artist);
        }

        
    }
}
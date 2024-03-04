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
    public class AlbumController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlbumController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [Route("Album")]
        [HttpGet]
        public IActionResult Index()
        {
            var albums = _context.Albums.ToList();
            return View(albums);
        }

        [Route("Album/Detail/{id}")]
        public IActionResult Detail(int id)
        {
            var album = _context.Albums.Include(a => a.Songs).FirstOrDefault(x => x.AlbumId == id);
            return View(album);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mvc.Areas.Identity.Data;
using mvc.Interfaces;

namespace mvc.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistRepository _artistRepo;

        public ArtistController(IArtistRepository artistRepo)
        {
            _artistRepo = artistRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var artists = await _artistRepo.GetAllAsync();
            return View(artists);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var artist = await _artistRepo.GetByIdAsync(id);
            return View(artist);
        }

        
    }
}
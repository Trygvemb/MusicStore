using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc.Interfaces;
using mvc.Models;

namespace mvc.Controllers
{
    public class SongController : Controller
    {
        private readonly ISongRepository _songRepo;

        public SongController(ISongRepository songRepo)
        {
            _songRepo = songRepo;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var songs = await _songRepo.GetAllAsync();
            return View(songs);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var song = await _songRepo.GetByIdAsync(id);
            return View(song);
        }

        [HttpGet]
        public IActionResult Create()
        {
                return View();
        }   

        
        [HttpPost]
        public async Task<IActionResult> Create(int id, Song song)
        {
            song.AlbumId = id;

            if (!ModelState.IsValid)
            {
                return View(song);
            }
            await _songRepo.AddAsync(song);
            return RedirectToAction("Detail", "Album", new { id = id });
        }   


    }
}
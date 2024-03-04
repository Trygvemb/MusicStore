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

        [Route("/Song")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var songs = await _songRepo.GetAllAsync();
            return View(songs);
        }

        [Route("/Song/Detail/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            var song = await _songRepo.GetByIdAsync(id);
            return View(song);
        }

        [Route("/Song/Create")]
        [HttpGet]
        public async Task<IActionResult> Create(Song song)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            //await _songRepo.AddAsync(song);
            //return RedirectToAction("Index");

            return View();
        }   



    }
}
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
            if (id == 0)
            {
                return RedirectToAction("Index", "Album");
            }
            song.AlbumId = id;

            if (!ModelState.IsValid)
            {
                return View(song);
            }
            await _songRepo.AddAsync(song);
            return RedirectToAction("Detail", "Album", new { id = id });
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var song = await _songRepo.GetByIdAsync(id);

            if (song == null) return View("Error");

            return View(song); // Pass the 'song' object directly as the view model
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Song song, int id) // Receive the 'Song' object directly
        {
            if (!ModelState.IsValid)
            {
                return View(song); // Pass the song object back to the view for re-rendering with errors
            }

            var oldSong = await _songRepo.GetByIdAsync(id);
            song.AlbumId = oldSong.AlbumId;

            _songRepo.Update(song);

            return RedirectToAction("Detail", new { id = song.SongId });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var song = await _songRepo.GetByIdAsync(id);

            if (song == null)
            {
                return View("Error"); // Handle song not found
            }

            return View(song); // Show confirmation view with song details
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var song = await _songRepo.GetByIdAsync(id);

            if (song == null)
            {
                return View("Error"); // Handle song not found
            }

            await _songRepo.RemoveAsync(song);
            return RedirectToAction("Detail", "Album", new { id = song.AlbumId });
        }

    }
}
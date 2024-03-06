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
using mvc.Models;

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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return View(artist);
            }
            await _artistRepo.AddAsync(artist);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var artist = await _artistRepo.GetByIdAsync(id);

            if (artist == null) return View("Error");

            return View(artist);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Artist artist, int id)
        {
            if (!ModelState.IsValid)
            {
                return View(artist);
            }

            artist.ArtistId = id;

            _artistRepo.Update(artist);

            return RedirectToAction("Detail", new { id = artist.ArtistId });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var artist = await _artistRepo.GetByIdAsync(id);

            if (artist == null)
            {
                return View("Error");
            }

            return View(artist);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var artist = await _artistRepo.GetByIdAsync(id);

            if (artist == null)
            {
                return View("Error");
            }

            await _artistRepo.RemoveAsync(artist);
            return RedirectToAction("Index");
        }

    }
}
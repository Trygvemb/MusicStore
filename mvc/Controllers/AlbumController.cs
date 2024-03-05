using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mvc.Data;
using mvc.Interfaces;
using mvc.Models;
using mvc.Repository;

namespace mvc.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumRepository _albumRepo;

        public AlbumController(IAlbumRepository albumRepo)
        {
            _albumRepo = albumRepo;

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Album> albums = await _albumRepo.GetAllAsync();
            return View(albums);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var album = await _albumRepo.GetByIdAsync(id);
            return View(album);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(int id, Album album)
        {
            if(id == 0)
            {
                return RedirectToAction("Index", "Artist");
            }

            album.ArtistId = id;

            if (!ModelState.IsValid)
            {
                return View(album);
            }
            await _albumRepo.AddAsync(album);
            return RedirectToAction("Detail", new { id = album.AlbumId });
        }
    }
}
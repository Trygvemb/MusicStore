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
        public IAlbumRepository _albumRepo { get; }

        public AlbumController(IAlbumRepository albumRepo)
        {
            _albumRepo = albumRepo;
            
        }
        
        [Route("Album")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Album> albums = await _albumRepo.GetAllAsync();
            return View(albums);
        }

        [Route("Album/Detail/{id}")]
        public async Task<IActionResult> Detail(int id)
        {
            var album = await _albumRepo.GetByIdAsync(id);
            return View(album);
        }
    }
}
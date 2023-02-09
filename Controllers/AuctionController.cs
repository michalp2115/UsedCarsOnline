﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using UsedCarsOnline.Data;
using UsedCarsOnline.Models;
using UsedCarsOnline.Services.IRepository;

namespace UsedCarsOnline.Controllers
{
    public class AuctionController : Controller
    {
        private readonly IWebHostEnvironment _hostEnviroment;
        private readonly IAuctionRepository _auctionRepository;

        public AuctionController(IWebHostEnvironment hostEnviroment, IAuctionRepository auctionRepository)
        {
            _hostEnviroment = hostEnviroment;
            _auctionRepository = auctionRepository;
        }

        public IActionResult Index()
        {
            var objAuctionList = _auctionRepository.GetAll();
            return View(objAuctionList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Auction obj)
        {
            if (obj.ImageFile != null && obj.ImageFile.Length > 0)
            {
                var folderPath = Path.Combine(_hostEnviroment.WebRootPath, "images");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var filePath = Path.Combine(folderPath, obj.ImageFile.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    obj.ImageFile.CopyTo(fileStream);
                }
                obj.ImagePath = "/images/" + obj.ImageFile.FileName;
            }
            _auctionRepository.Add(obj);
            return RedirectToAction("Index");
        }

        //GET
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var auction = _auctionRepository.Get(id);
            if (auction == null)
            {
                return NotFound();
            }
            return View(auction);
        }

        [HttpPost]
        public IActionResult Edit(Auction obj)
        {
            if (obj.ImageFile != null && obj.ImageFile.Length > 0)
            {
                var folderPath = Path.Combine(_hostEnviroment.WebRootPath, "images");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                var filePath = Path.Combine(folderPath, obj.ImageFile.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    obj.ImageFile.CopyTo(fileStream);
                }
                obj.ImagePath = "/images/" + obj.ImageFile.FileName;
            }
            _auctionRepository.Update(obj);
            return RedirectToAction("Index");
        }


        //GET
        public IActionResult Delete(int id)
        {
            var auction = _auctionRepository.Get(id);
            if (auction == null)
            {
                return NotFound();
            }
            return View(auction);

        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int id)
        {
            _auctionRepository.Delete(id);
            return RedirectToAction("Index");
        }

        //GET
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var auction = _auctionRepository.Get(id.Value);
            if (auction == null)
            {
                return NotFound();
            }
            return View(auction);
        }
    }
}
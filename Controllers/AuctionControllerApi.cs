using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using UsedCarsOnline.Models;
using UsedCarsOnline.Services.IRepository;

namespace UsedCarsOnline.Controllers
{
    [Route("api/auctions")]
    [ApiController]
    [Authorize]
    public class AuctionApiController : ControllerBase
    {
        private readonly IAuctionRepository _auctionRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuctionApiController(IAuctionRepository auctionRepository, IHttpContextAccessor httpContextAccessor)
        {
            _auctionRepository = auctionRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var objAuctionList = _auctionRepository.GetAll();
            return Ok(objAuctionList);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var auction = _auctionRepository.Get(id);
            if (auction == null)
            {
                return NotFound();
            }
            return Ok(auction);
        }

        [HttpPost]
        public IActionResult Create([FromForm] Auction obj)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            obj.UserId = userId;

            if (obj.ImageFile != null && obj.ImageFile.Length > 0)
            {
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
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
            return Ok(obj);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromForm] Auction obj)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            obj.UserId = userId;

            var auction = _auctionRepository.Get(id);
            if (auction == null)
            {
                return NotFound();
            }

            if (obj.ImageFile != null && obj.ImageFile.Length > 0)
            {
                var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
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
            else
            {
                obj.ImagePath = auction.ImagePath;
            }

            obj.AuctionId = id;
            _auctionRepository.Update(obj, id);
            return Ok(obj);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var auction = _auctionRepository.Get(id);
            if (auction == null)
            {
                return NotFound();
            }

            _auctionRepository.Delete(id);
            return Ok(auction);
        }
    }
}

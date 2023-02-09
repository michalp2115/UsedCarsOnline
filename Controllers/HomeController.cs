using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UsedCarsOnline.Data;
using UsedCarsOnline.Models;
using UsedCarsOnline.Services.IRepository;
using UsedCarsOnline.ViewModels;

namespace UsedCarsOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAuctionRepository _auctionRepository;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, IAuctionRepository auctionRepository, ApplicationDbContext context)
        {
            _logger = logger;
            _auctionRepository = auctionRepository;
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Auction> auctionList = _auctionRepository.GetAll();
            return View(auctionList);
        }
        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Result(SearchViewModel search)
        {
            var auctions = _context.Auctions.AsQueryable();

            if (!String.IsNullOrEmpty(search.Make))
            {
                auctions = auctions.Where(x => x.Make.Contains(search.Make));
            }
            if (!String.IsNullOrEmpty(search.Model))
            {
                auctions = auctions.Where(x => x.Model.Contains(search.Model));
            }
            if (!String.IsNullOrEmpty(search.BodyType))
            {
                auctions = auctions.Where(x => x.BodyType.Contains(search.BodyType));
            }
            if (!String.IsNullOrEmpty(search.FuelType))
            {
                auctions = auctions.Where(x => x.FuelType.Contains(search.FuelType));
            }
            if (!String.IsNullOrEmpty(search.Year))
            {
                auctions = auctions.Where(x => x.Year.Contains(search.Year));
            }

            return View(auctions.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
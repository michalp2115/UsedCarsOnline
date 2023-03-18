using Microsoft.EntityFrameworkCore;
using UsedCarsOnline.Data;
using UsedCarsOnline.Models;
using UsedCarsOnline.Services.IRepository;

namespace UsedCarsOnline.Services
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly ApplicationDbContext _context;

        public AuctionRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Auction> GetAll()
        {
            return _context.Auctions.ToList();
        }
        public Auction Get(int id)
        {
            return _context.Auctions.Include(x=>x.User).FirstOrDefault(x=>x.AuctionId == id);
        }
        public Auction Add(Auction auction)
        {
            _context.Auctions.Add(auction);
            _context.SaveChanges();
            return auction;
        }
        public void Update(Auction auction, int id)
        {
            //_context.Auctions.Update(auction);
            var toUpdate = _context.Auctions.FirstOrDefault(x => x.AuctionId == id);
            string path = toUpdate.ImagePath;
            

            if (toUpdate != null)
            {
                toUpdate.AuctionId = auction.AuctionId;
                toUpdate.ImageFile = auction.ImageFile;
                toUpdate.ImagePath = auction.ImagePath;
                toUpdate.Make = auction.Make;
                toUpdate.Model = auction.Model;
                toUpdate.BodyType = auction.BodyType;
                toUpdate.FuelType = auction.FuelType;
                toUpdate.Year = auction.Year;
                toUpdate.Price = auction.Price;
                toUpdate.Mileage = auction.Mileage;
                toUpdate.Color = auction.Color;
                toUpdate.EngineCapacity = auction.EngineCapacity;
                toUpdate.EnginePower = auction.EnginePower;
                toUpdate.Gearbox = auction.Gearbox;
                toUpdate.Description = auction.Description;
            }
            if(auction.ImagePath == null)
            {
                toUpdate.ImagePath = path;
            }
            _context.SaveChanges();
            
        }
        public void Delete(int id)
        {
            var auction = _context.Auctions.Find(id);
            _context.Auctions.Remove(auction);
            _context.SaveChanges();
        }


    }
}

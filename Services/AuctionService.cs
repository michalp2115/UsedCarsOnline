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
            return _context.Auctions.Find(id);
        }
        public Auction Add(Auction auction)
        {
            _context.Auctions.Add(auction);
            _context.SaveChanges();
            return auction;
        }
        public void Update(Auction auction)
        {
            _context.Auctions.Update(auction);
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

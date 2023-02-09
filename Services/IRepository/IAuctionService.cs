using System.Linq.Expressions;
using UsedCarsOnline.Models;

namespace UsedCarsOnline.Services.IRepository
{
    public interface IAuctionRepository
    {
        IEnumerable<Auction> GetAll();
        Auction Get(int id);
        Auction Add(Auction auction);
        void Update(Auction auction);
        void Delete(int id);
    }
}

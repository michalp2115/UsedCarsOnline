using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsedCarsOnline.Models;

namespace UsedCarsOnline.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Auction>().HasData(
                new Auction { AuctionId = 1, Make = "Toyota", Model = "Camry", BodyType = "Sedan", FuelType = "Petrol", Year = "2015", Price = 10000, Mileage = 50000, Color = "White", EngineCapacity = 2000, EnginePower = 150, Gearbox = "Automatic", Description = "Description for the Toyota Camry", ImagePath = "/images/image1.jpg" },
                new Auction { AuctionId = 2, Make = "Honda", Model = "Civic", BodyType = "Sedan", FuelType = "Petrol", Year = "2017", Price = 15000, Mileage = 40000, Color = "Black", EngineCapacity = 1800, EnginePower = 140, Gearbox = "Manual", Description = "Description for the Honda Civic", ImagePath = "/images/image2.jpg" },
                new Auction { AuctionId = 3, Make = "Mazda", Model = "3", BodyType = "Sedan", FuelType = "Petrol", Year = "2019", Price = 20000, Mileage = 30000, Color = "Red", EngineCapacity = 2000, EnginePower = 160, Gearbox = "Automatic", Description = "Description for the Mazda 3", ImagePath = "/images/image3.jpg" }
            );
        }
       
    }
}

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Markup;

namespace UsedCarsOnline.Models
{
    public class Auction
    {
        [Key]
        public int AuctionId { get; set; }

        [MaxLength(20)]
        public string Make { get; set; }

        [MaxLength(20)]
        public string Model { get; set; }

        [MaxLength(20)]
        public string BodyType { get; set; }

        [MaxLength(10)]
        public string FuelType { get; set; }

        public string Year { get; set; }

        public string Price { get; set; }

        public string Mileage { get; set; }

        [MaxLength(20)]
        public string Color { get; set; }

        public string EngineCapacity { get; set; }

        public string EnginePower { get; set; }

        [MaxLength(20)]
        public string Gearbox { get; set; }


        public string Description { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public User User { get; set; }
    }
}

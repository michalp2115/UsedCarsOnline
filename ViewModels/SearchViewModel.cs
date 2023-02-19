using System.ComponentModel.DataAnnotations;

namespace UsedCarsOnline.ViewModels
{
    public class SearchViewModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string BodyType { get; set; }
        public string FuelType { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public string Mileage { get; set; }
        public string Color { get; set; }
        public string EngineCapacity { get; set; }
        public string EnginePower { get; set; }
        public string Gearbox { get; set; }
    }
}

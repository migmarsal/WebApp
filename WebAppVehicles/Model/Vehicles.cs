using System.ComponentModel.DataAnnotations;

namespace WebAppVehicles.Model
{
    public class Vehicles
    {
        [Key]
        public int IdVehicle { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
    }
}

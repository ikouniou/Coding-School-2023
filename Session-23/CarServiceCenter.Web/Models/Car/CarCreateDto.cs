using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Web.Models.Car {
    public class CarCreateDto {
        [MaxLength(30, ErrorMessage = "Very Big Input")]
        public string Brand { get; set; } = null!;
        [MaxLength(50, ErrorMessage = "Very Big Input")]
        public string Model { get; set; } = null!;
        [MaxLength(10, ErrorMessage = "Very Big Input")]
        public string CarRegistrationNumber { get; set; } = null!;
    }
}

using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Web.Models.Car {
    public class CarEditDto {
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Very Big Input")]
        public string Brand { get; set; } = null!;
        [MaxLength(50, ErrorMessage = "Very Big Input")]
        public string Model { get; set; } = null!;
        [MaxLength(10, ErrorMessage = "Very Big Input")]
        public string CarRegistrationNumber { get; set; } = null!;
    }
}

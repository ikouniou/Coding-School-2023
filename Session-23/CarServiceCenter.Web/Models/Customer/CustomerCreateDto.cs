using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Web.Models.Customer {
    public class CustomerCreateDto {
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [MaxLength(100)]
        public string Surname { get; set; } = null!;
        [MaxLength(15)]
        public string Phone { get; set; } = null!;
        [MaxLength(30)]
        public string Tin { get; set; } = null!;
    }
}

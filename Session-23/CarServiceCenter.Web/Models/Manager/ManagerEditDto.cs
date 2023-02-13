using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Web.Models.Manager {
    public class ManagerEditDto {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [MaxLength(100)]
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
    }
}

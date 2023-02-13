using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Web.Models.ServiceTask {
    public class ServiceTaskEditDto {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Code { get; set; } = null!;
        [MaxLength(100)]
        public string Description { get; set; } = null!;
        [Precision(3, 2)]
        public decimal Hours { get; set; }
    }
}

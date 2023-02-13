using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Web.Models.Engineer {
    public class EngineerCreateDto {
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [MaxLength(100)]
        public string Surname { get; set; } = null!;
        public int SalaryPerMonth { get; set; }
        public int ManagerId { get; set; }
        public List<SelectListItem> Managers { get; } = new List<SelectListItem>();
    }
}

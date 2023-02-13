using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Web.Models.Engineer {
    public class EngineerEditDto {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [MaxLength(100)]
        public string Surname { get; set; } = null!;
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int SalaryPerMonth { get; set; }
        public int ManagerId { get; set; }
        public List<SelectListItem> Managers { get; } = new List<SelectListItem>();
    }
}

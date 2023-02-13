using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CarServiceCenter.Web.Models.TransactionLine {
    public class TransactionLineCreateDto {
        [Precision(3, 2)]
        public decimal Hours { get; set; }
        [Precision(4, 2)]
        public decimal PricePerHour { get; set; }
        [Precision(9, 2)]
        public decimal Price { get; set; }
        public int TransactionId { get; set; }
        public int ServiceTaskId { get; set; }
        public int EngineerId { get; set; }
        public List<SelectListItem> Transactions { get; } = new List<SelectListItem>();
        public List<SelectListItem> ServiceTasks { get; } = new List<SelectListItem>();
        public List<SelectListItem> Engineers { get; } = new List<SelectListItem>();
    }
}

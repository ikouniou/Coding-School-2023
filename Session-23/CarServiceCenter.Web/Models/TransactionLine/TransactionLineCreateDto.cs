using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenter.Web.Models.TransactionLine {
    public class TransactionLineCreateDto {
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Price { get; set; }
        public int TransactionId { get; set; }
        public int ServiceTaskId { get; set; }
        public int EngineerId { get; set; }
        public List<SelectListItem> Transactions { get; } = new List<SelectListItem>();
        public List<SelectListItem> ServiceTasks { get; } = new List<SelectListItem>();
        public List<SelectListItem> Engineers { get; } = new List<SelectListItem>();
    }
}

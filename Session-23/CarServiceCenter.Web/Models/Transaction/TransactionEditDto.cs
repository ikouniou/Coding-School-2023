using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenter.Web.Models.Transaction {
    public class TransactionEditDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public int ManagerId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public List<SelectListItem> Managers { get; } = new List<SelectListItem>();
        public List<SelectListItem> Customers { get; } = new List<SelectListItem>();
        public List<SelectListItem> Cars { get; } = new List<SelectListItem>();
    }
}

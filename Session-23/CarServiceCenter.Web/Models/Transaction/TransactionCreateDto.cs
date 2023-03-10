using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CarServiceCenter.Web.Models.Transaction {
    public class TransactionCreateDto {
        public DateTime Date { get; set; }
        [Precision(9, 2)]
        public decimal TotalPrice { get; set; }
        public int ManagerId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public List<SelectListItem> Managers { get; } = new List<SelectListItem>();
        public List<SelectListItem> Customers { get; } = new List<SelectListItem>();
        public List<SelectListItem> Cars { get; } = new List<SelectListItem>();

    }
}

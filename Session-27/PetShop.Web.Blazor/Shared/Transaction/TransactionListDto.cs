using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Web.Blazor.Shared.Transaction {
    public class TransactionListDto {
        public int Id { get; set; }
        public int Date { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}

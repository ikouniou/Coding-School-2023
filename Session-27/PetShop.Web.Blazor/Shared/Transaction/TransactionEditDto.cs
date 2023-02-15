using PetShop.Web.Blazor.Shared.Customer;
using PetShop.Web.Blazor.Shared.Employee;
using PetShop.Web.Blazor.Shared.Pet;
using PetShop.Web.Blazor.Shared.PetFood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Web.Blazor.Shared.Transaction {
    public class TransactionEditDto 
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; } 
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int PetId { get; set; }
        public int PetFoodId { get; set; }
        public List<CustomerEditDto> Customers { get; set; } = new();
        public List<EmployeeEditDto> Employees { get; set; } = new();
        public List<PetFoodEditDto> PetFoods{ get; set; } = new();
        public List<PetEditDto> Pets { get; set; } = new();
    }
}

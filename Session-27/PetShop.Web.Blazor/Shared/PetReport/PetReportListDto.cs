using PetShop.Model.Enums;
using PetShop.Web.Blazor.Shared.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Web.Blazor.Shared.PetReport {
    public class PetReportListDto {
        public int Year { get; set; }
        public int Month { get; set; }
        public AnimalType AnimalType { get; set; }
        public int TotalSold { get; set; }

        //public static List<PetReportListDto> FromTransactions(IEnumerable<TransactionListDto> transactions, int year, int month) {
        //    var result = new List<PetReportListDto>();

        //    foreach (AnimalType animalType in Enum.GetValues(typeof(AnimalType))) {
        //        int totalSold = transactions
        //            .Where(t => t.Date.Year == year && t.Date.Month == month)
        //            .Sum(t => t.PetFoodQty);

        //        result.Add(new PetReportListDto {
        //            Year = year,
        //            Month = month,
        //            AnimalType = animalType,
        //            TotalSold = totalSold
        //        });
        //    }

        //    return result;
        //}

    }
}
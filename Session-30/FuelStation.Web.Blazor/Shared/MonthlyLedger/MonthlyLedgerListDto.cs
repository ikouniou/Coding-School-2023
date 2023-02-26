using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Blazor.Shared.MonthlyLedger {
	public class MonthlyLedgerListDto {

		public MonthlyLedgerListDto(DateTime date) {
		    Year = date.Year;
			Month = date.Month;
		}
		public int Year { get; set; }
		public int Month { get; set; }
		public decimal Income { get; set; }
		public decimal Expenses { get; set; }
		public decimal Total { get; set; }

		public void UpdateValues(decimal income, decimal expenses) {
			Income = income;
			Expenses = expenses;
			Total = income - expenses;
		}
	}
}

using DevExpress.DataAccess.Native.Sql;
using DevExpress.DataAccess.Native.Web;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSpreadsheet.TileLayout;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared.Customer;
using FuelStation.Web.Blazor.Shared.Employee;
using FuelStation.Web.Blazor.Shared.Item;
using FuelStation.Web.Blazor.Shared.Transaction;
using FuelStation.Web.Blazor.Shared.TransactionLine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Desktop.WinForms {
	public partial class CashierForm : Form {
		public CashierForm() {
			InitializeComponent();
			grvCustomers.RowDeleted += grvCustomers_RowDeleted;
			grvCustomers.RowUpdated += grvCustomers_RowUpdated;
			grvCustomers.ValidatingEditor += grvCustomers_ValidatingEditor;

			grvTransactions.RowDeleted += grvTransactions_RowDeleted;
			grvTransactions.RowUpdated += grvTransactions_RowUpdated;

			grvTransactionLines.RowDeleted += grvTransactionLines_RowDeleted;
			grvTransactionLines.RowUpdated += grvTransactionLines_RowUpdated;
		}

		private void CashierForm_Load(object sender, EventArgs e) {

			GetCustomers();
			GetItems();
			GetEmployees();
			GetTransactions();
		}

		private async Task GetEmployees() {
			using (HttpClient client = new HttpClient()) {

				var response = await client.GetAsync("https://localhost:7119/employee");
				var data = await response.Content.ReadAsAsync<List<EmployeeListDto>>();

				repEmployees.DataSource = data;
				repEmployees.DisplayMember = "Surname";
				repEmployees.ValueMember = "Id";
			}
		}
		private async Task GetCustomers() {

			using (HttpClient client = new HttpClient()) {

				var response = await client.GetAsync("https://localhost:7119/customer");
				var data = await response.Content.ReadAsAsync<List<CustomerListDto>>();

				CustomersBs.DataSource = data;
				grdCustomers.DataSource = CustomersBs;

				repCustomers.DataSource = data;
				repCustomers.DisplayMember = "Surname";
				repCustomers.ValueMember = "Id";
			}

		}

		private async Task GetItems() {

			using (HttpClient client = new HttpClient()) {

				var response = await client.GetAsync("https://localhost:7119/item");
				var data = await response.Content.ReadAsAsync<List<ItemListDto>>();

				repItems.DataSource = data;
				repItems.DisplayMember = "Description";
				repItems.ValueMember = "Id";
			}

		}

		private void grdCustomers_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e) {
			if (e.Button.ButtonType == NavigatorButtonType.Remove) {
				DialogResult result = MessageBox.Show("Do you want to delete the current row?", "Confirm deletion",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					e.Handled = false; // Allow the row to be deleted
				} else {
					e.Handled = true; // Prevent the row from being deleted
				}
			}
		}

		private void grvCustomers_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e) {

			int deletedRowId = ((CustomerListDto)e.Row).Id;
			if(deletedRowId != 0) {
				DeleteRow(deletedRowId);
			}

		}

		private async Task DeleteRow(int row) {
			using (HttpClient client = new HttpClient()) {

				var response = await client.DeleteAsync($"https://localhost:7119/customer/{row}");
				if (!response.IsSuccessStatusCode) {
					MessageBox.Show("You can't delete this customer.");
					GetCustomers();
				}
			}
		}

		private void grvCustomers_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e) {

			if (e.RowHandle == GridControl.NewItemRowHandle) // check if the updated row is the new row
			{
				var Customer = (CustomerListDto)e.Row; // get the data object of the new row
				CustomerEditDto newCustomer = new();
				newCustomer.Name = Customer.Name;
				newCustomer.Surname = Customer.Surname;
				newCustomer.CardNumber = Customer.CardNumber;
				PostRow(newCustomer);
			} else {
				// handle updated row
				var row = (CustomerListDto)e.Row;
				if(row.Id != 0) {
					CustomerEditDto updatedRow = new();
					updatedRow.Id = row.Id;
					updatedRow.Name = row.Name;
					updatedRow.Surname = row.Surname;
					updatedRow.CardNumber = row.CardNumber;
					PutRow(updatedRow);
				} else {
					CustomerEditDto newCustomer = new();
					newCustomer.Name = row.Name;
					newCustomer.Surname = row.Surname;
					newCustomer.CardNumber = row.CardNumber;
					PostRow(newCustomer);
				}
				
			}
		}

		private async Task PostRow(CustomerEditDto newCustomer) {

			using (HttpClient client = new HttpClient()) {
				var response = await client.PostAsJsonAsync("https://localhost:7119/customer", newCustomer);
				response.EnsureSuccessStatusCode();

			}
			GetCustomers();
		}

		private async Task PutRow(CustomerEditDto updatedCustomer) {

			using (HttpClient client = new HttpClient()) {
				var response = await client.PutAsJsonAsync("https://localhost:7119/customer", updatedCustomer);
				response.EnsureSuccessStatusCode();

			}
			GetCustomers();
		}

		private void grvCustomers_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e) {
			GridView view = sender as GridView;

			if (view.FocusedColumn.FieldName == "Name") {
				if (string.IsNullOrEmpty(e.Value as string)) {
					e.Valid = false;
					e.ErrorText = "Name is required.";
				}

			} 
			else if (view.FocusedColumn.FieldName == "Surname") {
				if (string.IsNullOrEmpty(e.Value as string)) {
					e.Valid = false;
					e.ErrorText = "Surname is required.";
				}

			} else if (view.FocusedColumn.FieldName == "CardNumber") {
				string editedCardNumber = e.Value as string;
				Regex regex = new Regex("^A\\d+$");
				if (string.IsNullOrEmpty(e.Value as string)) {
					e.Valid = false;
					e.ErrorText = "Card Number is required.";
				} 
				else if (!regex.IsMatch(editedCardNumber)) {
					e.Valid = false;
					e.ErrorText = "Card Number must start with 'A' and have only numbers.";
				} else {
					for (int i = 0; i < view.DataRowCount; i++) {
						if (i == view.FocusedRowHandle) {
							continue;
						}
						string cardNumber = view.GetRowCellValue(i, "CardNumber") as string;
						if (cardNumber == editedCardNumber) {
							e.Valid = false;
							e.ErrorText = "Card Number must be unique.";
							break;
						}
					}
				}
			} 

		}

		private async Task GetTransactions() {

			using (HttpClient client = new HttpClient()) {

				var response = await client.GetAsync("https://localhost:7119/transaction");
				var data = await response.Content.ReadAsAsync<List<TransactionListDto>>();

				TransactionsBs.DataSource = data;
				foreach (TransactionListDto transaction in data) {
					decimal sum = 0;
					foreach (TransactionLineListDto transactionLine in transaction.TransactionLines) {
						sum += transactionLine.TotalValue;
					}
					transaction.TotalValue = sum;
				}
				grdTransactions.DataSource = TransactionsBs;

				

				TransactionLinesBs.DataSource = TransactionsBs;
				TransactionLinesBs.DataMember = "TransactionLines";
				grdTranssactionLines.DataSource = TransactionLinesBs;

			}

		}

		private void grdTransactions_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e) {
			if (e.Button.ButtonType == NavigatorButtonType.Remove) {
				DialogResult result = MessageBox.Show("Do you want to delete the current row?", "Confirm deletion",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					e.Handled = false; // Allow the row to be deleted
				} else {
					e.Handled = true; // Prevent the row from being deleted
				}
			}
		}

		private void grvTransactions_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e) {

			int deletedRowId = ((TransactionListDto)e.Row).Id;
			if (deletedRowId != 0) {
				DeleteRowTransaction(deletedRowId);
			}

		}

		private async Task DeleteRowTransaction(int row) {
			using (HttpClient client = new HttpClient()) {

				var response = await client.DeleteAsync($"https://localhost:7119/transaction/{row}");
				if (!response.IsSuccessStatusCode) {
					MessageBox.Show("You can't delete this transaction.");
					GetTransactions();
				} 
			}
		}

		private void grvTransactions_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e) {

			if (e.RowHandle == GridControl.NewItemRowHandle) // check if the updated row is the new row
			{
				var transaction = (TransactionListDto)e.Row; // get the data object of the new row
				TransactionEditDto newTransaction = new();
				if (transaction.CustomerId == 0 || transaction.EmployeeId == 0) {
					MessageBox.Show("All fields are required.");
					GetTransactions();
				} else {
					newTransaction.Date = DateTime.Now;
					newTransaction.PaymentMethod = transaction.PaymentMethod;
					newTransaction.TotalValue = transaction.TotalValue;
					newTransaction.CustomerId = transaction.CustomerId;
					newTransaction.EmployeeId = transaction.EmployeeId;
					PostRowTransaction(newTransaction);
				}
			} else {
				// handle updated row
				var row = (TransactionListDto)e.Row;
				if (row.Id != 0) {
					TransactionEditDto updatedRow = new();
					updatedRow.Id = row.Id;
					updatedRow.Date = row.Date;
					updatedRow.PaymentMethod = row.PaymentMethod;
					updatedRow.TotalValue = row.TotalValue;
					updatedRow.CustomerId = row.CustomerId;
					updatedRow.EmployeeId = row.EmployeeId;
					PutRowTransaction(updatedRow);
				} else {
					TransactionEditDto newTransaction = new();
					newTransaction.Date = DateTime.Now;
					newTransaction.PaymentMethod = row.PaymentMethod;
					newTransaction.TotalValue = row.TotalValue;
					newTransaction.CustomerId = row.CustomerId;
					newTransaction.EmployeeId = row.EmployeeId;
					PostRowTransaction(newTransaction);
				}

			}
		}

		private async Task PostRowTransaction(TransactionEditDto newTransaction) {

			using (HttpClient client = new HttpClient()) {
				var response = await client.PostAsJsonAsync("https://localhost:7119/transaction", newTransaction);
				response.EnsureSuccessStatusCode();

			}
			GetTransactions();
		}

		private async Task PutRowTransaction(TransactionEditDto updatedTransaction) {

			using (HttpClient client = new HttpClient()) {
				var response = await client.PutAsJsonAsync("https://localhost:7119/transaction", updatedTransaction);
				response.EnsureSuccessStatusCode();

			}
			GetTransactions();
		}

		private void grdTranssactionLines_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e) {
			if (e.Button.ButtonType == NavigatorButtonType.Remove) {
				DialogResult result = MessageBox.Show("Do you want to delete the current row?", "Confirm deletion",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (result == DialogResult.Yes) {
					e.Handled = false; // Allow the row to be deleted
				} else {
					e.Handled = true; // Prevent the row from being deleted
				}
			}
		}

		private void grvTransactionLines_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e) {

			int deletedRowId = ((TransactionLineListDto)e.Row).Id;
			if (deletedRowId != 0) {
				DeleteRowTransactionLine(deletedRowId);
			}

		}

		private async Task DeleteRowTransactionLine(int row) {
			using (HttpClient client = new HttpClient()) {

				var response = await client.DeleteAsync($"https://localhost:7119/transactionLine/{row}");
				GetTransactions();
			}
		}

		private async Task<decimal> GetItemById(int id) {
			using (HttpClient client = new HttpClient()) {

				var response = await client.GetAsync($"https://localhost:7119/item/{id}");
				var item = await response.Content.ReadAsAsync<ItemEditDto>();

				return item.Price;
			}
		}

		private async void grvTransactionLines_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e) {

			if (e.RowHandle == GridControl.NewItemRowHandle) // check if the updated row is the new row
			{
				var transactionLine = (TransactionLineListDto)e.Row; // get the data object of the new row
				TransactionLineEditDto newTransactionLine = new();
				if (transactionLine.ItemId == 0) {
					MessageBox.Show("All fields are required.");
					GetTransactions();
				} else {
					var itemPrice = await GetItemById(transactionLine.ItemId);
					newTransactionLine.Quantity = transactionLine.Quantity;
					newTransactionLine.ItemPrice = itemPrice;
					newTransactionLine.NetValue = transactionLine.Quantity * newTransactionLine.ItemPrice;
					newTransactionLine.DiscountPercent = transactionLine.DiscountPercent;
					newTransactionLine.DiscountValue = newTransactionLine.DiscountPercent / 100.0m * newTransactionLine.NetValue;
					newTransactionLine.TotalValue = newTransactionLine.NetValue - newTransactionLine.DiscountValue;
					newTransactionLine.TransactionId = transactionLine.TransactionId;
					newTransactionLine.ItemId = transactionLine.ItemId;
					PostRowTransactionLine(newTransactionLine);
				}
			} else {
				// handle updated row
				var row = (TransactionLineListDto)e.Row;
				var itemPrice = await GetItemById(row.ItemId);
				if (row.Id != 0) {
					TransactionLineEditDto updatedRow = new();
					updatedRow.Id = row.Id;
					updatedRow.Quantity = row.Quantity;
					updatedRow.ItemPrice = itemPrice;
					updatedRow.NetValue = row.Quantity * updatedRow.ItemPrice;
					updatedRow.DiscountPercent = row.DiscountPercent;
					updatedRow.DiscountValue = updatedRow.DiscountPercent / 100.0m * updatedRow.NetValue;
					updatedRow.TotalValue = updatedRow.NetValue - updatedRow.DiscountValue;
					updatedRow.TransactionId = row.TransactionId;
					updatedRow.ItemId = row.ItemId;
					PutRowTransactionLine(updatedRow);
				} else {
					TransactionLineEditDto newTransactionLine = new();
					newTransactionLine.Quantity = row.Quantity;
					newTransactionLine.ItemPrice = itemPrice;
					newTransactionLine.NetValue = row.Quantity * newTransactionLine.ItemPrice;
					newTransactionLine.DiscountPercent = row.DiscountPercent;
					newTransactionLine.DiscountValue = newTransactionLine.DiscountPercent / 100.0m * newTransactionLine.NetValue;
					newTransactionLine.TotalValue = newTransactionLine.NetValue - newTransactionLine.DiscountValue;
					newTransactionLine.TransactionId = row.TransactionId;
					newTransactionLine.ItemId = row.ItemId;
					PostRowTransactionLine(newTransactionLine);
				}

			}
		}

		private async Task PostRowTransactionLine(TransactionLineEditDto newTransactionLine) {

			using (HttpClient client = new HttpClient()) {
				var response = await client.PostAsJsonAsync("https://localhost:7119/transactionline", newTransactionLine);
				response.EnsureSuccessStatusCode();

			}
			GetTransactions();
		}

		private async Task PutRowTransactionLine(TransactionLineEditDto updatedTransactionLine) {

			using (HttpClient client = new HttpClient()) {
				var response = await client.PutAsJsonAsync("https://localhost:7119/transactionline", updatedTransactionLine);
				response.EnsureSuccessStatusCode();

			}
			GetTransactions();
		}
	}
}

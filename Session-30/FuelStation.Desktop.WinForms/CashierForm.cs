using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.DataAccess.Native.Sql;
using DevExpress.DataAccess.Native.Web;
using DevExpress.Mvvm.POCO;
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
			grvTransactionLines.ValidatingEditor += grvTransactionLines_ValidatingEditor;
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
				grdTransactions.DataSource = TransactionsBs;

				

				TransactionLinesBs.DataSource = TransactionsBs;
				TransactionLinesBs.DataMember = "TransactionLines";
				grdTranssactionLines.DataSource = TransactionLinesBs;

			}

		}

		private async Task<TransactionEditDto> GetLinesOfTransactions(int id) {
			using (HttpClient client = new HttpClient()) {

				var response = await client.GetAsync($"https://localhost:7119/transaction/{id}");
				var data = await response.Content.ReadAsAsync<TransactionEditDto>();

				decimal sum = 0;
				foreach (TransactionLineEditDto transactionLine in data.TransactionLines) {
					sum += transactionLine.TotalValue;
				}
				data.TotalValue = sum;

				return data;
				
			}
			
		}

		private async Task UpdateTransactionTotalValue(TransactionEditDto updatedTransaction) {
			using (HttpClient client = new HttpClient()) {

				if(updatedTransaction.TotalValue > 50 && updatedTransaction.PaymentMethod.ToString() == "CreditCard") {
					MessageBox.Show("The only acceptable payment method is Cash.");
					updatedTransaction.PaymentMethod = Model.Enums.PaymentMethod.Cash;
				}
				var response = await client.PutAsJsonAsync($"https://localhost:7119/transaction", updatedTransaction);
				response.EnsureSuccessStatusCode();
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
					if(transaction.TotalValue > 50 && transaction.PaymentMethod.ToString() == "CreditCard") {
						MessageBox.Show("The only acceptable payment method is Cash.");
						newTransaction.PaymentMethod = Model.Enums.PaymentMethod.Cash;
					} else {
						newTransaction.PaymentMethod = transaction.PaymentMethod;
					}
					newTransaction.Date = DateTime.Now;
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
					if (row.TotalValue > 50 && row.PaymentMethod.ToString() == "CreditCard") {
						MessageBox.Show("The only acceptable payment method is Cash.");
						updatedRow.PaymentMethod = Model.Enums.PaymentMethod.Cash;
					} else {
						updatedRow.PaymentMethod = row.PaymentMethod;
					}
					updatedRow.Id = row.Id;
					updatedRow.Date = row.Date;
					updatedRow.TotalValue = row.TotalValue;
					updatedRow.CustomerId = row.CustomerId;
					updatedRow.EmployeeId = row.EmployeeId;
					PutRowTransaction(updatedRow);
				} else {
					TransactionEditDto newTransaction = new();
					if (row.TotalValue > 50 && row.PaymentMethod.ToString() == "CreditCard") {
						MessageBox.Show("The only acceptable payment method is Cash.");
						newTransaction.PaymentMethod = Model.Enums.PaymentMethod.Cash;
					} else {
						newTransaction.PaymentMethod = row.PaymentMethod;
					}
					newTransaction.Date = DateTime.Now;
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

		private async void grvTransactionLines_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e) {

			int deletedRowId = ((TransactionLineListDto)e.Row).Id;
			int transactionId = ((TransactionLineListDto)e.Row).TransactionId;
			if (deletedRowId != 0) {
				await DeleteRowTransactionLine(deletedRowId);
				var updatedTransaction = await GetLinesOfTransactions(transactionId);
				await UpdateTransactionTotalValue(updatedTransaction);
				await GetTransactions();
			}

		}

		private async Task DeleteRowTransactionLine(int row) {
			using (HttpClient client = new HttpClient()) {

				var response = await client.DeleteAsync($"https://localhost:7119/transactionLine/{row}");
				
			}
		}

		private async Task<ItemEditDto> GetItemById(int id) {
			using (HttpClient client = new HttpClient()) {

				var response = await client.GetAsync($"https://localhost:7119/item/{id}");
				var item = await response.Content.ReadAsAsync<ItemEditDto>();

				return item;
			}
		}

		private async void grvTransactionLines_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e) {
			GridView view = sender as GridView;

			int parentRowHandle = grvTransactions.FocusedRowHandle;
			int transactionIdValue = (int)grvTransactions.GetRowCellValue(parentRowHandle, "Id");

			if (e.RowHandle == GridControl.NewItemRowHandle) // check if the updated row is the new row
			{
				var transactionLine = (TransactionLineListDto)e.Row; // get the data object of the new row
				TransactionLineEditDto newTransactionLine = new();
				if (transactionLine.ItemId == 0) {
					MessageBox.Show("All fields are required.");
					GetTransactions();
				} else {
					bool hasFuelType = false;
					var item = await GetItemById(transactionLine.ItemId);
					if(item.ItemType.ToString() == "Fuel") {
						for (int i = 0; i < view.DataRowCount; i++) {
							if (i == view.FocusedRowHandle) {
								continue;
							}
							int itemIdInGrid = (int)view.GetRowCellValue(i, "ItemId");
							var itemTypeInGrid = await GetItemById(itemIdInGrid);
							if (itemTypeInGrid.ItemType.ToString() == item.ItemType.ToString()) {
								MessageBox.Show("A Transaction must have only one item that are type Fuel.");
								hasFuelType = true;
								break;
							}
						}
					}
					if(hasFuelType == false) {
						newTransactionLine.Quantity = transactionLine.Quantity;
						newTransactionLine.ItemPrice = item.Price;
						newTransactionLine.NetValue = transactionLine.Quantity * newTransactionLine.ItemPrice;
						if (item.ItemType.ToString() == "Fuel" && newTransactionLine.NetValue > 20) {
							newTransactionLine.DiscountPercent = 10;
						} else {
							newTransactionLine.DiscountPercent = 0;
						}
						newTransactionLine.DiscountValue = newTransactionLine.DiscountPercent / 100.0m * newTransactionLine.NetValue;
						newTransactionLine.TotalValue = newTransactionLine.NetValue - newTransactionLine.DiscountValue;
						newTransactionLine.TransactionId = transactionIdValue;
						newTransactionLine.ItemId = transactionLine.ItemId;
						await PostRowTransactionLine(newTransactionLine);
						var updatedTransaction = await GetLinesOfTransactions(newTransactionLine.TransactionId);
						await UpdateTransactionTotalValue(updatedTransaction);
						
					}
					GetTransactions();
					
				}
			} else {
				// handle updated row
				var row = (TransactionLineListDto)e.Row;
				var item = await GetItemById(row.ItemId);
				bool hasFuelType = false;
				if (item.ItemType.ToString() == "Fuel") {
					for (int i = 0; i < view.DataRowCount; i++) {
						if (i == view.FocusedRowHandle) {
							continue;
						}
						int itemIdInGrid = (int)view.GetRowCellValue(i, "ItemId");
						var itemTypeInGrid = await GetItemById(itemIdInGrid);
						if (itemTypeInGrid.ItemType.ToString() == item.ItemType.ToString()) {
							MessageBox.Show("A Transaction must have only one item that are type Fuel.");
							hasFuelType = true;
							break;
						}
					}
				}
				if(hasFuelType == false) {
					if (row.Id != 0) {
						TransactionLineEditDto updatedRow = new();
						updatedRow.Id = row.Id;
						updatedRow.Quantity = row.Quantity;
						updatedRow.ItemPrice = item.Price;
						updatedRow.NetValue = row.Quantity * updatedRow.ItemPrice;
						if (item.ItemType.ToString() == "Fuel" && updatedRow.NetValue > 20) {
							updatedRow.DiscountPercent = 10;
						} else {
							updatedRow.DiscountPercent = 0;
						}
						updatedRow.DiscountValue = updatedRow.DiscountPercent / 100.0m * updatedRow.NetValue;
						updatedRow.TotalValue = updatedRow.NetValue - updatedRow.DiscountValue;
						updatedRow.TransactionId = transactionIdValue;
						updatedRow.ItemId = row.ItemId;
						await PutRowTransactionLine(updatedRow);
						var updatedTransaction = await GetLinesOfTransactions(updatedRow.TransactionId);
						await UpdateTransactionTotalValue(updatedTransaction);
						
					} 
					else {
						TransactionLineEditDto newTransactionLine = new();
						newTransactionLine.Quantity = row.Quantity;
						newTransactionLine.ItemPrice = item.Price;
						newTransactionLine.NetValue = row.Quantity * newTransactionLine.ItemPrice;
						if (item.ItemType.ToString() == "Fuel" && newTransactionLine.NetValue > 20) {
							newTransactionLine.DiscountPercent = 10;
						} else {
							newTransactionLine.DiscountPercent = 0;
						}
						newTransactionLine.DiscountValue = newTransactionLine.DiscountPercent / 100.0m * newTransactionLine.NetValue;
						newTransactionLine.TotalValue = newTransactionLine.NetValue - newTransactionLine.DiscountValue;
						newTransactionLine.TransactionId = transactionIdValue;
						newTransactionLine.ItemId = row.ItemId;
						await PostRowTransactionLine(newTransactionLine);
						var updatedTransaction = await GetLinesOfTransactions(newTransactionLine.TransactionId);
						await UpdateTransactionTotalValue(updatedTransaction);
						
					}
				}
				GetTransactions();

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

		private void grvTransactionLines_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e) {
			GridView view = sender as GridView;

			if(view.FocusedColumn.FieldName == "Quantity") {
				double quantity = 0;
				if(string.IsNullOrEmpty(e.Value as string)) {
					e.Valid = false;
					e.ErrorText = "Quantity is required";
				}
				else if (!Double.TryParse(e.Value as String, out quantity)) {
					e.Valid = false;
					e.ErrorText = "Only numeric values are accepted.";
				}
				else if(quantity < 1 || quantity > 100) {
					e.Valid = false;
					e.ErrorText = "Quantity must be between 1 and 100";
				}
			}

		}

		private void btnDeleteCustomer_Click(object sender, EventArgs e) {
			
			DialogResult result = MessageBox.Show("Do you want to delete the current row?", "Confirm deletion",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) {
				int deletedRowId = ((CustomerListDto)CustomersBs.Current).Id;
				if (deletedRowId != 0) {
					DeleteRow(deletedRowId);
				}
				CustomersBs.RemoveCurrent();
			}
		}

		private void btnDeleteTransaction_Click(object sender, EventArgs e) {

			DialogResult result = MessageBox.Show("Do you want to delete the current row?", "Confirm deletion",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) {
				int deletedRowId = ((TransactionListDto)TransactionsBs.Current).Id;
				if (deletedRowId != 0) {
					DeleteRowTransaction(deletedRowId);
				}
				TransactionsBs.RemoveCurrent();
			}
		}

		private async void btnDeleteTransactionLine_Click(object sender, EventArgs e) {

			DialogResult result = MessageBox.Show("Do you want to delete the current row?", "Confirm deletion",
					MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) {
				int deletedRowId = ((TransactionLineListDto)TransactionLinesBs.Current).Id;
				int transactionId = ((TransactionLineListDto)TransactionLinesBs.Current).TransactionId;
				if (deletedRowId != 0) {
					await DeleteRowTransactionLine(deletedRowId);
					var updatedTransaction = await GetLinesOfTransactions(transactionId);
					await UpdateTransactionTotalValue(updatedTransaction);
					await GetTransactions();
				}
			}
		}

		private void btnAddCustomer_Click(object sender, EventArgs e) {
			CustomersBs.AddNew();
		}

		private void btnAddTransaction_Click(object sender, EventArgs e) {
			TransactionsBs.AddNew();
		}

		private void btnAddTransactionLine_Click(object sender, EventArgs e) {
			TransactionLinesBs.AddNew();
		}

		private void btnEndEditCustomer_Click(object sender, EventArgs e) {
			CustomersBs.EndEdit();
		}

		private void btnEndEditTransaction_Click(object sender, EventArgs e) {
			TransactionsBs.EndEdit();
		}

		private void btnEndEditTransactionLine_Click(object sender, EventArgs e) {
			TransactionLinesBs.EndEdit();
		}
	}
}

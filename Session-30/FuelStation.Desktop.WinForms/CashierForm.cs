using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSpreadsheet.TileLayout;
using FuelStation.Model;
using FuelStation.Web.Blazor.Shared.Customer;
using FuelStation.Web.Blazor.Shared.Employee;
using FuelStation.Web.Blazor.Shared.Transaction;
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
		}

		private void CashierForm_Load(object sender, EventArgs e) {

			GetCustomers();
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

	}
}

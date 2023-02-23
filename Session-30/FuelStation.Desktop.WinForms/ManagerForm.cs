using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using FuelStation.Web.Blazor.Shared.Customer;
using FuelStation.Web.Blazor.Shared.Item;
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
	public partial class ManagerForm : Form {
		public ManagerForm() {
			InitializeComponent();
			grvItems.RowDeleted += grvItems_RowDeleted;
			grvItems.RowUpdated += grvItems_RowUpdated;
			grvItems.ValidatingEditor += grvItems_ValidatingEditor;

			grvCustomers.RowDeleted += grvCustomers_RowDeleted;
			grvCustomers.RowUpdated += grvCustomers_RowUpdated;
			grvCustomers.ValidatingEditor += grvCustomers_ValidatingEditor;
		}

		private void ManagerForm_Load(object sender, EventArgs e) {

			GetItems();
			GetCustomers();
		}

		private async Task GetItems() {

			using (HttpClient client = new HttpClient()) {

				var response = await client.GetAsync("https://localhost:7119/item");
				var data = await response.Content.ReadAsAsync<List<ItemListDto>>();

				ItemBs.DataSource = data;
				grdItems.DataSource = ItemBs;
			}

		}

		private void grdItems_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e) {
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

		private void grvItems_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e) {

			int deletedRowId = ((ItemListDto)e.Row).Id;
			DeleteRow(deletedRowId);

		}

		private async Task DeleteRow(int row) {
			using (HttpClient client = new HttpClient()) {

				var response = await client.DeleteAsync($"https://localhost:7119/item/{row}");

			}
		}

		private void grvItems_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e) {

			if (e.RowHandle == GridControl.NewItemRowHandle) // check if the updated row is the new row
			{
				var Item = (ItemListDto)e.Row; // get the data object of the new row
				ItemEditDto newItem = new();
				newItem.Code = Item.Code;
				newItem.Description = Item.Description;
				newItem.ItemType = Item.ItemType;
				newItem.Price = Item.Price;
				newItem.Cost = Item.Cost;
				PostRow(newItem);
			} else {
				// handle updated row
				var row = (ItemListDto)e.Row;
				ItemEditDto updatedRow = new();
				updatedRow.Id = row.Id;
				updatedRow.Code = row.Code;
				updatedRow.Description = row.Description;
				updatedRow.ItemType = row.ItemType;
				updatedRow.Price = row.Price;
				updatedRow.Cost = row.Cost;
				PutRow(updatedRow);
			}
		}

		private async Task PostRow(ItemEditDto newItem) {

			using (HttpClient client = new HttpClient()) {
				var response = await client.PostAsJsonAsync("https://localhost:7119/item", newItem);
				response.EnsureSuccessStatusCode();

			}
			GetItems();
		}

		private async Task PutRow(ItemEditDto updatedItem) {

			using (HttpClient client = new HttpClient()) {
				var response = await client.PutAsJsonAsync("https://localhost:7119/item", updatedItem);
				response.EnsureSuccessStatusCode();

			}
			GetItems();
		}

		private void grvItems_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e) {
			GridView view = sender as GridView;

			if (view.FocusedColumn.FieldName == "Code") {
				string editedCode = e.Value as string;
				if (string.IsNullOrEmpty(e.Value as string)) {
					e.Valid = false;
					e.ErrorText = "Code is required.";
				} else {
					for (int i = 0; i < view.DataRowCount; i++) {
						if (i == view.FocusedRowHandle) {
							continue;
						}
						string code = view.GetRowCellValue(i, "Code") as string;
						if (code == editedCode) {
							e.Valid = false;
							e.ErrorText = "Code must be unique.";
							break;
						}
					}
				}
			} else if (view.FocusedColumn.FieldName == "Description") {
				if (string.IsNullOrEmpty(e.Value as string)) {
					e.Valid = false;
					e.ErrorText = "Description is required.";
				}
			} else if (view.FocusedColumn.FieldName == "Price") {
				double price = 0;
				if (string.IsNullOrEmpty(e.Value as string)) {
					e.Valid = false;
					e.ErrorText = "Price is required.";
				} else if (!Double.TryParse(e.Value as String, out price)) {
					e.Valid = false;
					e.ErrorText = "Only numeric values are accepted.";
				} else if (price < 0 || price > 999.99) {
					e.Valid = false;
					e.ErrorText = "The price must be between 0 and 999.99.";
				} else if (Math.Round(price, 2) != price) {
					e.Valid = false;
					e.ErrorText = "The price must have precision(5,2).";
				}

			} else if (view.FocusedColumn.FieldName == "Cost") {
				double price = 0;
				if (string.IsNullOrEmpty(e.Value as string)) {
					e.Valid = false;
					e.ErrorText = "Cost is required.";
				} else if (!Double.TryParse(e.Value as String, out price)) {
					e.Valid = false;
					e.ErrorText = "Only numeric values are accepted.";
				} else if (price < 0 || price > 999.99) {
					e.Valid = false;
					e.ErrorText = "The cost must be between 0 and 999.99.";
				} else if (Math.Round(price, 2) != price) {
					e.Valid = false;
					e.ErrorText = "The cost must have precision(5,2).";
				}

			}

		}

		private async Task GetCustomers() {

			using (HttpClient client = new HttpClient()) {

				var response = await client.GetAsync("https://localhost:7119/customer");
				var data = await response.Content.ReadAsAsync<List<CustomerListDto>>();

				CustomersBs.DataSource = data;
				grdCustomers.DataSource = CustomersBs;
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
			DeleteRowCustomer(deletedRowId);

		}

		private async Task DeleteRowCustomer(int row) {
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
				PostRowCustomer(newCustomer);
			} else {
				// handle updated row
				var row = (CustomerListDto)e.Row;
				CustomerEditDto updatedRow = new();
				updatedRow.Id = row.Id;
				updatedRow.Name = row.Name;
				updatedRow.Surname = row.Surname;
				updatedRow.CardNumber = row.CardNumber;
				PutRowCustomer(updatedRow);
			}
		}

		private async Task PostRowCustomer(CustomerEditDto newCustomer) {

			using (HttpClient client = new HttpClient()) {
				var response = await client.PostAsJsonAsync("https://localhost:7119/customer", newCustomer);
				response.EnsureSuccessStatusCode();

			}
			GetCustomers();
		}

		private async Task PutRowCustomer(CustomerEditDto updatedCustomer) {

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

			} else if (view.FocusedColumn.FieldName == "Surname") {
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
				} else if (!regex.IsMatch(editedCardNumber)) {
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
	}
}

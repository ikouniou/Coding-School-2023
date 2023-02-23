using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using FuelStation.Web.Blazor.Shared.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Desktop.WinForms {
	public partial class StaffForm : Form {
		public StaffForm() {
			InitializeComponent();
			grvItems.RowDeleted += grvItems_RowDeleted;
			grvItems.RowUpdated += grvItems_RowUpdated;
			grvItems.ValidatingEditor += grvItems_ValidatingEditor;

		}

		private void StaffForm_Load(object sender, EventArgs e) {

		    GetItems();

		}

		private async Task GetItems() {

			using (HttpClient client = new HttpClient()) {

				var response = await client.GetAsync("https://localhost:7119/item");
				var data = await response.Content.ReadAsAsync<List<ItemListDto>>();

				ItemBs.DataSource = data;
				grdItems.DataSource = ItemBs;
			}

		}

		private void grdItems_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e) {
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
			} 
			else {
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
			if (view.FocusedColumn.FieldName == "Price") {
				double price = 0;
				if (string.IsNullOrEmpty(e.Value as string)) {
					e.Valid = false;
					e.ErrorText = "Price is required.";
				}
				else if (!Double.TryParse(e.Value as String, out price)) {
					e.Valid = false;
					e.ErrorText = "Only numeric values are accepted.";
				}
				else if (price < 0 || price > 999.99) {
					e.Valid = false;
					e.ErrorText = "The price must be between 0 and 999.99.";
				}
	            else if (Math.Round(price, 2) != price) {
					e.Valid = false;
					e.ErrorText = "The price must have precision(5,2).";
				}
				
			}

			if (view.FocusedColumn.FieldName == "Cost") {
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

	}
}

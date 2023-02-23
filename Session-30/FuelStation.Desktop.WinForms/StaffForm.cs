using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
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
	}
}

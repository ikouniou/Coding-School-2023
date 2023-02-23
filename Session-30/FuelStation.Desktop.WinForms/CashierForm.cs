using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.TileLayout;
using FuelStation.Web.Blazor.Shared.Customer;
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
	public partial class CashierForm : Form {
		public CashierForm() {
			InitializeComponent();
			grvCustomers.RowDeleted += grvCustomers_RowDeleted;
		}

		private void CashierForm_Load(object sender, EventArgs e) {

			GetItems();
		}

		private async Task GetItems() {

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
			DeleteRow(deletedRowId);

		}

		private async Task DeleteRow(int row) {
			using (HttpClient client = new HttpClient()) {

				var response = await client.DeleteAsync($"https://localhost:7119/customer/{row}");

			}
		}
	}
}

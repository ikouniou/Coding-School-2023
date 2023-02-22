using DevExpress.ClipboardSource.SpreadsheetML;
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
	}
}

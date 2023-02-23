﻿using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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
			grvCustomers.RowUpdated += grvCustomers_RowUpdated;
			grvCustomers.ValidatingEditor += grvCustomers_ValidatingEditor;
		}

		private void CashierForm_Load(object sender, EventArgs e) {

			GetCustomers();
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
			DeleteRow(deletedRowId);

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
				CustomerEditDto updatedRow = new();
				updatedRow.Id = row.Id;
				updatedRow.Name = row.Name;
				updatedRow.Surname = row.Surname;
				updatedRow.CardNumber = row.CardNumber;
				PutRow(updatedRow);
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

			

		}
	}
}

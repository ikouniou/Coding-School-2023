using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Desktop.WinForms {
	public partial class ManagerMenu : Form {
		public ManagerMenu() {
			InitializeComponent();
		}

		private void btnItems_Click(object sender, EventArgs e) {
			StaffForm staffForm = new();
			staffForm.ShowDialog();
		}

		private void btnCustomersTransactions_Click(object sender, EventArgs e) {
			CashierForm cashierForm = new();
			cashierForm.ShowDialog();
		}
	}
}

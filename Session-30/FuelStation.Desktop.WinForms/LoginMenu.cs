namespace FuelStation.Desktop.WinForms {
	public partial class LoginMenu : Form {
		public LoginMenu() {
			InitializeComponent();
		}

		private void LoginMenu_Load(object sender, EventArgs e) {

		}

		private void btnManager_Click(object sender, EventArgs e) {
			ManagerForm managerForm = new();
			managerForm.ShowDialog();
		}

		private void btnStaff_Click(object sender, EventArgs e) {
			StaffMenu staffMenu = new();
			staffMenu.ShowDialog();
		}

		private void btnCashier_Click(object sender, EventArgs e) {
			CashierForm cashierForm = new();
			cashierForm.ShowDialog();
		}
	}
}
namespace FuelStation.Desktop.WinForms {
	partial class CashierForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
			this.Customers = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.grdCustomers = new DevExpress.XtraGrid.GridControl();
			this.grvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Transactions = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.CustomersBs = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
			this.tabPane1.SuspendLayout();
			this.Customers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CustomersBs)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPane1
			// 
			this.tabPane1.Controls.Add(this.Customers);
			this.tabPane1.Controls.Add(this.Transactions);
			this.tabPane1.Location = new System.Drawing.Point(12, 12);
			this.tabPane1.Name = "tabPane1";
			this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.Customers,
            this.Transactions});
			this.tabPane1.RegularSize = new System.Drawing.Size(776, 490);
			this.tabPane1.SelectedPage = this.Customers;
			this.tabPane1.Size = new System.Drawing.Size(776, 490);
			this.tabPane1.TabIndex = 0;
			this.tabPane1.Text = "tabPane1";
			// 
			// Customers
			// 
			this.Customers.Appearance.BackColor = System.Drawing.SystemColors.Control;
			this.Customers.Appearance.Options.UseBackColor = true;
			this.Customers.Caption = "Customers";
			this.Customers.Controls.Add(this.textEdit1);
			this.Customers.Controls.Add(this.grdCustomers);
			this.Customers.Name = "Customers";
			this.Customers.Size = new System.Drawing.Size(776, 449);
			// 
			// textEdit1
			// 
			this.textEdit1.EditValue = "Customers";
			this.textEdit1.Location = new System.Drawing.Point(9, 28);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
			this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.textEdit1.Properties.Appearance.Options.UseFont = true;
			this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
			this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.textEdit1.Size = new System.Drawing.Size(130, 34);
			this.textEdit1.TabIndex = 2;
			// 
			// grdCustomers
			// 
			this.grdCustomers.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.grdCustomers_EmbeddedNavigator_ButtonClick);
			this.grdCustomers.Location = new System.Drawing.Point(9, 68);
			this.grdCustomers.MainView = this.grvCustomers;
			this.grdCustomers.Name = "grdCustomers";
			this.grdCustomers.Size = new System.Drawing.Size(737, 308);
			this.grdCustomers.TabIndex = 0;
			this.grdCustomers.UseEmbeddedNavigator = true;
			this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCustomers});
			// 
			// grvCustomers
			// 
			this.grvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colSurname,
            this.colCardNumber});
			this.grvCustomers.GridControl = this.grdCustomers;
			this.grvCustomers.Name = "grvCustomers";
			this.grvCustomers.OptionsView.ShowGroupPanel = false;
			// 
			// colId
			// 
			this.colId.Caption = "Id";
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Visible = true;
			this.colId.VisibleIndex = 0;
			this.colId.Width = 94;
			// 
			// colName
			// 
			this.colName.Caption = "Name";
			this.colName.FieldName = "Name";
			this.colName.MinWidth = 25;
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 1;
			this.colName.Width = 94;
			// 
			// colSurname
			// 
			this.colSurname.Caption = "Surname";
			this.colSurname.FieldName = "Surname";
			this.colSurname.MinWidth = 25;
			this.colSurname.Name = "colSurname";
			this.colSurname.Visible = true;
			this.colSurname.VisibleIndex = 2;
			this.colSurname.Width = 94;
			// 
			// colCardNumber
			// 
			this.colCardNumber.Caption = "Card Number";
			this.colCardNumber.FieldName = "CardNumber";
			this.colCardNumber.MinWidth = 25;
			this.colCardNumber.Name = "colCardNumber";
			this.colCardNumber.Visible = true;
			this.colCardNumber.VisibleIndex = 3;
			this.colCardNumber.Width = 94;
			// 
			// Transactions
			// 
			this.Transactions.Caption = "Transactions";
			this.Transactions.Name = "Transactions";
			this.Transactions.Size = new System.Drawing.Size(776, 426);
			// 
			// CashierForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 514);
			this.Controls.Add(this.tabPane1);
			this.Name = "CashierForm";
			this.Text = "Cashier";
			this.Load += new System.EventHandler(this.CashierForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
			this.tabPane1.ResumeLayout(false);
			this.Customers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CustomersBs)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.Navigation.TabPane tabPane1;
		private DevExpress.XtraBars.Navigation.TabNavigationPage Customers;
		private DevExpress.XtraGrid.GridControl grdCustomers;
		private DevExpress.XtraGrid.Views.Grid.GridView grvCustomers;
		private DevExpress.XtraBars.Navigation.TabNavigationPage Transactions;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colSurname;
		private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
		private BindingSource CustomersBs;
	}
}
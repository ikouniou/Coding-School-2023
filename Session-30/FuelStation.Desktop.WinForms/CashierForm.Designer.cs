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
			this.grdTranssactionLines = new DevExpress.XtraGrid.GridControl();
			this.grvTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
			this.grdTransactions = new DevExpress.XtraGrid.GridControl();
			this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			this.CustomersBs = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
			this.tabPane1.SuspendLayout();
			this.Customers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
			this.Transactions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTranssactionLines)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CustomersBs)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPane1
			// 
			this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabPane1.Controls.Add(this.Customers);
			this.tabPane1.Controls.Add(this.Transactions);
			this.tabPane1.Location = new System.Drawing.Point(12, 12);
			this.tabPane1.Name = "tabPane1";
			this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.Customers,
            this.Transactions});
			this.tabPane1.RegularSize = new System.Drawing.Size(776, 616);
			this.tabPane1.SelectedPage = this.Customers;
			this.tabPane1.Size = new System.Drawing.Size(776, 616);
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
			this.Customers.Size = new System.Drawing.Size(776, 575);
			// 
			// textEdit1
			// 
			this.textEdit1.EditValue = "Customers";
			this.textEdit1.Enabled = false;
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
			this.grdCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.colId.Width = 94;
			// 
			// colName
			// 
			this.colName.Caption = "Name";
			this.colName.FieldName = "Name";
			this.colName.MinWidth = 25;
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 0;
			this.colName.Width = 94;
			// 
			// colSurname
			// 
			this.colSurname.Caption = "Surname";
			this.colSurname.FieldName = "Surname";
			this.colSurname.MinWidth = 25;
			this.colSurname.Name = "colSurname";
			this.colSurname.Visible = true;
			this.colSurname.VisibleIndex = 1;
			this.colSurname.Width = 94;
			// 
			// colCardNumber
			// 
			this.colCardNumber.Caption = "Card Number";
			this.colCardNumber.FieldName = "CardNumber";
			this.colCardNumber.MinWidth = 25;
			this.colCardNumber.Name = "colCardNumber";
			this.colCardNumber.Visible = true;
			this.colCardNumber.VisibleIndex = 2;
			this.colCardNumber.Width = 94;
			// 
			// Transactions
			// 
			this.Transactions.Caption = "Transactions";
			this.Transactions.Controls.Add(this.grdTranssactionLines);
			this.Transactions.Controls.Add(this.textEdit3);
			this.Transactions.Controls.Add(this.grdTransactions);
			this.Transactions.Controls.Add(this.textEdit2);
			this.Transactions.Name = "Transactions";
			this.Transactions.Size = new System.Drawing.Size(776, 575);
			// 
			// grdTranssactionLines
			// 
			this.grdTranssactionLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdTranssactionLines.Location = new System.Drawing.Point(3, 380);
			this.grdTranssactionLines.MainView = this.grvTransactionLines;
			this.grdTranssactionLines.Name = "grdTranssactionLines";
			this.grdTranssactionLines.Size = new System.Drawing.Size(770, 177);
			this.grdTranssactionLines.TabIndex = 6;
			this.grdTranssactionLines.UseEmbeddedNavigator = true;
			this.grdTranssactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactionLines});
			// 
			// grvTransactionLines
			// 
			this.grvTransactionLines.GridControl = this.grdTranssactionLines;
			this.grvTransactionLines.Name = "grvTransactionLines";
			this.grvTransactionLines.OptionsView.ShowGroupPanel = false;
			// 
			// textEdit3
			// 
			this.textEdit3.EditValue = "Transaction Lines";
			this.textEdit3.Enabled = false;
			this.textEdit3.Location = new System.Drawing.Point(0, 340);
			this.textEdit3.Name = "textEdit3";
			this.textEdit3.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
			this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textEdit3.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.textEdit3.Properties.Appearance.Options.UseBackColor = true;
			this.textEdit3.Properties.Appearance.Options.UseFont = true;
			this.textEdit3.Properties.Appearance.Options.UseForeColor = true;
			this.textEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.textEdit3.Size = new System.Drawing.Size(210, 34);
			this.textEdit3.TabIndex = 5;
			// 
			// grdTransactions
			// 
			this.grdTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdTransactions.Location = new System.Drawing.Point(3, 70);
			this.grdTransactions.MainView = this.grvTransactions;
			this.grdTransactions.Name = "grdTransactions";
			this.grdTransactions.Size = new System.Drawing.Size(770, 250);
			this.grdTransactions.TabIndex = 4;
			this.grdTransactions.UseEmbeddedNavigator = true;
			this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
			// 
			// grvTransactions
			// 
			this.grvTransactions.GridControl = this.grdTransactions;
			this.grvTransactions.Name = "grvTransactions";
			this.grvTransactions.OptionsView.ShowGroupPanel = false;
			// 
			// textEdit2
			// 
			this.textEdit2.EditValue = "Transactions";
			this.textEdit2.Enabled = false;
			this.textEdit2.Location = new System.Drawing.Point(3, 30);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
			this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textEdit2.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
			this.textEdit2.Properties.Appearance.Options.UseFont = true;
			this.textEdit2.Properties.Appearance.Options.UseForeColor = true;
			this.textEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.textEdit2.Size = new System.Drawing.Size(159, 34);
			this.textEdit2.TabIndex = 3;
			// 
			// CashierForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 640);
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
			this.Transactions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdTranssactionLines)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
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
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraGrid.GridControl grdTransactions;
		private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
		private DevExpress.XtraGrid.GridControl grdTranssactionLines;
		private DevExpress.XtraGrid.Views.Grid.GridView grvTransactionLines;
		private DevExpress.XtraEditors.TextEdit textEdit3;
	}
}
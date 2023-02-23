namespace FuelStation.Desktop.WinForms {
	partial class ManagerForm {
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
			this.customers = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.Items = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.grdItems = new DevExpress.XtraGrid.GridControl();
			this.grvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Transactions = new DevExpress.XtraBars.Navigation.TabNavigationPage();
			this.ItemBs = new System.Windows.Forms.BindingSource(this.components);
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			this.grdCustomers = new DevExpress.XtraGrid.GridControl();
			this.grvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colIdCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.CustomersBs = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
			this.tabPane1.SuspendLayout();
			this.customers.SuspendLayout();
			this.Items.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemBs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CustomersBs)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPane1
			// 
			this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabPane1.Controls.Add(this.customers);
			this.tabPane1.Controls.Add(this.Items);
			this.tabPane1.Controls.Add(this.Transactions);
			this.tabPane1.Location = new System.Drawing.Point(12, 12);
			this.tabPane1.Name = "tabPane1";
			this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.customers,
            this.Items,
            this.Transactions});
			this.tabPane1.RegularSize = new System.Drawing.Size(776, 426);
			this.tabPane1.SelectedPage = this.customers;
			this.tabPane1.Size = new System.Drawing.Size(776, 426);
			this.tabPane1.TabIndex = 0;
			this.tabPane1.Text = "tabPane1";
			// 
			// customers
			// 
			this.customers.Caption = "Customers";
			this.customers.Controls.Add(this.grdCustomers);
			this.customers.Controls.Add(this.textEdit2);
			this.customers.Name = "customers";
			this.customers.Size = new System.Drawing.Size(776, 385);
			// 
			// Items
			// 
			this.Items.Caption = "Items";
			this.Items.Controls.Add(this.textEdit1);
			this.Items.Controls.Add(this.grdItems);
			this.Items.Name = "Items";
			this.Items.Size = new System.Drawing.Size(776, 385);
			// 
			// textEdit1
			// 
			this.textEdit1.EditValue = "Items";
			this.textEdit1.Location = new System.Drawing.Point(3, 21);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
			this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.textEdit1.Properties.Appearance.Options.UseFont = true;
			this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
			this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.textEdit1.Size = new System.Drawing.Size(106, 34);
			this.textEdit1.TabIndex = 2;
			// 
			// grdItems
			// 
			this.grdItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdItems.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.grdItems_EmbeddedNavigator_ButtonClick);
			this.grdItems.Location = new System.Drawing.Point(3, 61);
			this.grdItems.MainView = this.grvItems;
			this.grdItems.Name = "grdItems";
			this.grdItems.Size = new System.Drawing.Size(770, 284);
			this.grdItems.TabIndex = 0;
			this.grdItems.UseEmbeddedNavigator = true;
			this.grdItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvItems});
			// 
			// grvItems
			// 
			this.grvItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colDescription,
            this.colItemType,
            this.colPrice,
            this.colCost});
			this.grvItems.GridControl = this.grdItems;
			this.grvItems.Name = "grvItems";
			this.grvItems.OptionsView.ShowGroupPanel = false;
			// 
			// colId
			// 
			this.colId.Caption = "Id";
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Width = 94;
			// 
			// colCode
			// 
			this.colCode.Caption = "Code";
			this.colCode.FieldName = "Code";
			this.colCode.MinWidth = 25;
			this.colCode.Name = "colCode";
			this.colCode.Visible = true;
			this.colCode.VisibleIndex = 0;
			this.colCode.Width = 94;
			// 
			// colDescription
			// 
			this.colDescription.Caption = "Description";
			this.colDescription.FieldName = "Description";
			this.colDescription.MinWidth = 25;
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 1;
			this.colDescription.Width = 94;
			// 
			// colItemType
			// 
			this.colItemType.Caption = "Item Type";
			this.colItemType.FieldName = "ItemType";
			this.colItemType.MinWidth = 25;
			this.colItemType.Name = "colItemType";
			this.colItemType.Visible = true;
			this.colItemType.VisibleIndex = 2;
			this.colItemType.Width = 94;
			// 
			// colPrice
			// 
			this.colPrice.Caption = "Price";
			this.colPrice.FieldName = "Price";
			this.colPrice.MinWidth = 25;
			this.colPrice.Name = "colPrice";
			this.colPrice.Visible = true;
			this.colPrice.VisibleIndex = 3;
			this.colPrice.Width = 94;
			// 
			// colCost
			// 
			this.colCost.Caption = "Cost";
			this.colCost.FieldName = "Cost";
			this.colCost.MinWidth = 25;
			this.colCost.Name = "colCost";
			this.colCost.Visible = true;
			this.colCost.VisibleIndex = 4;
			this.colCost.Width = 94;
			// 
			// Transactions
			// 
			this.Transactions.Caption = "Transactions";
			this.Transactions.Name = "Transactions";
			this.Transactions.Size = new System.Drawing.Size(776, 426);
			// 
			// textEdit2
			// 
			this.textEdit2.EditValue = "Customers";
			this.textEdit2.Location = new System.Drawing.Point(3, 25);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
			this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textEdit2.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
			this.textEdit2.Properties.Appearance.Options.UseFont = true;
			this.textEdit2.Properties.Appearance.Options.UseForeColor = true;
			this.textEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.textEdit2.Size = new System.Drawing.Size(130, 34);
			this.textEdit2.TabIndex = 3;
			// 
			// grdCustomers
			// 
			this.grdCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdCustomers.Location = new System.Drawing.Point(3, 65);
			this.grdCustomers.MainView = this.grvCustomers;
			this.grdCustomers.Name = "grdCustomers";
			this.grdCustomers.Size = new System.Drawing.Size(770, 280);
			this.grdCustomers.TabIndex = 4;
			this.grdCustomers.UseEmbeddedNavigator = true;
			this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCustomers});
			// 
			// grvCustomers
			// 
			this.grvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCustomer,
            this.colName,
            this.colSurname,
            this.colCardNumber});
			this.grvCustomers.GridControl = this.grdCustomers;
			this.grvCustomers.Name = "grvCustomers";
			this.grvCustomers.OptionsView.ShowGroupPanel = false;
			// 
			// colIdCustomer
			// 
			this.colIdCustomer.Caption = "Id";
			this.colIdCustomer.FieldName = "Id";
			this.colIdCustomer.MinWidth = 25;
			this.colIdCustomer.Name = "colIdCustomer";
			this.colIdCustomer.Width = 94;
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
			// ManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabPane1);
			this.Name = "ManagerForm";
			this.Text = "Manager";
			this.Load += new System.EventHandler(this.ManagerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
			this.tabPane1.ResumeLayout(false);
			this.customers.ResumeLayout(false);
			this.Items.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemBs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CustomersBs)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.Navigation.TabPane tabPane1;
		private DevExpress.XtraBars.Navigation.TabNavigationPage customers;
		private DevExpress.XtraBars.Navigation.TabNavigationPage Items;
		private DevExpress.XtraGrid.GridControl grdItems;
		private DevExpress.XtraGrid.Views.Grid.GridView grvItems;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private DevExpress.XtraGrid.Columns.GridColumn colCode;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colItemType;
		private DevExpress.XtraGrid.Columns.GridColumn colPrice;
		private DevExpress.XtraGrid.Columns.GridColumn colCost;
		private DevExpress.XtraBars.Navigation.TabNavigationPage Transactions;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private BindingSource ItemBs;
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraGrid.GridControl grdCustomers;
		private DevExpress.XtraGrid.Views.Grid.GridView grvCustomers;
		private DevExpress.XtraGrid.Columns.GridColumn colIdCustomer;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colSurname;
		private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
		private BindingSource CustomersBs;
	}
}
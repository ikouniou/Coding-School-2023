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
			((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
			this.tabPane1.SuspendLayout();
			this.Items.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemBs)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPane1
			// 
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
			this.textEdit1.Location = new System.Drawing.Point(19, 21);
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
			this.grdItems.Location = new System.Drawing.Point(19, 61);
			this.grdItems.MainView = this.grvItems;
			this.grdItems.Name = "grdItems";
			this.grdItems.Size = new System.Drawing.Size(739, 284);
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
			this.Items.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemBs)).EndInit();
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
	}
}
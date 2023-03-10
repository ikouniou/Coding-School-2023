namespace FuelStation.Desktop.WinForms {
	partial class StaffForm {
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
			this.grdItems = new DevExpress.XtraGrid.GridControl();
			this.grvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ItemBs = new System.Windows.Forms.BindingSource(this.components);
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.btnDeleteItem = new System.Windows.Forms.Button();
			this.btnEndEditItem = new System.Windows.Forms.Button();
			this.btnCancelEditItem = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemBs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// grdItems
			// 
			this.grdItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdItems.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.grdItems_EmbeddedNavigator_ButtonClick);
			this.grdItems.Location = new System.Drawing.Point(12, 70);
			this.grdItems.MainView = this.grvItems;
			this.grdItems.Name = "grdItems";
			this.grdItems.Size = new System.Drawing.Size(776, 300);
			this.grdItems.TabIndex = 0;
			this.grdItems.UseEmbeddedNavigator = true;
			this.grdItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvItems});
			// 
			// grvItems
			// 
			this.grvItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colItemType,
            this.colPrice,
            this.colCost,
            this.colId});
			this.grvItems.GridControl = this.grdItems;
			this.grvItems.Name = "grvItems";
			this.grvItems.OptionsView.ShowGroupPanel = false;
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
			// colId
			// 
			this.colId.Caption = "Id";
			this.colId.FieldName = "Id";
			this.colId.MinWidth = 25;
			this.colId.Name = "colId";
			this.colId.Width = 94;
			// 
			// textEdit1
			// 
			this.textEdit1.EditValue = "Items";
			this.textEdit1.Enabled = false;
			this.textEdit1.Location = new System.Drawing.Point(12, 30);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
			this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.textEdit1.Properties.Appearance.Options.UseFont = true;
			this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
			this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.textEdit1.Size = new System.Drawing.Size(106, 34);
			this.textEdit1.TabIndex = 1;
			// 
			// btnAddItem
			// 
			this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnAddItem.Location = new System.Drawing.Point(12, 376);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(106, 48);
			this.btnAddItem.TabIndex = 2;
			this.btnAddItem.Text = "Add";
			this.btnAddItem.UseVisualStyleBackColor = true;
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// btnDeleteItem
			// 
			this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDeleteItem.ForeColor = System.Drawing.Color.Red;
			this.btnDeleteItem.Location = new System.Drawing.Point(124, 376);
			this.btnDeleteItem.Name = "btnDeleteItem";
			this.btnDeleteItem.Size = new System.Drawing.Size(106, 48);
			this.btnDeleteItem.TabIndex = 3;
			this.btnDeleteItem.Text = "Delete";
			this.btnDeleteItem.UseVisualStyleBackColor = true;
			this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
			// 
			// btnEndEditItem
			// 
			this.btnEndEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEndEditItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.btnEndEditItem.Location = new System.Drawing.Point(293, 376);
			this.btnEndEditItem.Name = "btnEndEditItem";
			this.btnEndEditItem.Size = new System.Drawing.Size(106, 48);
			this.btnEndEditItem.TabIndex = 4;
			this.btnEndEditItem.Text = "End Edit";
			this.btnEndEditItem.UseVisualStyleBackColor = true;
			this.btnEndEditItem.Click += new System.EventHandler(this.btnEndEditItem_Click);
			// 
			// btnCancelEditItem
			// 
			this.btnCancelEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancelEditItem.ForeColor = System.Drawing.Color.Red;
			this.btnCancelEditItem.Location = new System.Drawing.Point(405, 376);
			this.btnCancelEditItem.Name = "btnCancelEditItem";
			this.btnCancelEditItem.Size = new System.Drawing.Size(106, 48);
			this.btnCancelEditItem.TabIndex = 5;
			this.btnCancelEditItem.Text = "Cancel Edit";
			this.btnCancelEditItem.UseVisualStyleBackColor = true;
			this.btnCancelEditItem.Click += new System.EventHandler(this.btnCancelEditItem_Click);
			// 
			// StaffForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCancelEditItem);
			this.Controls.Add(this.btnEndEditItem);
			this.Controls.Add(this.btnDeleteItem);
			this.Controls.Add(this.btnAddItem);
			this.Controls.Add(this.textEdit1);
			this.Controls.Add(this.grdItems);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "StaffForm";
			this.Text = "Items";
			this.Load += new System.EventHandler(this.StaffForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grvItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemBs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grdItems;
		private DevExpress.XtraGrid.Views.Grid.GridView grvItems;
		private DevExpress.XtraGrid.Columns.GridColumn colCode;
		private DevExpress.XtraGrid.Columns.GridColumn colDescription;
		private DevExpress.XtraGrid.Columns.GridColumn colItemType;
		private DevExpress.XtraGrid.Columns.GridColumn colPrice;
		private DevExpress.XtraGrid.Columns.GridColumn colCost;
		private BindingSource ItemBs;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraGrid.Columns.GridColumn colId;
		private Button btnAddItem;
		private Button btnDeleteItem;
		private Button btnEndEditItem;
		private Button btnCancelEditItem;
	}
}
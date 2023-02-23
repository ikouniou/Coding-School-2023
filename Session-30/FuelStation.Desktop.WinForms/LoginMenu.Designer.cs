namespace FuelStation.Desktop.WinForms {
	partial class LoginMenu {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnManager = new DevExpress.XtraEditors.SimpleButton();
			this.btnCashier = new DevExpress.XtraEditors.SimpleButton();
			this.btnStaff = new DevExpress.XtraEditors.SimpleButton();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// btnManager
			// 
			this.btnManager.Location = new System.Drawing.Point(127, 319);
			this.btnManager.Name = "btnManager";
			this.btnManager.Size = new System.Drawing.Size(158, 56);
			this.btnManager.TabIndex = 0;
			this.btnManager.Text = "Manager";
			this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
			// 
			// btnCashier
			// 
			this.btnCashier.Location = new System.Drawing.Point(645, 319);
			this.btnCashier.Name = "btnCashier";
			this.btnCashier.Size = new System.Drawing.Size(158, 56);
			this.btnCashier.TabIndex = 1;
			this.btnCashier.Text = "Cashier";
			this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
			// 
			// btnStaff
			// 
			this.btnStaff.Location = new System.Drawing.Point(390, 319);
			this.btnStaff.Name = "btnStaff";
			this.btnStaff.Size = new System.Drawing.Size(158, 56);
			this.btnStaff.TabIndex = 2;
			this.btnStaff.Text = "Staff";
			this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
			// 
			// textEdit1
			// 
			this.textEdit1.EditValue = "Login As:";
			this.textEdit1.Enabled = false;
			this.textEdit1.Location = new System.Drawing.Point(366, 100);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
			this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.textEdit1.Properties.Appearance.Options.UseFont = true;
			this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.textEdit1.Size = new System.Drawing.Size(266, 56);
			this.textEdit1.TabIndex = 4;
			// 
			// LoginMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 520);
			this.Controls.Add(this.textEdit1);
			this.Controls.Add(this.btnStaff);
			this.Controls.Add(this.btnCashier);
			this.Controls.Add(this.btnManager);
			this.Name = "LoginMenu";
			this.Text = "Login Menu";
			this.Load += new System.EventHandler(this.LoginMenu_Load);
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnManager;
		private DevExpress.XtraEditors.SimpleButton btnCashier;
		private DevExpress.XtraEditors.SimpleButton btnStaff;
		private DevExpress.XtraEditors.TextEdit textEdit1;
	}
}
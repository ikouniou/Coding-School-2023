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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMenu));
			this.btnManager = new DevExpress.XtraEditors.SimpleButton();
			this.btnCashier = new DevExpress.XtraEditors.SimpleButton();
			this.btnStaff = new DevExpress.XtraEditors.SimpleButton();
			this.panelRight = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panelRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnManager
			// 
			this.btnManager.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnManager.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.btnManager.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnManager.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.btnManager.Appearance.Options.UseBorderColor = true;
			this.btnManager.Appearance.Options.UseFont = true;
			this.btnManager.Appearance.Options.UseForeColor = true;
			this.btnManager.Location = new System.Drawing.Point(127, 200);
			this.btnManager.Name = "btnManager";
			this.btnManager.Size = new System.Drawing.Size(158, 56);
			this.btnManager.TabIndex = 0;
			this.btnManager.Text = "Manager";
			this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
			// 
			// btnCashier
			// 
			this.btnCashier.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCashier.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCashier.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.btnCashier.Appearance.Options.UseFont = true;
			this.btnCashier.Appearance.Options.UseForeColor = true;
			this.btnCashier.Location = new System.Drawing.Point(127, 401);
			this.btnCashier.Name = "btnCashier";
			this.btnCashier.Size = new System.Drawing.Size(158, 56);
			this.btnCashier.TabIndex = 1;
			this.btnCashier.Text = "Cashier";
			this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
			// 
			// btnStaff
			// 
			this.btnStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnStaff.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnStaff.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.btnStaff.Appearance.Options.UseFont = true;
			this.btnStaff.Appearance.Options.UseForeColor = true;
			this.btnStaff.Location = new System.Drawing.Point(127, 302);
			this.btnStaff.Name = "btnStaff";
			this.btnStaff.Size = new System.Drawing.Size(158, 56);
			this.btnStaff.TabIndex = 2;
			this.btnStaff.Text = "Staff";
			this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
			// 
			// panelRight
			// 
			this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.panelRight.Controls.Add(this.label1);
			this.panelRight.Controls.Add(this.pictureBox1);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelRight.Location = new System.Drawing.Point(0, 0);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(392, 524);
			this.panelRight.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Nova", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(96, 309);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 72);
			this.label1.TabIndex = 1;
			this.label1.Text = "Fuel Station\r\n       Gas-N-Go\r\n";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(96, 102);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 195);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panelLeft
			// 
			this.panelLeft.Controls.Add(this.label3);
			this.panelLeft.Controls.Add(this.label2);
			this.panelLeft.Controls.Add(this.btnCashier);
			this.panelLeft.Controls.Add(this.btnStaff);
			this.panelLeft.Controls.Add(this.btnManager);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLeft.Location = new System.Drawing.Point(392, 0);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(427, 524);
			this.panelLeft.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.label2.Location = new System.Drawing.Point(17, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 42);
			this.label2.TabIndex = 3;
			this.label2.Text = "Login";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.label3.Location = new System.Drawing.Point(25, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "Please select your Employee Type";
			// 
			// LoginMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(819, 524);
			this.Controls.Add(this.panelLeft);
			this.Controls.Add(this.panelRight);
			this.Name = "LoginMenu";
			this.Text = "Login Menu";
			this.Load += new System.EventHandler(this.LoginMenu_Load);
			this.panelRight.ResumeLayout(false);
			this.panelRight.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelLeft.ResumeLayout(false);
			this.panelLeft.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnManager;
		private DevExpress.XtraEditors.SimpleButton btnCashier;
		private DevExpress.XtraEditors.SimpleButton btnStaff;
		private Panel panelRight;
		private Panel panelLeft;
		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private Label label3;
	}
}
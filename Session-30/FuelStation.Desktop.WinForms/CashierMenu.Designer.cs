namespace FuelStation.Desktop.WinForms {
	partial class CashierMenu {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMenu));
			this.panelRight = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCustomersTransactions = new DevExpress.XtraEditors.SimpleButton();
			this.panelRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelRight
			// 
			this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.panelRight.Controls.Add(this.label4);
			this.panelRight.Controls.Add(this.label1);
			this.panelRight.Controls.Add(this.pictureBox1);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelRight.Location = new System.Drawing.Point(0, 0);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(392, 559);
			this.panelRight.TabIndex = 10;
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
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(79, 530);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(232, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Fuel Up - Power On - Drive Ahead";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.label3.Location = new System.Drawing.Point(447, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 42);
			this.label3.TabIndex = 11;
			this.label3.Text = "Cashiers";
			// 
			// btnCustomersTransactions
			// 
			this.btnCustomersTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCustomersTransactions.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCustomersTransactions.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.btnCustomersTransactions.Appearance.Options.UseFont = true;
			this.btnCustomersTransactions.Appearance.Options.UseForeColor = true;
			this.btnCustomersTransactions.Location = new System.Drawing.Point(527, 235);
			this.btnCustomersTransactions.Name = "btnCustomersTransactions";
			this.btnCustomersTransactions.Size = new System.Drawing.Size(178, 93);
			this.btnCustomersTransactions.TabIndex = 12;
			this.btnCustomersTransactions.Text = "Customers \r\nTransactions\r\nTransaction Lines";
			this.btnCustomersTransactions.Click += new System.EventHandler(this.btnCustomersTransactions_Click);
			// 
			// CashierMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(855, 559);
			this.Controls.Add(this.btnCustomersTransactions);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panelRight);
			this.Name = "CashierMenu";
			this.Text = "Cashier Menu";
			this.panelRight.ResumeLayout(false);
			this.panelRight.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel panelRight;
		private Label label1;
		private PictureBox pictureBox1;
		private Label label4;
		private Label label3;
		private DevExpress.XtraEditors.SimpleButton btnCustomersTransactions;
	}
}
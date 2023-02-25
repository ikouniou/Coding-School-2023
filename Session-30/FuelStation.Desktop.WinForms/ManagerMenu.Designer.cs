namespace FuelStation.Desktop.WinForms {
	partial class ManagerMenu {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
			this.btnCustomersTransactions = new DevExpress.XtraEditors.SimpleButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnItems = new DevExpress.XtraEditors.SimpleButton();
			this.panelRight = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCustomersTransactions
			// 
			this.btnCustomersTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCustomersTransactions.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnCustomersTransactions.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.btnCustomersTransactions.Appearance.Options.UseFont = true;
			this.btnCustomersTransactions.Appearance.Options.UseForeColor = true;
			this.btnCustomersTransactions.Location = new System.Drawing.Point(506, 324);
			this.btnCustomersTransactions.Name = "btnCustomersTransactions";
			this.btnCustomersTransactions.Size = new System.Drawing.Size(178, 93);
			this.btnCustomersTransactions.TabIndex = 15;
			this.btnCustomersTransactions.Text = "Customers \r\nTransactions\r\nTransaction Lines";
			this.btnCustomersTransactions.Click += new System.EventHandler(this.btnCustomersTransactions_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.label3.Location = new System.Drawing.Point(442, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 42);
			this.label3.TabIndex = 14;
			this.label3.Text = "Managers";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(82, 521);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Fuel Up - Power On - Drive Ahead";
			// 
			// btnItems
			// 
			this.btnItems.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnItems.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnItems.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.btnItems.Appearance.Options.UseFont = true;
			this.btnItems.Appearance.Options.UseForeColor = true;
			this.btnItems.Location = new System.Drawing.Point(506, 178);
			this.btnItems.Name = "btnItems";
			this.btnItems.Size = new System.Drawing.Size(178, 93);
			this.btnItems.TabIndex = 16;
			this.btnItems.Text = "Items";
			this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
			// 
			// panelRight
			// 
			this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(80)))));
			this.panelRight.Controls.Add(this.label1);
			this.panelRight.Controls.Add(this.label2);
			this.panelRight.Controls.Add(this.pictureBox1);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelRight.Location = new System.Drawing.Point(0, 0);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(392, 550);
			this.panelRight.TabIndex = 17;
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
			// ManagerMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 550);
			this.Controls.Add(this.panelRight);
			this.Controls.Add(this.btnItems);
			this.Controls.Add(this.btnCustomersTransactions);
			this.Controls.Add(this.label3);
			this.Name = "ManagerMenu";
			this.Text = "Manager Menu";
			this.panelRight.ResumeLayout(false);
			this.panelRight.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnCustomersTransactions;
		private Label label3;
		private Label label2;
		private DevExpress.XtraEditors.SimpleButton btnItems;
		private Panel panelRight;
		private Label label1;
		private PictureBox pictureBox1;
	}
}
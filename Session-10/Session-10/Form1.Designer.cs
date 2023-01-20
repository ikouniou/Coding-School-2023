namespace Session_10 {
    partial class Form1 {
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.dgvScheduledCourse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 12);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 29;
            this.dgvStudents.Size = new System.Drawing.Size(752, 85);
            this.dgvStudents.TabIndex = 0;
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(12, 116);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 51;
            this.dgvCourses.RowTemplate.Height = 29;
            this.dgvCourses.Size = new System.Drawing.Size(752, 91);
            this.dgvCourses.TabIndex = 1;
            // 
            // dgvGrades
            // 
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(12, 213);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.RowHeadersWidth = 51;
            this.dgvGrades.RowTemplate.Height = 29;
            this.dgvGrades.Size = new System.Drawing.Size(752, 102);
            this.dgvGrades.TabIndex = 2;
            // 
            // dgvScheduledCourse
            // 
            this.dgvScheduledCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduledCourse.Location = new System.Drawing.Point(12, 343);
            this.dgvScheduledCourse.Name = "dgvScheduledCourse";
            this.dgvScheduledCourse.RowHeadersWidth = 51;
            this.dgvScheduledCourse.RowTemplate.Height = 29;
            this.dgvScheduledCourse.Size = new System.Drawing.Size(752, 115);
            this.dgvScheduledCourse.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 470);
            this.Controls.Add(this.dgvScheduledCourse);
            this.Controls.Add(this.dgvGrades);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.dgvStudents);
            this.Name = "Form1";
            this.Text = "University";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvStudents;
        private DataGridView dgvCourses;
        private DataGridView dgvGrades;
        private DataGridView dgvScheduledCourse;
    }
}
namespace LAB2
{
    partial class ShowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.spc_main = new System.Windows.Forms.SplitContainer();
            this.dgw_courses = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_tot = new System.Windows.Forms.Label();
            this.spc_main.Panel1.SuspendLayout();
            this.spc_main.Panel2.SuspendLayout();
            this.spc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // spc_main
            // 
            this.spc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_main.Location = new System.Drawing.Point(0, 0);
            this.spc_main.Name = "spc_main";
            this.spc_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_main.Panel1
            // 
            this.spc_main.Panel1.Controls.Add(this.lb_tot);
            this.spc_main.Panel1.Controls.Add(this.btn_add);
            // 
            // spc_main.Panel2
            // 
            this.spc_main.Panel2.Controls.Add(this.dgw_courses);
            this.spc_main.Size = new System.Drawing.Size(700, 506);
            this.spc_main.SplitterDistance = 26;
            this.spc_main.TabIndex = 0;
            // 
            // dgw_courses
            // 
            this.dgw_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_courses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_courses.Location = new System.Drawing.Point(0, 0);
            this.dgw_courses.Name = "dgw_courses";
            this.dgw_courses.RowHeadersWidth = 51;
            this.dgw_courses.RowTemplate.Height = 24;
            this.dgw_courses.Size = new System.Drawing.Size(700, 476);
            this.dgw_courses.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(575, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add new Course";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // lb_tot
            // 
            this.lb_tot.AutoSize = true;
            this.lb_tot.ForeColor = System.Drawing.Color.OliveDrab;
            this.lb_tot.Location = new System.Drawing.Point(4, 8);
            this.lb_tot.Name = "lb_tot";
            this.lb_tot.Size = new System.Drawing.Size(97, 18);
            this.lb_tot.TabIndex = 1;
            this.lb_tot.Text = "Total: 0 Course";
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 506);
            this.Controls.Add(this.spc_main);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ShowForm";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.ShowForm_Load);
            this.spc_main.Panel1.ResumeLayout(false);
            this.spc_main.Panel1.PerformLayout();
            this.spc_main.Panel2.ResumeLayout(false);
            this.spc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_courses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spc_main;
        private System.Windows.Forms.Label lb_tot;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgw_courses;
    }
}
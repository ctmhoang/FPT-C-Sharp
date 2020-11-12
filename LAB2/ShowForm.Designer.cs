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
            this.btn_show = new System.Windows.Forms.Button();
            this.lb_tot = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgw_courses = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
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
            this.spc_main.Margin = new System.Windows.Forms.Padding(4);
            this.spc_main.Name = "spc_main";
            this.spc_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_main.Panel1
            // 
            this.spc_main.Panel1.Controls.Add(this.btnEdit);
            this.spc_main.Panel1.Controls.Add(this.btn_delete);
            this.spc_main.Panel1.Controls.Add(this.btn_show);
            this.spc_main.Panel1.Controls.Add(this.lb_tot);
            this.spc_main.Panel1.Controls.Add(this.btn_add);
            // 
            // spc_main.Panel2
            // 
            this.spc_main.Panel2.Controls.Add(this.dgw_courses);
            this.spc_main.Size = new System.Drawing.Size(900, 619);
            this.spc_main.SplitterDistance = 31;
            this.spc_main.SplitterWidth = 5;
            this.spc_main.TabIndex = 0;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(635, 4);
            this.btn_show.Margin = new System.Windows.Forms.Padding(4);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(96, 28);
            this.btn_show.TabIndex = 0;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // lb_tot
            // 
            this.lb_tot.AutoSize = true;
            this.lb_tot.ForeColor = System.Drawing.Color.OliveDrab;
            this.lb_tot.Location = new System.Drawing.Point(5, 10);
            this.lb_tot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tot.Name = "lb_tot";
            this.lb_tot.Size = new System.Drawing.Size(123, 23);
            this.lb_tot.TabIndex = 1;
            this.lb_tot.Text = "Total: 0 Course";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(739, 4);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(157, 28);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add new Course";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgw_courses
            // 
            this.dgw_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_courses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_courses.Location = new System.Drawing.Point(0, 0);
            this.dgw_courses.Margin = new System.Windows.Forms.Padding(4);
            this.dgw_courses.Name = "dgw_courses";
            this.dgw_courses.RowHeadersWidth = 51;
            this.dgw_courses.RowTemplate.Height = 24;
            this.dgw_courses.Size = new System.Drawing.Size(900, 583);
            this.dgw_courses.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(553, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 29);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(472, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // ShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 619);
            this.Controls.Add(this.spc_main);
            this.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btn_delete;
    }
}
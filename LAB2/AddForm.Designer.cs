namespace LAB2
{
    partial class AddForm
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
            this.lb_code = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.lb_des = new System.Windows.Forms.Label();
            this.rtb_des = new System.Windows.Forms.RichTextBox();
            this.lb_sub = new System.Windows.Forms.Label();
            this.cbx_sub = new System.Windows.Forms.ComboBox();
            this.lb_ins = new System.Windows.Forms.Label();
            this.cbx_ins = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbx_students = new System.Windows.Forms.ListBox();
            this.lb_stu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.Location = new System.Drawing.Point(14, 10);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(52, 20);
            this.lb_code.TabIndex = 0;
            this.lb_code.Text = "Code: ";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(175, 7);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(260, 28);
            this.tb_code.TabIndex = 1;
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.Location = new System.Drawing.Point(14, 80);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(94, 20);
            this.lb_des.TabIndex = 2;
            this.lb_des.Text = "Description: ";
            // 
            // rtb_des
            // 
            this.rtb_des.Location = new System.Drawing.Point(175, 77);
            this.rtb_des.Name = "rtb_des";
            this.rtb_des.Size = new System.Drawing.Size(260, 110);
            this.rtb_des.TabIndex = 3;
            this.rtb_des.Text = "";
            // 
            // lb_sub
            // 
            this.lb_sub.AutoSize = true;
            this.lb_sub.Location = new System.Drawing.Point(14, 223);
            this.lb_sub.Name = "lb_sub";
            this.lb_sub.Size = new System.Drawing.Size(67, 20);
            this.lb_sub.TabIndex = 4;
            this.lb_sub.Text = "Subject: ";
            // 
            // cbx_sub
            // 
            this.cbx_sub.FormattingEnabled = true;
            this.cbx_sub.Location = new System.Drawing.Point(175, 220);
            this.cbx_sub.Name = "cbx_sub";
            this.cbx_sub.Size = new System.Drawing.Size(260, 28);
            this.cbx_sub.TabIndex = 5;
            // 
            // lb_ins
            // 
            this.lb_ins.AutoSize = true;
            this.lb_ins.Location = new System.Drawing.Point(14, 309);
            this.lb_ins.Name = "lb_ins";
            this.lb_ins.Size = new System.Drawing.Size(82, 20);
            this.lb_ins.TabIndex = 6;
            this.lb_ins.Text = "Instructor: ";
            // 
            // cbx_ins
            // 
            this.cbx_ins.FormattingEnabled = true;
            this.cbx_ins.Location = new System.Drawing.Point(175, 300);
            this.cbx_ins.Name = "cbx_ins";
            this.cbx_ins.Size = new System.Drawing.Size(260, 28);
            this.cbx_ins.TabIndex = 7;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(175, 567);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(86, 28);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Save";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbx_students
            // 
            this.lbx_students.FormattingEnabled = true;
            this.lbx_students.ItemHeight = 20;
            this.lbx_students.Location = new System.Drawing.Point(175, 353);
            this.lbx_students.Name = "lbx_students";
            this.lbx_students.Size = new System.Drawing.Size(260, 204);
            this.lbx_students.TabIndex = 9;
            this.lbx_students.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbx_students_Format);
            // 
            // lb_stu
            // 
            this.lb_stu.AutoSize = true;
            this.lb_stu.Location = new System.Drawing.Point(14, 353);
            this.lb_stu.Name = "lb_stu";
            this.lb_stu.Size = new System.Drawing.Size(72, 20);
            this.lb_stu.TabIndex = 10;
            this.lb_stu.Text = "Students:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 608);
            this.Controls.Add(this.lb_stu);
            this.Controls.Add(this.lbx_students);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cbx_ins);
            this.Controls.Add(this.lb_ins);
            this.Controls.Add(this.cbx_sub);
            this.Controls.Add(this.lb_sub);
            this.Controls.Add(this.rtb_des);
            this.Controls.Add(this.lb_des);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.lb_code);
            this.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddForm";
            this.Text = "Create new course";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_code;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.RichTextBox rtb_des;
        private System.Windows.Forms.Label lb_sub;
        private System.Windows.Forms.ComboBox cbx_sub;
        private System.Windows.Forms.Label lb_ins;
        private System.Windows.Forms.ComboBox cbx_ins;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ListBox lbx_students;
        private System.Windows.Forms.Label lb_stu;
    }
}


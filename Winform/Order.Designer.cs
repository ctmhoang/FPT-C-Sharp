namespace Winform
{
    partial class Order
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
            this.lb_Customer = new System.Windows.Forms.Label();
            this.cb_customer = new System.Windows.Forms.ComboBox();
            this.cb_emp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_delComp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbx_Products = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Customer
            // 
            this.lb_Customer.AutoSize = true;
            this.lb_Customer.Location = new System.Drawing.Point(17, 17);
            this.lb_Customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Customer.Name = "lb_Customer";
            this.lb_Customer.Size = new System.Drawing.Size(79, 20);
            this.lb_Customer.TabIndex = 0;
            this.lb_Customer.Text = "Customer:";
            // 
            // cb_customer
            // 
            this.cb_customer.FormattingEnabled = true;
            this.cb_customer.Location = new System.Drawing.Point(172, 13);
            this.cb_customer.Margin = new System.Windows.Forms.Padding(4);
            this.cb_customer.Name = "cb_customer";
            this.cb_customer.Size = new System.Drawing.Size(255, 28);
            this.cb_customer.TabIndex = 1;
            // 
            // cb_emp
            // 
            this.cb_emp.FormattingEnabled = true;
            this.cb_emp.Location = new System.Drawing.Point(172, 71);
            this.cb_emp.Margin = new System.Windows.Forms.Padding(4);
            this.cb_emp.Name = "cb_emp";
            this.cb_emp.Size = new System.Drawing.Size(255, 28);
            this.cb_emp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Required Date:";
            // 
            // cb_delComp
            // 
            this.cb_delComp.FormattingEnabled = true;
            this.cb_delComp.Location = new System.Drawing.Point(172, 184);
            this.cb_delComp.Margin = new System.Windows.Forms.Padding(4);
            this.cb_delComp.Name = "cb_delComp";
            this.cb_delComp.Size = new System.Drawing.Size(255, 28);
            this.cb_delComp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delivery Company:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 124);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 28);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lbx_Products
            // 
            this.lbx_Products.FormattingEnabled = true;
            this.lbx_Products.ItemHeight = 20;
            this.lbx_Products.Location = new System.Drawing.Point(172, 243);
            this.lbx_Products.Margin = new System.Windows.Forms.Padding(4);
            this.lbx_Products.Name = "lbx_Products";
            this.lbx_Products.Size = new System.Drawing.Size(255, 324);
            this.lbx_Products.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(17, 243);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(147, 144);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add Product To Order";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(16, 395);
            this.btn_create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(147, 157);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "Create Order";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.ForeColor = System.Drawing.Color.OliveDrab;
            this.lb_result.Location = new System.Drawing.Point(21, 556);
            this.lb_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(61, 20);
            this.lb_result.TabIndex = 12;
            this.lb_result.Text = "             ";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(444, 592);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbx_Products);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cb_delComp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_emp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_customer);
            this.Controls.Add(this.lb_Customer);
            this.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Order";
            this.Text = "Create Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Customer;
        private System.Windows.Forms.ComboBox cb_customer;
        private System.Windows.Forms.ComboBox cb_emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_delComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lbx_Products;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Button btn_add;
    }
}
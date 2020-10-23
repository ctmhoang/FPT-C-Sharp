namespace Winform.Display
{
    partial class Edit
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
            this.lb_id = new System.Windows.Forms.Label();
            this.txb_Id = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.nup_price = new System.Windows.Forms.NumericUpDown();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nup_price)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Roboto Condensed Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(12, 10);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(71, 17);
            this.lb_id.TabIndex = 0;
            this.lb_id.Text = "Product ID: ";
            // 
            // txb_Id
            // 
            this.txb_Id.Location = new System.Drawing.Point(107, 7);
            this.txb_Id.Name = "txb_Id";
            this.txb_Id.Size = new System.Drawing.Size(198, 23);
            this.txb_Id.TabIndex = 1;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(107, 54);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(198, 23);
            this.txb_Name.TabIndex = 3;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Roboto Condensed Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(12, 57);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(93, 17);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Product Name: ";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Roboto Condensed Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(12, 106);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(63, 17);
            this.lb_price.TabIndex = 4;
            this.lb_price.Text = "Unit Price:";
            // 
            // nup_price
            // 
            this.nup_price.Location = new System.Drawing.Point(107, 104);
            this.nup_price.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nup_price.Name = "nup_price";
            this.nup_price.Size = new System.Drawing.Size(120, 23);
            this.nup_price.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(107, 186);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 262);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.nup_price);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.txb_Id);
            this.Controls.Add(this.lb_id);
            this.Font = new System.Drawing.Font("Roboto Condensed", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Edit";
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.nup_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox txb_Id;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.NumericUpDown nup_price;
        private System.Windows.Forms.Button btn_save;
    }
}
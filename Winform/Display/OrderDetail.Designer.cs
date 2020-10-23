namespace Winform.Display
{
    partial class OrderDetail
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgw_orderDetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.lb_totPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orderDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgw_orderDetails
            // 
            this.dgw_orderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_orderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_orderDetails.Location = new System.Drawing.Point(0, 0);
            this.dgw_orderDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgw_orderDetails.Name = "dgw_orderDetails";
            this.dgw_orderDetails.RowHeadersWidth = 51;
            this.dgw_orderDetails.RowTemplate.Height = 24;
            this.dgw_orderDetails.Size = new System.Drawing.Size(800, 562);
            this.dgw_orderDetails.TabIndex = 3;
            this.dgw_orderDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_orderDetails_CellEndEdit);
            this.dgw_orderDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgw_orderDetails_DataError);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.lb_totPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 38);
            this.panel1.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(722, 4);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 30);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lb_totPrice
            // 
            this.lb_totPrice.AutoSize = true;
            this.lb_totPrice.Location = new System.Drawing.Point(3, 10);
            this.lb_totPrice.Name = "lb_totPrice";
            this.lb_totPrice.Size = new System.Drawing.Size(105, 20);
            this.lb_totPrice.TabIndex = 0;
            this.lb_totPrice.Text = "Total Price: 0$";
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgw_orderDetails);
            this.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderDetail";
            this.Text = "OrderDetail";
            this.Load += new System.EventHandler(this.OrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_orderDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgw_orderDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_totPrice;
        private System.Windows.Forms.Button btn_save;
    }
}
namespace LAB2
{
    partial class InfoForm
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
            this.dgw_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_data)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_data
            // 
            this.dgw_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_data.Location = new System.Drawing.Point(0, 0);
            this.dgw_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgw_data.Name = "dgw_data";
            this.dgw_data.RowHeadersWidth = 51;
            this.dgw_data.RowTemplate.Height = 24;
            this.dgw_data.Size = new System.Drawing.Size(805, 618);
            this.dgw_data.TabIndex = 0;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 618);
            this.Controls.Add(this.dgw_data);
            this.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InfoForm";
            this.Text = "Students Attend In ";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_data;
    }
}
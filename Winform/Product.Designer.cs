namespace Winform
{
    partial class MainForm
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
            this.cbx_table = new System.Windows.Forms.ComboBox();
            this.dgw_displayData = new System.Windows.Forms.DataGridView();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_displayData)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_table
            // 
            this.cbx_table.FormattingEnabled = true;
            this.cbx_table.Location = new System.Drawing.Point(12, 21);
            this.cbx_table.Name = "cbx_table";
            this.cbx_table.Size = new System.Drawing.Size(121, 26);
            this.cbx_table.TabIndex = 0;
            this.cbx_table.SelectedIndexChanged += new System.EventHandler(this.cbx_table_SelectedIndexChanged);
            // 
            // dgw_displayData
            // 
            this.dgw_displayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_displayData.Location = new System.Drawing.Point(13, 63);
            this.dgw_displayData.Name = "dgw_displayData";
            this.dgw_displayData.RowHeadersWidth = 51;
            this.dgw_displayData.RowTemplate.Height = 24;
            this.dgw_displayData.Size = new System.Drawing.Size(675, 353);
            this.dgw_displayData.TabIndex = 1;
            this.dgw_displayData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_displayData_CellContentClick);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(565, 21);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(122, 23);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "Add New Product";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(475, 21);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(700, 428);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dgw_displayData);
            this.Controls.Add(this.cbx_table);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Blah Blah Program";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_displayData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_table;
        private System.Windows.Forms.DataGridView dgw_displayData;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_del;
    }
}


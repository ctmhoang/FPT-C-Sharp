
namespace LAB2
{
    partial class AddStudentForm
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
            this.lb_Name = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_Id = new System.Windows.Forms.TextBox();
            this.lb_rollId = new System.Windows.Forms.Label();
            this.sc_main = new System.Windows.Forms.SplitContainer();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgw_display = new System.Windows.Forms.DataGridView();
            this.sc_main.Panel1.SuspendLayout();
            this.sc_main.Panel2.SuspendLayout();
            this.sc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_display)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(12, 13);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(53, 20);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "Name:";
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(71, 10);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(260, 28);
            this.txb_name.TabIndex = 1;
            // 
            // txb_Id
            // 
            this.txb_Id.Location = new System.Drawing.Point(71, 64);
            this.txb_Id.Name = "txb_Id";
            this.txb_Id.Size = new System.Drawing.Size(260, 28);
            this.txb_Id.TabIndex = 3;
            // 
            // lb_rollId
            // 
            this.lb_rollId.AutoSize = true;
            this.lb_rollId.Location = new System.Drawing.Point(12, 67);
            this.lb_rollId.Name = "lb_rollId";
            this.lb_rollId.Size = new System.Drawing.Size(57, 20);
            this.lb_rollId.TabIndex = 2;
            this.lb_rollId.Text = "Roll ID:";
            // 
            // sc_main
            // 
            this.sc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_main.Location = new System.Drawing.Point(0, 0);
            this.sc_main.Name = "sc_main";
            this.sc_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_main.Panel1
            // 
            this.sc_main.Panel1.Controls.Add(this.btn_add);
            this.sc_main.Panel1.Controls.Add(this.btn_search);
            this.sc_main.Panel1.Controls.Add(this.txb_Id);
            this.sc_main.Panel1.Controls.Add(this.lb_Name);
            this.sc_main.Panel1.Controls.Add(this.lb_rollId);
            this.sc_main.Panel1.Controls.Add(this.txb_name);
            // 
            // sc_main.Panel2
            // 
            this.sc_main.Panel2.Controls.Add(this.dgw_display);
            this.sc_main.Size = new System.Drawing.Size(343, 562);
            this.sc_main.SplitterDistance = 156;
            this.sc_main.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(16, 113);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 31);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(256, 113);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 31);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgw_display
            // 
            this.dgw_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_display.Location = new System.Drawing.Point(0, 0);
            this.dgw_display.Name = "dgw_display";
            this.dgw_display.RowHeadersWidth = 51;
            this.dgw_display.RowTemplate.Height = 24;
            this.dgw_display.Size = new System.Drawing.Size(343, 402);
            this.dgw_display.TabIndex = 0;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 562);
            this.Controls.Add(this.sc_main);
            this.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddStudentForm";
            this.Text = "Add Student In ";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            this.sc_main.Panel1.ResumeLayout(false);
            this.sc_main.Panel1.PerformLayout();
            this.sc_main.Panel2.ResumeLayout(false);
            this.sc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_Id;
        private System.Windows.Forms.Label lb_rollId;
        private System.Windows.Forms.SplitContainer sc_main;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgw_display;
    }
}
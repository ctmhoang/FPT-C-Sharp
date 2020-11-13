
namespace LAB2
{
    partial class UpdateForm
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
            this.sc_main = new System.Windows.Forms.SplitContainer();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.dgw_display = new System.Windows.Forms.DataGridView();
            this.lb_tot = new System.Windows.Forms.Label();
            this.sc_main.Panel1.SuspendLayout();
            this.sc_main.Panel2.SuspendLayout();
            this.sc_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_display)).BeginInit();
            this.SuspendLayout();
            // 
            // sc_main
            // 
            this.sc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_main.Font = new System.Drawing.Font("Roboto Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sc_main.Location = new System.Drawing.Point(0, 0);
            this.sc_main.Name = "sc_main";
            // 
            // sc_main.Panel1
            // 
            this.sc_main.Panel1.Controls.Add(this.lb_tot);
            this.sc_main.Panel1.Controls.Add(this.btn_add);
            this.sc_main.Panel1.Controls.Add(this.btn_del);
            // 
            // sc_main.Panel2
            // 
            this.sc_main.Panel2.Controls.Add(this.dgw_display);
            this.sc_main.Size = new System.Drawing.Size(800, 450);
            this.sc_main.SplitterDistance = 141;
            this.sc_main.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1, 218);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(137, 200);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(0, 0);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(138, 212);
            this.btn_del.TabIndex = 0;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // dgw_display
            // 
            this.dgw_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_display.Location = new System.Drawing.Point(0, 0);
            this.dgw_display.Name = "dgw_display";
            this.dgw_display.RowHeadersWidth = 51;
            this.dgw_display.RowTemplate.Height = 24;
            this.dgw_display.Size = new System.Drawing.Size(655, 450);
            this.dgw_display.TabIndex = 0;
            // 
            // lb_tot
            // 
            this.lb_tot.AutoSize = true;
            this.lb_tot.ForeColor = System.Drawing.Color.DarkOrange;
            this.lb_tot.Location = new System.Drawing.Point(3, 421);
            this.lb_tot.Name = "lb_tot";
            this.lb_tot.Size = new System.Drawing.Size(51, 20);
            this.lb_tot.TabIndex = 2;
            this.lb_tot.Text = "Total: ";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sc_main);
            this.Name = "UpdateForm";
            this.Text = "Update Course";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.sc_main.Panel1.ResumeLayout(false);
            this.sc_main.Panel1.PerformLayout();
            this.sc_main.Panel2.ResumeLayout(false);
            this.sc_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_display)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_main;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridView dgw_display;
        private System.Windows.Forms.Label lb_tot;
    }
}
namespace Blah_Buttons
{
    partial class Form1
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
            this.lb_stId = new System.Windows.Forms.Label();
            this.txb_stId = new System.Windows.Forms.TextBox();
            this.btn_stdId = new System.Windows.Forms.Button();
            this.lele = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_activeColor = new System.Windows.Forms.Button();
            this.lb_display_color = new System.Windows.Forms.Label();
            this.txb_button = new System.Windows.Forms.TextBox();
            this.lb_colorButton = new System.Windows.Forms.Label();
            this.lb_button = new System.Windows.Forms.Label();
            this.ctn_button_display = new System.Windows.Forms.FlowLayoutPanel();
            this.lele.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_stId
            // 
            this.lb_stId.AutoSize = true;
            this.lb_stId.Location = new System.Drawing.Point(13, 13);
            this.lb_stId.Name = "lb_stId";
            this.lb_stId.Size = new System.Drawing.Size(78, 17);
            this.lb_stId.TabIndex = 0;
            this.lb_stId.Text = "StudentID: ";
            // 
            // txb_stId
            // 
            this.txb_stId.Location = new System.Drawing.Point(98, 13);
            this.txb_stId.Name = "txb_stId";
            this.txb_stId.ReadOnly = true;
            this.txb_stId.Size = new System.Drawing.Size(177, 22);
            this.txb_stId.TabIndex = 1;
            // 
            // btn_stdId
            // 
            this.btn_stdId.Location = new System.Drawing.Point(281, 12);
            this.btn_stdId.Name = "btn_stdId";
            this.btn_stdId.Size = new System.Drawing.Size(80, 23);
            this.btn_stdId.TabIndex = 2;
            this.btn_stdId.Text = "Generate";
            this.btn_stdId.UseVisualStyleBackColor = true;
            this.btn_stdId.Click += new System.EventHandler(this.btn_stdId_Click);
            // 
            // lele
            // 
            this.lele.Controls.Add(this.btn_add);
            this.lele.Controls.Add(this.btn_activeColor);
            this.lele.Controls.Add(this.lb_display_color);
            this.lele.Controls.Add(this.txb_button);
            this.lele.Controls.Add(this.lb_colorButton);
            this.lele.Controls.Add(this.lb_button);
            this.lele.Location = new System.Drawing.Point(16, 54);
            this.lele.Name = "lele";
            this.lele.Size = new System.Drawing.Size(345, 163);
            this.lele.TabIndex = 3;
            this.lele.TabStop = false;
            this.lele.Text = "New Button";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(263, 134);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_activeColor
            // 
            this.btn_activeColor.Location = new System.Drawing.Point(126, 48);
            this.btn_activeColor.Name = "btn_activeColor";
            this.btn_activeColor.Size = new System.Drawing.Size(75, 23);
            this.btn_activeColor.TabIndex = 8;
            this.btn_activeColor.Text = "Choose";
            this.btn_activeColor.UseVisualStyleBackColor = true;
            this.btn_activeColor.Click += new System.EventHandler(this.btn_activeColor_Click);
            // 
            // lb_display_color
            // 
            this.lb_display_color.AutoSize = true;
            this.lb_display_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lb_display_color.ForeColor = System.Drawing.Color.Goldenrod;
            this.lb_display_color.Location = new System.Drawing.Point(64, 50);
            this.lb_display_color.MinimumSize = new System.Drawing.Size(40, 7);
            this.lb_display_color.Name = "lb_display_color";
            this.lb_display_color.Size = new System.Drawing.Size(40, 17);
            this.lb_display_color.TabIndex = 7;
            this.lb_display_color.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txb_button
            // 
            this.txb_button.Location = new System.Drawing.Point(64, 18);
            this.txb_button.Name = "txb_button";
            this.txb_button.Size = new System.Drawing.Size(275, 22);
            this.txb_button.TabIndex = 6;
            // 
            // lb_colorButton
            // 
            this.lb_colorButton.AutoSize = true;
            this.lb_colorButton.Location = new System.Drawing.Point(6, 51);
            this.lb_colorButton.Name = "lb_colorButton";
            this.lb_colorButton.Size = new System.Drawing.Size(49, 17);
            this.lb_colorButton.TabIndex = 5;
            this.lb_colorButton.Text = "Color: ";
            // 
            // lb_button
            // 
            this.lb_button.AutoSize = true;
            this.lb_button.Location = new System.Drawing.Point(6, 23);
            this.lb_button.Name = "lb_button";
            this.lb_button.Size = new System.Drawing.Size(51, 17);
            this.lb_button.TabIndex = 4;
            this.lb_button.Text = "Label: ";
            // 
            // ctn_button_display
            // 
            this.ctn_button_display.AutoScroll = true;
            this.ctn_button_display.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ctn_button_display.Location = new System.Drawing.Point(13, 224);
            this.ctn_button_display.Name = "ctn_button_display";
            this.ctn_button_display.Size = new System.Drawing.Size(348, 318);
            this.ctn_button_display.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 554);
            this.Controls.Add(this.ctn_button_display);
            this.Controls.Add(this.lele);
            this.Controls.Add(this.btn_stdId);
            this.Controls.Add(this.txb_stId);
            this.Controls.Add(this.lb_stId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.lele.ResumeLayout(false);
            this.lele.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_stId;
        private System.Windows.Forms.TextBox txb_stId;
        private System.Windows.Forms.Button btn_stdId;
        private System.Windows.Forms.GroupBox lele;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_activeColor;
        private System.Windows.Forms.Label lb_display_color;
        private System.Windows.Forms.TextBox txb_button;
        private System.Windows.Forms.Label lb_colorButton;
        private System.Windows.Forms.Label lb_button;
        private System.Windows.Forms.FlowLayoutPanel ctn_button_display;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blah_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_stdId_Click(object sender, EventArgs e)
        {
            txb_stId.Text = "Blah blah blah blah";
        }

        private void btn_activeColor_Click(object sender, EventArgs e)
        {
            var colorChooser = new ColorDialog
                {AllowFullOpen = false, ShowHelp = true, Color = lb_display_color.BackColor};

            if (colorChooser.ShowDialog() == DialogResult.OK)
                lb_display_color.BackColor = colorChooser.Color;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txb_button.Text))
            {
                Button btn = new Button {Text = txb_button.Text, BackColor = lb_display_color.BackColor};
                btn.Click += addButton;
                ctn_button_display.Controls.Add(btn);
            }
        }

        private void addButton(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                MessageBox.Show($@"Label: {btn.Text} 
 Color:{btn.BackColor}");
            }
        }
    }
}
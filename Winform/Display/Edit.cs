using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Winform.Business;

namespace Winform.Display
{
    public partial class Edit : Form
    {
        public Edit(Product product)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txb_Id.ReadOnly = true;
            if (string.IsNullOrEmpty(product.Name))
            {
                lb_id.Text = @"Category ID:";
                txb_Id.Text = Category.FetchAll().Single(c => c.Id == product.Cid).Name;
                btn_save.Click += (sender, args) =>
                {
                    Product.Insert(product.Cid, txb_Name.Text, nup_price.Value);
                    MessageBox.Show(@"Add Successful", @"Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                };
            }
            else
            {
                txb_Id.Text = product.Pid.ToString();
                txb_Name.Text = product.Name;
                nup_price.Value = product.Price;
                btn_save.Click += (sender, args) =>
                {
                    Product.Edit(product.Pid, txb_Name.Text, nup_price.Value);
                    MessageBox.Show(@"Edit Successful", @"Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                };
            }
        }
    }
}
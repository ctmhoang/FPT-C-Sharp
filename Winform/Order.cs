using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Winform.Business;
using Winform.Display;

namespace Winform
{
    public partial class Order : Form
    {
        private Dictionary<Product, uint> _curOrderDetails;

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            _curOrderDetails = new Dictionary<Product, uint>(20);

            cb_customer.DataSource = Customer.FetchAll();
            cb_customer.DisplayMember = "Name";
            cb_customer.ValueMember = "Id";

            cb_emp.DataSource = Employee.FetchAll();
            cb_emp.DisplayMember = "FullName";
            cb_emp.ValueMember = "Id";

            cb_delComp.DataSource = DeliveryCompany.FetchAll();
            cb_delComp.DisplayMember = "Name";
            cb_delComp.ValueMember = "Id";

            lbx_Products.Sorted = true;
            lbx_Products.SelectionMode = SelectionMode.One;
            lbx_Products.DataSource = Product.FetchAll();
            lbx_Products.DisplayMember = "Name";
            lbx_Products.ValueMember = "Pid";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var selectedItem = (Product) lbx_Products.SelectedItem;
            if (!_curOrderDetails.ContainsKey(selectedItem))
                _curOrderDetails.Add(selectedItem, 1);
            var orderDetailsForm = new OrderDetail(ref _curOrderDetails);
            orderDetailsForm.Closed += (o, args) =>
            {
                _curOrderDetails = _curOrderDetails.Where(entry => entry.Value != 0).ToDictionary(entry => entry.Key, entry => entry.Value);
                this.Enabled = true;
                lb_result.Text = _curOrderDetails.Count > 0 ? $@"Current Order has {_curOrderDetails.Keys.Count} unique items and total quantity is {_curOrderDetails.Values.Aggregate((a,b) => a + b)}" : @"No item was added";
            };
            this.Enabled = false;
            orderDetailsForm.Show();
        }
    }
}
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
    public partial class OrderDetail : Form
    {
        internal class Entry
        {
            public Entry(Product product, string name, decimal price, uint quantity)
            {
                Product = product;
                Name = name ?? throw new ArgumentNullException(nameof(name));
                Price = price;
                Quantity = quantity;
            }

            public Product Product { get; }
            public string Name { get; }
            public decimal Price { get; set; }
            public uint Quantity { get; set; }
        }

        public Dictionary<Product, uint> CurOrder { get; }

        private List<Entry> DisplaySource { get; }
        public decimal TotCost { get; set; }

        public OrderDetail(ref Dictionary<Product, uint> currentOrder)
        {
            CurOrder = currentOrder;
            DisplaySource = currentOrder.Select(entry =>
                new Entry(entry.Key, entry.Key.Name, entry.Key.Price * entry.Value, entry.Value)).ToList();
            InitializeComponent();
            UpdateTotalPrice();
        }

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            dgw_orderDetails.AutoGenerateColumns = false;
            dgw_orderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_orderDetails.DataSource = DisplaySource;

            var nameColumn = new DataGridViewTextBoxColumn()
            {
                Name = "name",
                HeaderText = @"Product Name",
                DataPropertyName = "Name",
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                ReadOnly = true
            };

            var priceColumn = new DataGridViewTextBoxColumn()
            {
                Name = "price",
                HeaderText = @"Price",
                DataPropertyName = "Price",
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                ReadOnly = true,
            };
            var quantityColumn = new DataGridViewTextBoxColumn()
            {
                Name = "quantity",
                HeaderText = @"Quantity",
                DataPropertyName = "Quantity",
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgw_orderDetails.Columns.AddRange(nameColumn, priceColumn, quantityColumn);
        }


        private void UpdateTotalPrice()
        {
            TotCost = DisplaySource.Select(entry => entry.Price).Sum();
            lb_totPrice.Text = $@"Total Price: {TotCost}$";
        }


        private void dgw_orderDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex > 0 || e.ColumnIndex > 0) && dgw_orderDetails.Columns[e.ColumnIndex].Name == "quantity")
            {
                var entry = DisplaySource[e.RowIndex];
                var quantity = uint.Parse(dgw_orderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                entry.Price = quantity * entry.Product.Price;

                entry.Quantity = quantity;
                CurOrder[entry.Product] = quantity;

                UpdateTotalPrice();
                dgw_orderDetails.Refresh();
            }
        }

        private void dgw_orderDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgw_orderDetails.CancelEdit();
            MessageBox.Show(@"Must be 0 or positive numeric value", @"Invalid input data", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
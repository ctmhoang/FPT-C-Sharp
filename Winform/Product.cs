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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dgw_displayData.AutoGenerateColumns = false;
            var nameColumn = new DataGridViewTextBoxColumn()
            {
                HeaderText = @"Product Name",
                Name = "name",
                DataPropertyName = "Name",
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            var priceColumn = new DataGridViewTextBoxColumn()
            {
                Name = "price",
                HeaderText = @"Unit Price",
                DataPropertyName = "Price",
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };

            var editColumn = new DataGridViewButtonColumn()
            {
                Name = "edit",
                HeaderText = "Action",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };

            dgw_displayData.Columns.AddRange(nameColumn, priceColumn, editColumn);
            dgw_displayData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cbx_table.DisplayMember = "Name";
            cbx_table.ValueMember = "Id";
            cbx_table.DataSource = Category.FetchAll();

            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
        }

        private void LoadData()
        {
            int categoryId = int.Parse(cbx_table.SelectedValue.ToString());
            dgw_displayData.DataSource = Product.FetchAllByCategoryId(categoryId);
        }

        private void cbx_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgw_displayData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            if (dgw_displayData.Columns[e.ColumnIndex].Name == "edit")
            {
                var products = (List<Product>) dgw_displayData.DataSource;
                Product p = products[e.RowIndex];
                var form = new Edit(p);
                this.Enabled = false;
                form.FormClosed += cbx_table_SelectedIndexChanged;
                form.FormClosed += (o, arg) => this.Enabled = true;
                form.Show();
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            var categoryId = int.Parse(cbx_table.SelectedValue.ToString());
            var p = new Product(categoryId);
            var form = new Edit(p);
            this.Enabled = false;
            form.FormClosed += cbx_table_SelectedIndexChanged;
            form.FormClosed += (o, arg) => this.Enabled = true;
            form.Show();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dgw_displayData.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"Do not have any entry", @"Notify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var curList = (List<Product>) dgw_displayData.DataSource;
                Product.DeleteRange(dgw_displayData.SelectedRows.Cast<DataGridViewRow>().Select(row => curList[row.Index].Pid).ToList());
                LoadData();
            }
        }
    }
}
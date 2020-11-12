using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LAB2.Bean;

namespace LAB2
{
    public partial class ShowForm : Form
    {
        private List<Course> _data;
        private readonly DataGridViewCellStyle _cellStyle;

        public ShowForm()
        {
            InitializeComponent();
            _data = Course.FetchAll();
            _cellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {
            spc_main.IsSplitterFixed = true;

            dgw_courses.AutoGenerateColumns = false;
            dgw_courses.DataSource = _data;
            dgw_courses.MultiSelect = false;
            dgw_courses.ReadOnly = true;
            dgw_courses.AllowUserToResizeColumns = false;
            dgw_courses.AllowUserToResizeRows = false;

            lb_tot.Text = $@"Total: {_data.Count()} Courses";

            var code = new DataGridViewTextBoxColumn
            {
                Name = "code",
                HeaderText = @"CODE",
                DataPropertyName = "Code",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = _cellStyle,
                HeaderCell = {Style = _cellStyle}
            };

            var desc = new DataGridViewTextBoxColumn
            {
                Name = "desc",
                HeaderText = @"Description",
                DataPropertyName = "Description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = _cellStyle,
                HeaderCell = {Style = _cellStyle}
            };

            var sub = new DataGridViewTextBoxColumn
            {
                Name = "sub",
                HeaderText = @"Subject",
                DataPropertyName = "Sub",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = _cellStyle,
                HeaderCell = {Style = _cellStyle}
            };

            var ins = new DataGridViewTextBoxColumn
            {
                Name = "ins",
                HeaderText = @"Instructor",
                DataPropertyName = "Ins",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = _cellStyle,
                HeaderCell = {Style = _cellStyle}
            };

            dgw_courses.Columns.AddRange(code, desc, sub, ins);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            Enabled = false;
            addForm.Closed += (o, args) =>
            {
                Course.Update();
                _data = Course.FetchAll();
                Enabled = true;
                lb_tot.Text = $@"Total: {_data.Count()} Courses";
                dgw_courses.DataSource = _data;
            };
            addForm.Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            string status = null;
            if (dgw_courses.SelectedRows.Count > 0) status = "ROW";
            else if (dgw_courses.SelectedCells.Count > 0) status = "CELL";
            InfoForm infoForm = null;
            switch (status)
            {
                case "ROW":
                    infoForm = new InfoForm((Course) dgw_courses.SelectedRows[0].DataBoundItem);
                    break;
                case "CELL":
                    infoForm = new InfoForm(_data[dgw_courses.SelectedCells[0].RowIndex]);
                    break;
            }

            if (infoForm != null)
            {
                Enabled = false;

                infoForm.Closed += (o, args) =>
                    Enabled = true;
                infoForm.Show();
            }
            else
                MessageBox.Show(@"Do not select any entry", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string status = null;
            if (dgw_courses.SelectedRows.Count > 0) status = "ROW";
            else if (dgw_courses.SelectedCells.Count > 0) status = "CELL";
            Course course = null;
            switch (status)
            {
                case "ROW":
                    course = (Course)dgw_courses.SelectedRows[0].DataBoundItem);
                    break;
                case "CELL":
                    course = _data[dgw_courses.SelectedCells[0].RowIndex];
                    break;
            }

            Course.Delete(course);
        }
    }
}
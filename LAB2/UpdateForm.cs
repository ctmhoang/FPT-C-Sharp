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
    public partial class UpdateForm : Form
    {
        private readonly int _courseId;

        public UpdateForm(int courseId)
        {
            InitializeComponent();
            _courseId = courseId;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            sc_main.IsSplitterFixed = true;

            dgw_display.AutoGenerateColumns = false;
            dgw_display.MultiSelect = false;
            dgw_display.AllowUserToResizeColumns = false;
            dgw_display.AllowUserToResizeRows = false;

            var roll = new DataGridViewTextBoxColumn()
            {
                Name = "roll",
                HeaderText = @"Roll ID",
                DataPropertyName = "RollId",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };
            var name = new DataGridViewTextBoxColumn()
            {
                Name = "name",
                HeaderText = @"Name",
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            };

            var selected = new DataGridViewCheckBoxColumn()
            {
                Name = "selected",
                HeaderText = @"Select",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Selected = false
            };

            dgw_display.Columns.AddRange(roll, name, selected);
            Bind();
        }

        private void Bind()
        {
            var stuList = Student.GetAllStudentIdsBy(_courseId).Select(Student.Get).ToList();
            dgw_display.DataSource = stuList;
            lb_tot.Text = $@"Total: {stuList.Count} students";
            dgw_display.Update();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            var selectedIdsList = dgw_display.Rows.Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["selected"].Value)).Select(row => row.DataBoundItem).Cast<Student>()
                .Select(stu => stu.Id).ToList();
            if (!selectedIdsList.Any()) MessageBox.Show(@"Do not select any entry", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Student.LeaveRange(selectedIdsList, _courseId);
                Bind();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var addForm = new AddStudentForm(Student.GetAllStudentIdsBy(_courseId).Select(Student.Get).ToList(), _courseId);
            Enabled = false;
            addForm.Closed += (o, args) =>
            {
                Enabled = true;
                Bind();
            };
            addForm.Show();
        }
    }
}
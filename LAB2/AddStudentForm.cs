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
    public partial class AddStudentForm : Form
    {
       private class StudentWrapper
       {
           public Student Student { get; set; }
           public bool Selected { get; set; }
           public string Name => Student.Name;
           public string RollId => Student.RollId;
       }

       private readonly List<StudentWrapper> _displayData;
       private int _courseId;

       public AddStudentForm(IEnumerable<Student> curList, int courseId)
        {
            InitializeComponent();
            _courseId = courseId;
            _displayData = Student.FetchAll().AsQueryable().Except(curList).Select(stu => new StudentWrapper(){Selected = false, Student = stu}).ToList();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
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
                DataPropertyName = "Selected"
            };

            dgw_display.Columns.AddRange(roll, name, selected);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            var showList = new List<StudentWrapper>(10);
            if (!string.IsNullOrEmpty(txb_name.Text.Trim()))
                showList.AddRange(_displayData.Where(studentWrapper =>
                    studentWrapper.Name.ToLower().Contains(txb_name.Text.ToLower().Trim())));
            if (!string.IsNullOrEmpty(txb_Id.Text.Trim()))
                showList.AddRange(_displayData.Where(studentWrapper =>
                    studentWrapper.RollId.ToLower().Contains(txb_Id.Text.ToLower().Trim())));
            if (!showList.Any())
                showList = _displayData;
            dgw_display.DataSource = showList;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var selectedIdsList = dgw_display.Rows.Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["selected"].Value)).Select(row => row.DataBoundItem).Cast<StudentWrapper>()
                .Select(stu => stu.Student.Id).ToList();
            if (!selectedIdsList.Any()) MessageBox.Show(@"Do not select any entry", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Course.RegisterStudentIn(_courseId, _displayData.Where(wrapper => wrapper.Selected).Select(wrapper => wrapper.Student).ToList());
                Close();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LAB2.Bean;
using LAB2.Dao.impl;

namespace LAB2
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            cbx_ins.DataSource = Instructor.FetchAll();
            cbx_ins.DisplayMember = "Name";
            cbx_ins.ValueMember = "Id";

            cbx_sub.DataSource = Subject.FetchAll();
            cbx_sub.DisplayMember = "Name";
            cbx_sub.ValueMember = "Id";

            lbx_students.SelectionMode = SelectionMode.MultiExtended;
            lbx_students.Sorted = true;
            lbx_students.DataSource = Student.FetchAll();
            lbx_students.DisplayMember = "RollId";
            lbx_students.ValueMember = "Id";
        }

        private void lbx_students_Format(object sender, ListControlConvertEventArgs e)
        {
            var foo = (Student)e.ListItem;
            e.Value = $"{foo.RollId} - {foo.Name}";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_code.Text) || string.IsNullOrEmpty(rtb_des.Text))
            {
                MessageBox.Show(@"Please enter all field in this form", @"Missing values", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            else
            {
                int id = Course.Insert(tb_code.Text, rtb_des.Text, Convert.ToInt32(cbx_sub.SelectedValue),
                    Convert.ToInt32(cbx_ins.SelectedValue));
                Course.RegisterStudentIn(id, lbx_students.SelectedItems.Cast<Student>());
                MessageBox.Show(@"Update successful",@"Success", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                Close();
            }

        }
    }
}

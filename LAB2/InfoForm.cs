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
    public partial class InfoForm : Form
    {
        private Course Ctx { get; set; }
        public InfoForm(Course course)
        {
            InitializeComponent();
            Ctx = course;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            Text += Ctx.Code;
            dgw_data.AutoGenerateColumns = false;
            var data = Student.GetAllStudentIdsBy(Ctx.Id).Select(Student.Get).ToList();
            if (!data.Any())
            {
                Close();
                MessageBox.Show($@"Do not have any students in {Ctx.Code} Course", @"Notify", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            dgw_data.MultiSelect = false;
            dgw_data.ReadOnly = true;
            dgw_data.AllowUserToResizeColumns = false;
            dgw_data.AllowUserToResizeRows = false;

            var roll = new DataGridViewTextBoxColumn()
            {
                Name = "roll",
                HeaderText = @"Roll ID",
                DataPropertyName = "RollId",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            var name = new DataGridViewTextBoxColumn()
            {
                Name = "name",
                HeaderText = @"Name",
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            dgw_data.Columns.AddRange(roll,name);
            dgw_data.DataSource = data;

        }
    }
}

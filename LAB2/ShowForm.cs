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
        public ShowForm()
        {
            InitializeComponent();
            _data = Course.FetchAll();
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {
            dgw_courses.DataSource = _data;
            _data = Course.FetchAll();
        }
    }
}

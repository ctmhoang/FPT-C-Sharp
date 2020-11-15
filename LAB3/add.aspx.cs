using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LAB2.Bean;

namespace LAB3
{
    public partial class add : System.Web.UI.Page
    {
        private List<StudentWrapper> _data;

        public class StudentWrapper
        {
            public Student Student { get; set; }
            public bool Selected { get; set; }
            public string Name => Student.Name;
            public string RollId => Student.RollId;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            _data = Student.FetchAll().AsQueryable()
                .Except(Student.GetAllStudentIdsBy(
                    Convert.ToInt32(Request.QueryString["cid"])
                ).Select(Student.Get).ToList())
                .Select(stu => new StudentWrapper() {Selected = false, Student = stu}).ToList();
            ;
            gw_students.DataSource = _data;
            gw_students.DataBind();
        }


        protected void btn_ser_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void btn_add_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void OnCheckedChanged(object sender, EventArgs e)
        {
            _data = (List<StudentWrapper>) gw_students.DataSource;
            var tmp = (CheckBox) sender;
            tmp.Checked = !tmp.Checked;
            var row = (GridViewRow) tmp.NamingContainer;
            _data[row.RowIndex].Selected = tmp.Checked;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LAB2.Bean;

namespace LAB3
{
    public partial class Add : Page
    {
        private List<StudentWrapper> _displayData;

        public class StudentWrapper
        {
            public Student Student { get; set; }
            public bool Selected { get; set; }
            public string Name => Student.Name;
            public string RollId => Student.RollId;
        }

        public bool IsSelected(StudentWrapper w)
        {
            return w.Selected;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Rebound();
                return;
            }
            Session["AddStudent"] = Student.FetchAll().AsQueryable()
                .Except(Student.GetAllStudentIdsBy(
                    Convert.ToInt32(Request.QueryString["cid"])
                ).Select(Student.Get).ToList())
                .Select(stu => new StudentWrapper() { Selected = false, Student = stu }).ToList();
            _displayData = (List<StudentWrapper>)Session["AddStudent"];
            Rebound();
        }


        protected void btn_ser_OnClick(object sender, EventArgs e)
        {
            _displayData = (List<StudentWrapper>)gw_students.DataSource;
        }

        protected void btn_add_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void Rebound()
        {
            gw_students.DataSource = _displayData;
            gw_students.DataBind();
        }

    }
}
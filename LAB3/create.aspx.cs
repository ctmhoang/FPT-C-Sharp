using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LAB2.Bean;

namespace LAB3
{
    public partial class Create : Page
    {
        private string _sortDirection;

        protected void Page_Load(object sender, EventArgs e)
        {
            ddl_ins.DataSource = Instructor.FetchAll();
            ddl_ins.DataValueField = "Id";
            ddl_ins.DataTextField = "Name";
            ddl_ins.DataBind();

            ddl_sub.DataSource = Subject.FetchAll();
            ddl_sub.DataValueField = "Id";
            ddl_sub.DataTextField = "Name";
            ddl_sub.DataBind();

            gw_students.DataSource = Student.FetchAll();
            gw_students.DataBind();
            if (IsPostBack)
                _sortDirection = ViewState["SD"].ToString();
            else
            {
                _sortDirection = "ASC";
                ViewState["SD"] = _sortDirection;
            }
        }

        protected void btn_submit_OnClick(object sender, EventArgs e)
        {
            int id = Course.Insert(txb_code.Text, txb_des.Text, Convert.ToInt32(ddl_sub.SelectedValue),
                Convert.ToInt32(ddl_ins.SelectedValue));
            Course.RegisterStudentIn(id, GetStudent());
            Response.Redirect("index.aspx");
        }

        private IEnumerable<Student> GetStudent()
        {
            var stuList = new List<Student>(15);
            var checkBoxList = gw_students.Columns.OfType<CheckBox>().ToList();
            var studentList = (List<Student>) gw_students.DataSource;
            for (int i = 0; i < checkBoxList.Count; i++)
                if (checkBoxList[i].Checked)
                    stuList.Add(studentList[i]);
            return stuList;
        }

        protected void gw_students_OnSorting(object sender, GridViewSortEventArgs e)
        {
            SetDirection((string) ViewState["SD"]);
            var data = Student.FetchAll();
            if (gw_students.DataSource == null) return;
            switch (_sortDirection)
            {
                case "DESC":
                    data.Sort((student, student1) => -student.Id.CompareTo(student1.Id));
                    break;
                case "ASC":
                    data.Sort((student, student1) => student.Id.CompareTo(student1.Id));
                    break;
            }

            ViewState["SD"] = _sortDirection;
            gw_students.DataSource = data;
            gw_students.DataBind();
        }

        private void SetDirection(string dir)
        {
            _sortDirection = dir == "ASC" ? "DESC" : "ASC";
        }
    }
}
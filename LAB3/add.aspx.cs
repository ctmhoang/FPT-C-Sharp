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
        protected void Page_Load(object sender, EventArgs e)
        {
            gw_students.DataSource = GetNotRegisteredStudents();
            gw_students.DataBind();
        }


        protected void btn_ser_OnClick(object sender, EventArgs e)
        {
            var showList1 = new List<Student>(10);
            var showList2 = new List<Student>(10);
            var curList = (List<Student>) gw_students.DataSource;
            if (!string.IsNullOrEmpty(txb_name.Text.Trim()))
                showList1.AddRange(curList.Where(studentWrapper =>
                    studentWrapper.Name.ToLower().Contains(txb_name.Text.ToLower().Trim())));

            if (!string.IsNullOrEmpty(txb_Id.Text.Trim()))
                showList2.AddRange(curList.Where(studentWrapper =>
                    studentWrapper.RollId.ToLower().Contains(txb_Id.Text.ToLower().Trim())));

            if (string.IsNullOrEmpty(txb_name.Text.Trim()) || string.IsNullOrEmpty(txb_Id.Text.Trim()))
                gw_students.DataSource = showList1.Any() ? showList1 : showList2;
            else
                gw_students.DataSource = showList1.AsQueryable().Intersect(showList2);
            gw_students.DataBind();
        }


        protected void gw_students_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Add")
            {
                Course.RegisterStudentIn(Convert.ToInt32(Request.QueryString["cid"]),
                    new List<Student>() {((List<Student>) gw_students.DataSource)[Convert.ToInt32(e.CommandArgument)]});
                Response.Redirect(Request.RawUrl);
            }
        }

        private List<Student> GetNotRegisteredStudents()
        {
            return Student.FetchAll().AsQueryable()
                .Except(Student.GetAllStudentIdsBy(
                    Convert.ToInt32(Request.QueryString["cid"])
                ).Select(Student.Get).ToList())
                .ToList();
        }
    }
}
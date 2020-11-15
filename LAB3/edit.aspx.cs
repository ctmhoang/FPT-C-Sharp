using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LAB2.Bean;

namespace LAB3
{
    public partial class Edit : System.Web.UI.Page
    {
        private List<Student> _data;
        protected void Page_Load(object sender, EventArgs e)
        {
            _data = Student.GetAllStudentIdsBy(Convert.ToInt32(Request.QueryString["cid"])).Select(Student.Get).ToList();
            if (!_data.Any()) return;
            gw_display.DataSource = _data;
            gw_display.DataBind();
            lb_tot.Text += $@"{_data.Count} Students";
        }


        protected void btn_add_OnClick(object sender, EventArgs e)
        {
            Response.Redirect($"add.aspx?cid={Convert.ToInt32(Request.QueryString["cid"])}");
        }

        protected void gw_display_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Student.Leave(_data[e.RowIndex].Id, Convert.ToInt32(Request.QueryString["cid"]));
            Response.Redirect(Request.RawUrl);
        }
    }
}
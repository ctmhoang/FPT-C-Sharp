using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LAB2.Bean;

namespace LAB3
{
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var data = Student.GetAllStudentIdsBy(Convert.ToInt32(Request.QueryString["cid"])).Select(Student.Get).ToList();
            if (!data.Any()) return;
            lb_notify.Visible = false;
            gw_display.Visible = true;
            gw_display.DataSource = data;
            gw_display.DataBind();
        }
    }
}
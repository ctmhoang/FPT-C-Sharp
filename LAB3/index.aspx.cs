using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LAB2.Bean;

namespace LAB3
{
    public partial class Index : System.Web.UI.Page
    {
        private List<Course> _data;
        protected void Page_Load(object sender, EventArgs e)
        {
            Course.Update();
            _data = Course.FetchAll();
            dg_display.DataSource = _data;
            dg_display.DataBind();

            lb_tot.Text = $@"Total: {((List<Course>) dg_display.DataSource).Count()} Courses";
        }


        protected void dg_display_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
           Course.Delete(_data[e.RowIndex]);
           Response.Redirect(Request.RawUrl);
        }

        protected void dg_display_OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            Response.Redirect($"edit.aspx?cid={_data[e.NewEditIndex].Id}");
        }
    }
}
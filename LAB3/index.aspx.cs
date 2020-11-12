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
      
        protected void Page_Load(object sender, EventArgs e)
        {
            Course.Update();
            dg_display.DataSource = Course.FetchAll();
            dg_display.DataBind();

            lb_tot.Text = $@"Total: {((List<Course>)dg_display.DataSource).Count()} Courses";

        }

        protected void dg_display_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }
    }
}
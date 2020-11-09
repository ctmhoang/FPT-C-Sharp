using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class viewcart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            data.DataSource = Session["cart"];
            data.DataBind();
        }
    }
}
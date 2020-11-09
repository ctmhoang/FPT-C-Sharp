using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Winform.Business;

namespace WebForm
{
    public partial class home : System.Web.UI.Page
    {
        private int _currCategoryId, _currPage;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_cat_sel.DataTextField = "Name";
                ddl_cat_sel.DataValueField = "Id";
                ddl_cat_sel.DataSource = Category.FetchAll();
                ddl_cat_sel.DataBind();
            }
            LoadProducts();
        }

        protected void ddl_cat_sel_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void BindValue()
        {
            _currCategoryId = Convert.ToInt32(ddl_cat_sel.SelectedValue);
            _currPage = 1;
        }

        private void LoadProducts()
        {
            BindValue();
            dg_product_display.DataSource = Product.FetchAllByCategoryId(_currCategoryId);
            dg_product_display.DataBind();
        }

        protected void dg_product_display_OnItemCommand(object source, DataGridCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.Item.Cells[0].Text); ;
            switch (((IButtonControl)e.CommandSource).CommandName)
            {
                case "Delete":
                    Product.DeleteRange(Enumerable.Repeat(id, 1).ToList());
                    LoadProducts();  
                    break;
                case "Add":
                    var curCart = (Dictionary<int, int>) Session["cart"];
                    curCart[id] = curCart.ContainsKey(id) ? ++curCart[id] : 1;
                    Session["cart"] = curCart;
                    break;

                default:
                    break;
            }
        }

        private void CreatePager()
        {
            // pager.DataSource = Enumerable.Range(1, HomeService.GetTotalPage(Product.FetchAllByCategoryId(_currCategoryId))).ToList();
        }

        protected void SetCurrentPage(object sender, CommandEventArgs e)
        {
            _currPage = (int) e.CommandArgument;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicalLayer;
using System.Data;

namespace Flower_Project
{
    public partial class MainPage : System.Web.UI.MasterPage
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {
                btnAddToCart.Attributes["href"] = "./AddToCartPage.aspx";
            }
            else
            {
                btnAddToCart.Attributes["href"] = "./LoginForm.aspx?a="+"add";
            }
           // List<string> li = bll.GetSearchingProductBll(txtSearch.Value);
            aAdmin.Attributes["href"] = "./Admin.aspx";

        }
    }
}
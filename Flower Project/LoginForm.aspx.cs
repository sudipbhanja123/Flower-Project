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
    public partial class LoginForm : System.Web.UI.Page
    {
        public string Name { get; set; }
        public string Id { get; set; }
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            CheckUserLogin();
            
        }
        private void CheckUserLogin()
        {
            DataTable dt = bll.CheckUserLoginBll(txtEmail.Value, txtPassword.Value);
            foreach (DataRow dr in dt.Rows)
            {
                string name = dr["name"].ToString();
                string[] firstName = name.Split(' ');
                if (Request.QueryString["a"] == "add")
                {
                    Session["userId"] = dr["id"].ToString();
                    Session["userName"] = firstName[0];
                    Response.Redirect("./AddToCartPage.aspx");
                }
                if (Request.QueryString["a"] == "select")
                {
                    //Id = Request.QueryString["value"];
                    Session["userId"] = dr["id"].ToString();
                    Session["userName"] = firstName[0];
                    Response.Redirect("./SelectFlowerUsingCatagory.aspx");
                }
                if (Request.QueryString["a"] == "p")
                {
                    Session["userId"] = dr["id"].ToString();
                    Session["userName"] = firstName[0];
                    Response.Redirect("./HomeUnderMain.aspx");
                }

                else if (dr["id"].ToString() != null && dr["name"].ToString() != null)
                {
                    Session["userId"] = dr["id"].ToString();
                    Session["userName"] = firstName[0];
                    Id = Request.QueryString["value"];
                    //Session["productId"] = Session["pId"];
                    Response.Redirect("./ViewDetailsUnderMain.aspx?value=" + Id);
                }
                else
                {
                    Response.Write("Please Check Id or Password");
                }
            }
        }

       
    }
}
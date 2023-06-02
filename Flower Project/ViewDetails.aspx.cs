using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessLogicalLayer;

namespace Flower_Project
{
    public partial class ViewDetails : System.Web.UI.Page
    {
        public string Id { get; set; }
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if (Session["userId"] != null && Session["userName"]!=null)
                {
                    
                    aLogin.InnerHtml = "Logout";
                    profile.InnerHtml = Session["userName"].ToString();
                    
                }
                else
                {
                    aLogin.InnerHtml = "Login";
                }

                aLogin.ServerClick += new EventHandler(aLogin_ServerClick);
                GetFullProductDetails();

        }
        private void aLogin_ServerClick(object sender, EventArgs e)
        {
            if (aLogin.InnerText == "Login")
            {
                Response.Redirect("./LoginForm.aspx");
            }
            else
            {
                Session["userId"] = null;
                Session["userName"] = null;
                Response.Redirect("./HomePage.aspx");
                
            }
        }

       
        
        private void GetFullProductDetails()
        {
            Id = Request.QueryString["value"];
            Label1.Text = Id;
            Label1.Visible = false;
            //Session["idForView"] = Id;
            DataTable dt = bll.GetProductDetailsUsingIdBll(Label1.Text);
            foreach(DataRow dr in dt.Rows)
            {
                ProductImage.Attributes["src"] = "data:image/webp;base64," + dr["image"].ToString();
                ProductName.InnerHtml = dr["TitleOrName"].ToString();
                ActualPrice.InnerHtml = dr["actualPrice"].ToString();
                lblType.InnerHtml = dr["collectionType"].ToString();
                EffectivePrice.InnerHtml = dr["effectivePrice"].ToString();
                PercentageOfDiscount.InnerHtml = dr["discount"].ToString();
                labelVaseIncludeStatus.InnerText = dr["vaseIncluded"].ToString();
                labelVaseMaterial.InnerText = dr["vaseMaterial"].ToString();
                lblLength.InnerHtml = dr["length"].ToString();
                labelFlowerMaterial.InnerHtml = dr["productMaterial"].ToString();
                lbldescription.InnerHtml = dr["description"].ToString();
                lblBrandName.InnerHtml = dr["name"].ToString();
                lblModelName.InnerHtml = dr["modelName"].ToString();
                lblModelNumber.InnerHtml = dr["modelNumber"].ToString();
                lblFlowerType.InnerHtml = dr["flowerType"].ToString();
                lblCollectionType.InnerHtml = dr["collectionType"].ToString();
                lblColor.InnerHtml = dr["color"].ToString();
                lblShade.InnerHtml = dr["shade"].ToString();
                lblFragrance.InnerHtml = dr["fragrance"].ToString();
                lblFlowerMaterial.InnerHtml = dr["productMaterial"].ToString();
                lblVaseIcludedStatus.InnerHtml=dr["vaseIncluded"].ToString();
                lblVaseMaterial.InnerHtml = dr["vaseMaterial"].ToString();
                lblGliterCoated.InnerHtml = dr["gliterCoated"].ToString();
                lblTotalLength.InnerHtml = dr["length"].ToString();
            }
        }

        //private void GetSearchingProducts()
        //{
        //    DataSet products = bll.GetSearchingProductBll(txtSearch.Value);

        //    txtSearch.Value = products.ToString();
        //}
        private void btnSearch_Click(object sender, EventArgs e)
        {
           // GetSearchingProducts();
        }

        protected void btnBuyNow_Click(object sender, EventArgs e)
        {
            
            if (Session["userId"] == null)
            {
                Response.Redirect("./LoginForm.aspx");
            }
            else
            {
                
                Session["productId"] = Id;
                Response.Redirect("./BuyNowPage.aspx");
                
            }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}
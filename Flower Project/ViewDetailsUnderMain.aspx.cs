using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicalLayer;
using System.Data;
using System.Web.UI.HtmlControls;

namespace Flower_Project
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public string Id { get; set; }
        BLL bll = new BLL();
        HtmlAnchor anchor = null;
        HtmlGenericControl profile = null;
        public string relatedColor { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Request.QueryString["value"];
            if (Session["userId"] != null)
            {
                
                int rows = bll.GetCartRowsBll(Session["userId"].ToString(),Id);

                if (rows > 0)
                {
                    btnAddToCard.Text = "Go To Cart";
                }
                else
                {
                    btnAddToCard.Text = "Add To Cart";
                }
            }
            //else
            //{
            //    HtmlGenericControl exception = new HtmlGenericControl("h6");
            //    exception.InnerHtml = "some error occured";
            //    exception.Style.Add(HtmlTextWriterStyle.TextAlign, "center");
            //    main.Controls.Add(exception);
            //}
           
            anchor = (HtmlAnchor)Page.Master.FindControl("aLogin");
            profile = (HtmlGenericControl)Page.Master.FindControl("profile");

            if (Session["userId"] != null && Session["userName"] != null)
            {
                
                anchor.InnerHtml = "Logout";
                profile.InnerHtml = Session["userName"].ToString();

            }
            else
            {
                anchor.InnerHtml = "Login";
            }
            anchor.ServerClick += new EventHandler(aLogin_ServerClick);
            try
            {
                GetFullProductDetails();
                tblViewProducts();
            }
            catch
            {
                HtmlGenericControl exception = new HtmlGenericControl("h1");
                exception.InnerHtml = "some error occured";
                exception.Style.Add(HtmlTextWriterStyle.TextAlign, "center");
                main.Visible = false;
                Response.Write(exception.InnerHtml);
            }
            //tblViewProducts();
        }

        private void aLogin_ServerClick(object sender, EventArgs e)
        {
            if (anchor.InnerText == "Login")
            {
                //Session["pId"] = Id;
                Response.Redirect("./LoginForm.aspx?value=" +Id);
                //anchor.Attributes["href"] = "./LoginForm.aspx?value=" +Id;
                
            }
            else
            {
                Session["userId"] = null;
                Session["userName"] = null;
                Response.Redirect("./HomeUnderMain.aspx");

            }
        }



        private void GetFullProductDetails()
        {


            

            // Id = Session["productId"].ToString();
            //Label1.Text = Id;
            //Label1.Visible = false;
            //Session["idForView"] = Id;
            DataTable dt = bll.GetProductDetailsUsingIdBll(Id);
            foreach (DataRow dr in dt.Rows)
            {
                ProductImage.Attributes["src"] = "data:image/webp;base64," + dr["image"].ToString();
                ProductName.InnerHtml = dr["TitleOrName"].ToString();
                ActualPrice.InnerHtml = "<span class='font-normal'>"+"₹"+"<span>"+dr["actualPrice"].ToString();
                productType.InnerHtml = dr["collectionType"].ToString();
                EffectivePrice.InnerHtml = "<span class='font-normal'>" + "₹" + "<span>" + dr["effectivePrice"].ToString();
                PercentageOfDiscount.InnerHtml = dr["discount"].ToString()+"% off";
                VaseIncludeStatus.InnerText = dr["vaseIncluded"].ToString();
                VaseMaterial.InnerText = dr["vaseMaterial"].ToString();
                highlightVaseMaterial.InnerHtml = dr["vaseMaterial"].ToString();
                Length.InnerHtml = dr["length"].ToString();
                FlowerMaterial.InnerHtml = dr["productMaterial"].ToString();
                description.InnerHtml = dr["description"].ToString();
                BrandName.InnerHtml = dr["name"].ToString();
                ModelName.InnerHtml = dr["modelName"].ToString();
                ModelNumber.InnerHtml = dr["modelNumber"].ToString();
                FlowerType.InnerHtml = dr["flowerType"].ToString();
                CollectionType.InnerHtml = dr["collectionType"].ToString();
                Color.InnerHtml = dr["color"].ToString();
                relatedColor = dr["color"].ToString();
                Shade.InnerHtml = dr["shade"].ToString();
                Fragrance.InnerHtml = dr["fragrance"].ToString();
                FlowerMaterial.InnerHtml = dr["productMaterial"].ToString();
                VaseIcludedStatus.InnerHtml = dr["vaseIncluded"].ToString();
                VaseMaterial.InnerHtml = dr["vaseMaterial"].ToString();
                GliterCoated.InnerHtml = dr["gliterCoated"].ToString();
                TotalLength.InnerHtml = dr["length"].ToString();
                generalModelName.InnerHtml = dr["modelName"].ToString();
                generalBrandName.InnerHtml = dr["name"].ToString();
                generalFlowerMaterial.InnerHtml = dr["productMaterial"].ToString();
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


        protected void btnAddToCard_Click(object sender, EventArgs e)
        {
            if (Session["userId"] != null && Id != null)
            {
                bool result = bll.InsertProductToCartBll(Id, Session["userId"].ToString(), 1);
                if (result)
                {
                    Response.Redirect("./AddToCartPage.aspx?value=" + Id);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Product Not Added')", true);
                }
            }
            else
            {
                Response.Redirect("./LoginForm.aspx?value=" + Id);
            }
           
        }

        protected void btnBuyNow_Click1(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("./LoginForm.aspx?value=" + Id);
            }
            else
            {

                Session["productId"] = Id;
                Response.Redirect("./BuyNowPage.aspx");

            }
        }
        private void tblViewProducts()
        {
            DataTable dt = bll.GetRelatedProductsBll(relatedColor);

            foreach (DataRow dr in dt.Rows)
            {

                HtmlGenericControl img = new HtmlGenericControl("img");
                //img.Attributes["class"] = "card-img-top";
                img.Attributes["class"] = "rounded-t-lg";
                img.Style.Add(HtmlTextWriterStyle.Height, "100%");
                img.Style.Add(HtmlTextWriterStyle.Width, "100%");
                img.Attributes["src"] = "data:image/webp;base64," + dr["image"].ToString();

                var effect = new HtmlGenericControl("p");
                effect.Attributes["class"] = "card-text text-md m-0";
                effect.InnerHtml = dr["effectPrice"].ToString();

                var discount = new HtmlGenericControl("p");
                discount.Attributes["class"] = "card-text text-md m-0";
                discount.InnerHtml = dr["discount"].ToString() + "%";

                var actual = new HtmlGenericControl("p");
                actual.Attributes["class"] = "card-text text-sm m-0";


                var pName = new HtmlGenericControl("h5");
                pName.Attributes["class"] = "text-md lg:text-xl font-semibold tracking-tight text-gray-900 text-lg";
                pName.InnerHtml = dr["name"].ToString();


                string[] name = dr["name"].ToString().Split(' ');
                Label lbl = new Label();
                lbl.Text = dr["id"].ToString();
                lbl.Attributes.Add("runat", "server");


                pName.Style.Add(HtmlTextWriterStyle.WhiteSpace, "nowrap");
                pName.Style.Add(HtmlTextWriterStyle.TextOverflow, "ellipsis");
                pName.Style.Add(HtmlTextWriterStyle.Overflow, "hidden");

                var card = new HtmlGenericControl("div ");
                //card.Attributes["class"] = "ProductsDiv card border-0 pt-1 ";
                card.Attributes["class"] = "max-w-sm bg-white rounded-lg  border-2";
                card.Style.Add(HtmlTextWriterStyle.Height, "260px");

                var a = new HtmlAnchor();
                a.Controls.Add(card);


                var MRPandDiscount = new HtmlGenericControl("p");
                MRPandDiscount.Attributes["id"] = "MRPandDiscount";
                MRPandDiscount.Attributes["class"] = "font-semibold";
                MRPandDiscount.InnerHtml = "₹" + dr["effectPrice"].ToString() + "/-  " + "<span class=" + "line-through text-gray-400>" + dr["actual"].ToString() + "</span>" + "  " + "<span style=" + "color:Green>" + dr["discount"].ToString() + "%" + "</span>";



                var cardBody = new HtmlGenericControl("div");
                cardBody.Attributes["class"] = "card-body p-0";

                var cardBodyImg = new HtmlGenericControl("div");
                cardBodyImg.Attributes["class"] = "card-img-top ";
                cardBodyImg.Style.Add(HtmlTextWriterStyle.Height, "75%");
                cardBodyImg.Controls.Add(img);

                var cardBodyText = new HtmlGenericControl("div");
                cardBodyText.Attributes["class"] = "px-2 py-2";
                cardBodyText.Controls.Add(pName);
                cardBodyText.Controls.Add(MRPandDiscount);

                cardBody.Controls.Add(cardBodyText);
                //cardBody.Controls.Add(btn);
                cardBody.Controls.Add(lbl);
                card.Controls.Add(cardBodyImg);
                card.Controls.Add(cardBody);

                lbl.Visible = false;

                var divRowSub = new HtmlGenericControl("div");
                divRowSub.Attributes["class"] = " col-span-3 md:col-span-2 lg:col-span-1 mb-1 px-2 mb-1 rounded";
                var HomePageProductDivAsLink = new HtmlGenericControl("a");
                HomePageProductDivAsLink.Attributes["id"] = "HomePageProductDivAsLink";
                //Session["id"] = dr["id"].ToString();
                HomePageProductDivAsLink.Attributes["href"] = "./ViewDetailsUnderMain.aspx?value=" + dr["id"].ToString();

                HomePageProductDivAsLink.Style.Add(HtmlTextWriterStyle.TextDecoration, "none");
                HomePageProductDivAsLink.Controls.Add(card);
                divRowSub.Controls.Add(HomePageProductDivAsLink);
                productsContainer.Controls.Add(divRowSub);

            }


        }
    }
}
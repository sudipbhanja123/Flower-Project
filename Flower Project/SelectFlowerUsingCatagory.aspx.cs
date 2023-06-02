using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.HtmlControls;
using BusinessLogicalLayer;

namespace Flower_Project
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        HtmlAnchor anchor = null;
        HtmlGenericControl profile = null;
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            anchor = (HtmlAnchor)Page.Master.FindControl("aLogin");
            profile = (HtmlGenericControl)Page.Master.FindControl("profile");
            if (Session["UserId"] != null)
            {
                anchor.InnerHtml = "Logout";
                profile.InnerHtml = Session["userName"].ToString();
            }
            else
            {
                anchor.InnerHtml = "Login";
            }
            anchor.ServerClick += new EventHandler(aLogin_ServerClick);
            CreateCategoryItem();
            try
            {
                ViewProducts();
            }
            catch (Exception ex)
            {
                HtmlGenericControl exception = new HtmlGenericControl("h6");
                exception.InnerHtml = "some error occured";
                exception.Style.Add(HtmlTextWriterStyle.TextAlign, "center");
                productsContainer.Controls.Add(exception);
            }

        }
        private void aLogin_ServerClick(object sender, EventArgs e)
        {
            if (anchor.InnerText == "Login")
            {
                //Session["pId"] = Id;
                Response.Redirect("./LoginForm.aspx?a=" + "select");
                //anchor.Attributes["href"] = "./LoginForm.aspx?value=" +Id;

            }
            else
            {
                Session["userId"] = null;
                Session["userName"] = null;
                Response.Redirect("./HomeUnderMain.aspx");

            }
        }
        private void CreateCategoryItem()
        {

            DataTable d = bll.GetProductCategoryBll();
            foreach (DataRow dr in d.Rows)
            {
                HtmlGenericControl mainDiv = new HtmlGenericControl("div");
                mainDiv.Attributes["class"] = " h-10 lg:h-14 flex p-1 pr-5 md:pr-2 lg:pr-4 rounded-full border-2 border-teal-600 shadow-md";

                var CategoryImage = new HtmlGenericControl("img");
                CategoryImage.Attributes["class"] = "rounded-full border shadow h-full lg:w-12 w-7 float-left border-teal-300";
                CategoryImage.Attributes["src"] = "data:image/webp;base64," + dr["imageCatagory"].ToString();


                var Category = new HtmlGenericControl("p");
                Category.Attributes["class"] = "text-xs py-1 lg:py-1.5 ml-2 font-semibold text-sm lg:text-xl text-teal-800";
                Category.InnerHtml = dr["type"].ToString();

                var link = new HtmlGenericControl("a");
                link.Attributes["class"] = "cursor-pointer";

                mainDiv.Controls.Add(CategoryImage);
                mainDiv.Controls.Add(Category);
                link.Controls.Add(mainDiv);
                categoryDiv.Controls.Add(link);
                link.Attributes["href"] = "./SelectFlowerUsingCatagory.aspx?type=" + dr["type"].ToString();
            }
        }
        private void ViewProducts()
        {
            string id = Session["productType"].ToString();
            DataTable dt = bll.GetProductUsingCategoryBll(id);

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
                    MRPandDiscount.InnerHtml = dr["effectPrice"].ToString() + "/-  " + "<span class=" + "line-through text-gray-400>" + dr["actual"].ToString() + "</span>" + "  " + "<span style=" + "color:Green>" + dr["discount"].ToString() + "%" + "</span>";



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
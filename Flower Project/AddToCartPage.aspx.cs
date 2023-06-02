using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicalLayer;
using System.Web.UI.HtmlControls;
using System.Data;

namespace Flower_Project
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        HtmlAnchor anchor = null;
        HtmlGenericControl profile = null;
        BLL bll = new BLL();
        string UserId { get; set; }
        string ProductId { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            UserId = Session["userId"].ToString();
            ProductId = Request.QueryString["Id"];
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
            GetAddToCartDetails();
            if (ProductId == null)
            {
                main.Visible = false;
                HtmlGenericControl add = new HtmlGenericControl("a");
                add.InnerHtml = "Add To Cart";
                mainDiv.Controls.Add(add);
            }

        }
        private void GetAddToCartDetails()
        {
            
            int flowerPrice=0;
            int mainPrice = 0;
            DataTable dt = bll.GetAddToCartProductBll(Session["userId"].ToString());
            foreach(DataRow dr in dt.Rows)
            {
                
                HtmlGenericControl childProductsContainer = new HtmlGenericControl("div");
                childProductsContainer.Attributes["class"] = "grid grid-cols-12 shadow p-4 gap-4 py-2";

                HtmlGenericControl childOfChildProductsContainer = new HtmlGenericControl("div");
                childOfChildProductsContainer.Attributes["class"] = "lg:col-span-3  md:col-span-4 sm:col-span-3 col-span-4 shadow-violet lg:px-3 md:px-5 sm:px-7 px-1";
                HtmlGenericControl productImage = new HtmlGenericControl("img");
                productImage.Attributes["class"] = "rounded border-2 border-teal-300 ";
                productImage.Attributes["src"] = "data:image/webp;base64," + dr["image"].ToString();
                HtmlGenericControl div1 = new HtmlGenericControl("div");
                div1.Attributes["class"] = "grid grid-cols-1 lg:h-10 gap-4 mt-2";
                HtmlGenericControl div1Child = new HtmlGenericControl("div");
                div1Child.Attributes["class"] = "col-span-1  lg:gap-2 h-full ";
                HtmlGenericControl childOfDiv1Child = new HtmlGenericControl("div");
                childOfDiv1Child.Attributes["class"] = "grid grid-cols-3 flex flex-row w-full justify-between items-center";
                HtmlGenericControl quantityDecrease = new HtmlGenericControl("button");
                quantityDecrease.Attributes["class"] = "col-span-1 border border-violet center lg:font-semibold lg:leading-4 rounded-full  text-black outline-none  uppercase shadow-md shadow-violet text-lg hover:shadow-lg focus:ring-0 active:bg-gray-300 active:shadow-lg active:text-white transition duration-150 ease-in-out h-full md:h-10 w-full";
                quantityDecrease.Attributes["style"] = "float:left;";
                quantityDecrease.Attributes["type"] = "button";
                quantityDecrease.Attributes["value"] = "-";
                quantityDecrease.InnerHtml = "-";
                HtmlGenericControl quantity = new HtmlGenericControl("p");
                quantity.Attributes["class"] = "col-span-1 text-center";
                quantity.Attributes["style"] = "float:left";
                quantity.Attributes["value"] = "1";
                quantity.InnerHtml = "1";
                HtmlGenericControl quantityIncrease = new HtmlGenericControl("button");
                quantityIncrease.Attributes["class"] = "col-span-1 inline-block border border-violet rounded-full  text-black uppercase shadow-md  hover:shadow-lg    focus:ring-0 active:bg-gray-300 active:shadow-lg active:text-white transition duration-150 ease-in-out w-full h-full";
                quantityIncrease.Attributes["id"]="inc";
                quantityIncrease.Attributes["style"] = "float:left;";
                quantityIncrease.Attributes["type"] = "button";
                quantityIncrease.Attributes["value"] = "+";
                quantityIncrease.InnerHtml = "+";
                quantityIncrease.Attributes.Add("runat", "server");
                quantityIncrease.Attributes.Add("onClick", "QuantityIncrease(inc);");
                childOfChildProductsContainer.Controls.Add(productImage);
                childOfDiv1Child.Controls.Add(quantityDecrease);
                childOfDiv1Child.Controls.Add(quantity);
                childOfDiv1Child.Controls.Add(quantityIncrease);
                div1Child.Controls.Add(childOfDiv1Child);
                div1.Controls.Add(div1Child);
                childOfChildProductsContainer.Controls.Add(div1);
                childProductsContainer.Controls.Add(childOfChildProductsContainer);


                HtmlGenericControl productDetailsContainer = new HtmlGenericControl("div");
                productDetailsContainer.Attributes["class"] = "col-span-8  md:col-span-8 sm:col-span-8 lg:col-span-19 ";

                HtmlGenericControl pName = new HtmlGenericControl("p");
                pName.Attributes["class"] = "text-sm md:text-md lg:text-2xl font-semibold text-black";
                pName.Attributes["style"] = "text-overflow: ellipsis;white-space: nowrap;overflow: hidden;";
                pName.InnerText = dr["TitleOrName"].ToString();



                HtmlGenericControl lengthAndPack = new HtmlGenericControl("p");
                lengthAndPack.Attributes["class"] = "text-sm lg:text-lg md:text-md";
                HtmlGenericControl length = new HtmlGenericControl("span");
                length.InnerHtml = dr["length"].ToString();
                lengthAndPack.Controls.Add(length);
                HtmlGenericControl pack = new HtmlGenericControl("span");
                pack.InnerHtml = ", Pack of ";
                lengthAndPack.Controls.Add(pack);
                HtmlGenericControl packOf = new HtmlGenericControl("span");
                packOf.InnerHtml = "1";
                lengthAndPack.Controls.Add(packOf);
                HtmlGenericControl type = new HtmlGenericControl("span");
                type.InnerText = dr["collectionType"].ToString();
                lengthAndPack.Controls.Add(type);
                productDetailsContainer.Controls.Add(lengthAndPack);

                HtmlGenericControl Seller = new HtmlGenericControl("p");
                Seller.InnerText = "Seller";
                Seller.Attributes["class"] = "text-gray-400 pt-1 lg:py-2 text-sm lg:text-lg";
                HtmlGenericControl sellerName = new HtmlGenericControl("span");
                sellerName.InnerHtml = "Paromita flower";
                sellerName.Attributes["class"] = "text-amber-500 px-4";
                Seller.Controls.Add(sellerName);

                HtmlGenericControl Price = new HtmlGenericControl("p");
                HtmlGenericControl actualPrice = new HtmlGenericControl("span");
                HtmlGenericControl actualPriceLogo = new HtmlGenericControl("span");
                actualPriceLogo.InnerText = "₹";
                actualPriceLogo.Attributes["class"] = "font-sans";
                HtmlGenericControl actPrice = new HtmlGenericControl("span");
                actPrice.InnerHtml = dr["actualPrice"].ToString();

                mainPrice =mainPrice+ Convert.ToInt32(dr["actualPrice"]);

                actualPrice.Controls.Add(actualPriceLogo);
                actualPrice.Controls.Add(actPrice);
                actualPrice.Attributes["class"] = "text-gray-400 line-through";
                Price.Controls.Add(actualPrice);

                HtmlGenericControl effectivePrice = new HtmlGenericControl("span");
                HtmlGenericControl effectivePriceLogo = new HtmlGenericControl("span");
                effectivePriceLogo.InnerText = "₹";
                effectivePriceLogo.Attributes["class"] = "font-sans";
               
                HtmlGenericControl eftPrice = new HtmlGenericControl("span");
                eftPrice.InnerText = dr["effectivePrice"].ToString();

                flowerPrice =flowerPrice+ Convert.ToInt32( dr["effectivePrice"]);
                totalPrice.InnerHtml = flowerPrice.ToString();
                totalPayable.InnerHtml = flowerPrice.ToString();


                effectivePrice.Attributes["class"] = "text-black-500 text-xl font-semibold px-2";
                effectivePrice.Controls.Add(effectivePriceLogo);
                effectivePrice.Controls.Add(eftPrice);
                Price.Controls.Add(effectivePrice);

                HtmlGenericControl percentOfDiscount = new HtmlGenericControl("span");


                percentOfDiscount.Attributes["class"] = "px-1 text-green-500";
                HtmlGenericControl percentage = new HtmlGenericControl("span");
                percentage.InnerHtml = dr["discount"].ToString();


                // = discountedPrice + Convert.ToInt32(dr["discount"]);

                totalSaving.InnerHtml = (mainPrice - flowerPrice).ToString();

                percentOfDiscount.Controls.Add(percentage);
                percentOfDiscount.InnerText = "% off";

                Price.Controls.Add(percentOfDiscount);


                HtmlGenericControl buttonDiv = new HtmlGenericControl("div");
                buttonDiv.Attributes["class"] = "grid grid-cols-5 flex flex-row  md:grid-cols-5 gap-2 md:pt-10";
                HtmlGenericControl child1OfButtonDiv = new HtmlGenericControl("div");
                child1OfButtonDiv.Attributes["class"] = "float-left col-span-2 md:col-span-2";
                Button remove = new Button();
                remove.Attributes["class"] = "border-2 border-teal-400 sm:px-2 sm:py-1 md:py-1 inline-block text-xs lg:text-xl px-1 py-1  text-teal-400 font-semibold  sm:text-md leading-tight uppercase rounded shadow shadow-black  lg:text-lg hover:text-white   focus:outline-none focus:ring-0   transition duration-150 ease-in-out w-full";
                remove.Attributes["style"] = "background-color: #F2F2F2;";
                //remove.Attributes["type"] = "button";
                //remove.ID= "btnRemove";
                remove.Text = "REMOVE";
                child1OfButtonDiv.Controls.Add(remove);

                remove.Attributes.Add("runat", "server");
                ProductId = dr["productId"].ToString();
                remove.Click+=new EventHandler(remove_Click);
                

                HtmlGenericControl child2OfButtonDiv = new HtmlGenericControl("div");
                child2OfButtonDiv.Attributes["class"] = "float-right col-span-3 md:col-span-2";
                HtmlGenericControl deliverHere = new HtmlGenericControl("button");
                deliverHere.Attributes["class"] = "border-2 border-teal-400 sm:px-2 sm:py-1 md:py-1 inline-block text-xs lg:text-xl px-1 py-1  text-teal-400 font-semibold  sm:text-md leading-tight uppercase rounded shadow shadow-black  lg:text-lg hover:text-white   focus:outline-none focus:ring-0   transition duration-150 ease-in-out w-full";
                deliverHere.Attributes["style"] = "background-color: #F2F2F2;";
                deliverHere.Attributes["type"] = "button";
                deliverHere.InnerText = "DELIVER HERE";
                child2OfButtonDiv.Controls.Add(deliverHere);
                productDetailsContainer.Controls.Add(pName);
                productDetailsContainer.Controls.Add(lengthAndPack);
                productDetailsContainer.Controls.Add(Seller);
                productDetailsContainer.Controls.Add(Price);
                buttonDiv.Controls.Add(child1OfButtonDiv);
                buttonDiv.Controls.Add(child2OfButtonDiv);


                productsContainer.Controls.Add(childProductsContainer);
                childProductsContainer.Controls.Add(childOfChildProductsContainer);
                childProductsContainer.Controls.Add(productDetailsContainer);

                product.Controls.Add(productsContainer);
                productDetailsContainer.Controls.Add(buttonDiv);
            }
        }
        private void remove_Click(object sender, EventArgs e)
        {
            bool result = bll.DeleteCartProductsBll(ProductId);
            if (result)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Product Deleted')", true);
                
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Product Not Delete')", true);
            }
            //Page.Response.Redirect(Page.Request.Url.ToString(), true);
            GetAddToCartDetails();
        }
        //private void GetAddToCartDetails()
        //{
            
        //    //HtmlGenericControl row = new HtmlGenericControl("div");
        //    //row.Attributes["class"] = "row mb-4 d-flex justify-content-between align-items-center";

        //    HtmlGenericControl image = new HtmlGenericControl("div");
        //    row.Attributes["class"] = "col-md-2 col-lg-2 col-xl-2";
        //    image.Attributes["src"] = "https://rukminim1.flixcart.com/image/612/612/ktyp8cw0/artificial-flower/0/e/f/2-lg-flower-101-laddu-gopal-original-imag76svbar5jrsh.jpeg?q=70";

        //    HtmlGenericControl nameDiv = new HtmlGenericControl("div");
        //    nameDiv.Attributes["class"] = "col-md-3 col-lg-3 col-xl-3";

        //    HtmlGenericControl name = new HtmlGenericControl("h6");
        //    name.Attributes["class"] = "mb-0";
        //    name.InnerHtml = "Laddu Gopal Laddu Gopal Home Or Office Decoration or Birthday Gift Red, Yellow Rose, Sunflower Artificial Flower (15 inch, Pack of 2) Yellow Sunflower Artificial Flower  (13 inch, Pack of 2)";

        //    HtmlGenericControl number = new HtmlGenericControl("div");
        //    number.Attributes["class"] = "col-md-3 col-lg-3 col-xl-2 d-flex";

        //    HtmlGenericControl priceDiv = new HtmlGenericControl("div");
        //    priceDiv.Attributes["class"] = "col-md-3 col-lg-2 col-xl-2 offset-lg-1";

        //    HtmlGenericControl price = new HtmlGenericControl("h6");
        //    price.Attributes["class"] = "mb-0";
        //    price.InnerHtml = "₹309.00";

        //    nameDiv.Controls.Add(name);
        //    priceDiv.Controls.Add(price);

        //    row.Controls.Add(image);
        //    row.Controls.Add(nameDiv);
        //    row.Controls.Add(number);
        //    row.Controls.Add(priceDiv);
        //}
    }
}
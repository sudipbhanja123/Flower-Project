using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BusinessLogicalLayer;
using System.Web.UI.HtmlControls;

namespace Flower_Project
{
    public partial class BuyNowPage : System.Web.UI.Page
    {
        public string UserId { get; set; }
        public string ProductId { get; set; }
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            GetFullProductDetails();
           // btnSaveAndDeliver.ServerClick+=new EventHandler(btnSaveAndDeliver_ServerClick);
           //aLoginAnotherAccount.ServerClick += new EventHandler(aLoginAnotherAccount_ServerClick);
          // aLoginAnotherAccount.Attributes["href"] = "./HomePageUnderMain.aspx";
            btnLogout.ServerClick+=new EventHandler(btnLogout_ServerClick);
            GetOrderSummery();
            OrderSummary.Style.Add(HtmlTextWriterStyle.Display, "flex");
        }
        protected void btnLogout_ServerClick(object sender, EventArgs e)
        {
            Session["userId"] = null;
            // Session["userName"] = null;
            Response.Redirect("./HomeUnderMain.aspx");
        }
      
        private void GetFullProductDetails()
        {
            if (Session["userId"] != null && Session["productId"] != null)
            {
                UserId = Session["userId"].ToString();
                ProductId = Session["productId"].ToString();
            }
            DataTable dtUser = bll.GetLoginCardinalityBll(UserId);
            foreach (DataRow dr in dtUser.Rows)
            {
                txtPhoneNumber.InnerHtml = dr["phoneNumber"].ToString();
                txtName.InnerHtml = dr["userName"].ToString();
                txtName1.InnerHtml = dr["userName"].ToString();
                txtPhoneNumber1.InnerHtml = dr["phoneNumber"].ToString();
            }
            DataTable dt = bll.BuyNowProductDetailsBll(ProductId);
            foreach (DataRow dr in dt.Rows)
            {
                txtPriceOfItems.InnerHtml = dr["effectPrice"].ToString();
                txtTotalPayable.InnerHtml = (Convert.ToInt32(dr["effectPrice"]) + 40).ToString();
                txtSavingOfItems.InnerHtml = ((Convert.ToInt32(dr["actualPrice"])) - (Convert.ToInt32(dr["effectPrice"]))).ToString();
            }
            DataTable dt1 = bll.BuyNowUserDetailsBll(UserId);
            foreach (DataRow dr in dt1.Rows)
            {
                
                //lblName.InnerHtml = dr["delivery"].ToString();
                //lblContact.InnerHtml = dr["phoneNumber"].ToString();
                //lblAddress.InnerHtml = dr["addressLine"].ToString() + "," + dr["landMark"].ToString() + "," + dr["cityOrVillage"].ToString() + "," + dr["pinCode"].ToString();
                HtmlGenericControl addresses = new HtmlGenericControl("div");
                addresses.Attributes["class"] = "col-span-1 border-b-2 border-lightgray-500 py-3";

                //HtmlGenericControl inp = new HtmlGenericControl("input");
                RadioButton inp = new RadioButton();
                inp.Attributes["name"] = "flexRadioDefault";
                inp.Attributes["value"] = "flexRadioDefault1";
                inp.Attributes["type"] = "radio";
                inp.Attributes["class"] = "form-check-input appearance-none rounded-full h-4 w-4 border border-gray-300 bg-white checked:border-4 checked:border-blue-600 focus:outline-none transition duration-200 mt-1 align-top bg-no-repeat bg-center bg-contain float-left mr-2 cursor-pointer";
                inp.GroupName = "radioAddress";
                

                HtmlGenericControl details = new HtmlGenericControl("p");
                details.Attributes["class"] = "form-check-label inline-block text-gray-800 font-semibold";

                HtmlGenericControl name = new HtmlGenericControl("span");
                name.InnerHtml = dr["delivery"].ToString()+"  ";


                HtmlGenericControl contact = new HtmlGenericControl("span");
                contact.InnerHtml = dr["phoneNumber"].ToString();

                HtmlGenericControl address = new HtmlGenericControl("p");
                address.Attributes["class"] = "mt-2 font-xs";
                address.Style.Add("font-size", "10px");
                address.InnerHtml = dr["addressLine"].ToString() + "," + dr["landMark"].ToString() + "," + dr["cityOrVillage"].ToString() + "," + dr["pinCode"].ToString();

                Button btnDeliver = new Button();
                btnDeliver.Attributes["class"] = "bg-teal-600 mt-4 shadow-inner border-2 border-teal-700 shadow-black hover:bg-teal-700 text-white font-bold py-2 px-6 border border-violet-700 rounded inline-block";
                btnDeliver.Text = "DELIVER HERE";

               

                Button btnRemove = new Button();
                btnRemove.Attributes["class"] = " inline-block shadow-inner shadow-black bg-transparent hover:bg-amber-300 text-amber-400 font-semibold hover:text-white px-6 py-2 border-2 border-amber-700 hover:border-transparent rounded";
                btnRemove.Text = "REMOVE";

                details.Controls.Add(name);
                details.Controls.Add(contact);
                addresses.Controls.Add(inp);
                addresses.Controls.Add(details);
                addresses.Controls.Add(address);
                addresses.Controls.Add(btnDeliver);
                addresses.Controls.Add(btnRemove);
                deliveryAddress.Controls.Add(addresses);


                if (inp.Checked)
                {
                    btnDeliver.Click += new EventHandler(btnDeliver_Click);
                }
                //btnDecrease.ServerClick += new EventHandler(btnDecrease_ServerClick);
                //btnIncrease.ServerClick += new EventHandler(btnIncrease_ServerClick);
            }
          

            //DataSet ds = bll.GetBuyNowUserDetailsByAddressIdBll(UserId);

            //if (ds.Tables[0].Rows.Count != 0)
            //{
                //lblName1.InnerHtml = ds.Tables[0].Rows[0]["deliveryToName"].ToString();
                //lblContact1.InnerHtml = ds.Tables[0].Rows[0]["primaryPhoneNumber"].ToString();
                //lblAddress1.InnerHtml = ds.Tables[0].Rows[0]["addressLine"].ToString() + "," + ds.Tables[0].Rows[0]["landMark"].ToString() + "," + ds.Tables[0].Rows[0]["cityOrVillage"].ToString() + "," + ds.Tables[0].Rows[0]["pinCode"].ToString();

                //HtmlGenericControl addresses = new HtmlGenericControl("div");
                //addresses.Attributes["class"] = "col-span-1 border-b-2 border-lightgray-500 py-3";
                //HtmlGenericControl inp = new HtmlGenericControl("input");
                //inp.Attributes["name"] = "flexRadioDefault";
                //inp.Attributes["value"] = "flexRadioDefault1";
                //inp.Attributes["type"] = "radio";
                //inp.Attributes["class"] = "form-check-input appearance-none rounded-full h-4 w-4 border border-gray-300 bg-white checked:border-4 checked:border-blue-600 focus:outline-none transition duration-200 mt-1 align-top bg-no-repeat bg-center bg-contain float-left mr-2 cursor-pointer";


                //HtmlGenericControl details = new HtmlGenericControl("p");
                //details.Attributes["class"] = "form-check-label inline-block text-gray-800 font-semibold";

                //HtmlGenericControl name = new HtmlGenericControl("span");


                //HtmlGenericControl contact = new HtmlGenericControl("span");

                //HtmlGenericControl address = new HtmlGenericControl("p");
                //address.Attributes["class"] = "mt-2 font-xs";
                //address.Style.Add("font-size", "10px");

                //Button btnDeliver = new Button();
                //btnDeliver.Attributes["class"] = "bg-teal-600 mt-4 shadow-inner border-2 border-teal-700 shadow-black hover:bg-teal-700 text-white font-bold py-2 px-6 border border-violet-700 rounded inline-block";


                //Button btnRemove = new Button();
                //btnRemove.Attributes["class"] = " inline-block shadow-inner shadow-black bg-transparent hover:bg-amber-300 text-amber-400 font-semibold hover:text-white px-6 py-2 border-2 border-amber-700 hover:border-transparent rounded";

                //details.Controls.Add(name);
                //details.Controls.Add(contact);
                //addresses.Controls.Add(details);
                //addresses.Controls.Add(address);
                //addresses.Controls.Add(btnDeliver);
                //addresses.Controls.Add(btnRemove);
                
            //}
        }
        //private void btnDecrease_ServerClick(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt32(Quantity.Value) > 1)
        //    {
        //        Quantity.Value = (Convert.ToInt32(Quantity.Value) - 1).ToString();
        //    }
        //}
        //private void btnIncrease_ServerClick(object sender, EventArgs e)
        //{
        //    Quantity.Value=(Convert.ToInt32(Quantity) + 1).ToString();
        //}
        private void btnDeliver_Click(object sender, EventArgs e)
        {
            OrderSummary.Style.Add(HtmlTextWriterStyle.Display, "flex");
        }
        private void GetOrderSummery()
        {
           DataTable dt= bll.GetProductDetailsUsingIdBll(ProductId);
           foreach (DataRow dr in dt.Rows)
           {
               txtFlowerName.InnerHtml = dr["name"].ToString();
               txtActualPrice.InnerHtml = dr["actualPrice"].ToString();
               txtDiscount.InnerHtml = dr["discount"].ToString();
               txtEffectivePrice.InnerHtml = dr["effectivePrice"].ToString();
               imgSummery.Attributes["src"] = "data:image/webp;base64," + dr["image"].ToString();
           }
        }

        protected void btnSaveAndDeliver_Click1(object sender, EventArgs e)
        {
            bool result = bll.InsertUserAddressBll(UserId, inputFullAddress.Value, inputLandMark.Value, InputCity.Value, Convert.ToInt32(inputPinCode.Value), inputPhone1.Value, inputPhone2.Value, InputName.Value);
            if (result)
            {
                //deliver1.Attributes["onclick"] = "showOrderSummary('OrderSummary')";
                newAddress.Style.Add(HtmlTextWriterStyle.Display, "none");
                OrderSummary.Style.Add(HtmlTextWriterStyle.Display, "flex");
                GetFullProductDetails();

            }
            else
            {
                Response.Redirect("./ViewDetailsUnderMain.aspx");
            }
        }

        //protected void btnDeliver1_Click(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        divOrderSummary.Visible = false;
        //    }
        //    else
        //    {
        //        divOrderSummary.Visible = true;
        //    }
        //}
    }
}
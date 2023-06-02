using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Flower_Project
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //btnEdit.Attributes["href"] = "./EditAndDeleteDetails.aspx";
            btnRemove.ServerClick +=new EventHandler(btnEdit_ServerClick);
        }
        private void btnEdit_ServerClick(object sender,EventArgs e)
        {
            Response.Redirect("./EditAndDeleteDetails.aspx");
        }
    }
}
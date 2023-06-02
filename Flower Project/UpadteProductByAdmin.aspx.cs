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
    public partial class WebForm2 : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllData();
        }
        private void GetAllData()
        {
            DataTable dt = bll.GetAllPeoductDetailBLL();
            GridView1.DataSource = dt;

            GridView1.DataBind();
        }
    }
}
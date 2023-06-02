using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DataAccessLayer
    
{
    class SlideShow:Product
    {
        public string SlideName { get; set; }
        public byte[] SlideImage { get; set; }
        public string SlideUrl { get; set; }
        public int IsDefaultImage { get; set; }
        public DateTime OfferStartDate { get; set; }
        public DateTime OfferEndDate { get; set; }
        
         public bool InsertSlideDefaultData()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertSlideOfferData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@slideName",SlideName);
                cmd.Parameters.AddWithValue("@slideImage", SlideImage);
                cmd.Parameters.AddWithValue("@slideURL", SlideUrl);
                cmd.Parameters.AddWithValue("@IsDefaultImage", IsDefaultImage);

                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    return true;
                }
                return false;

            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
         public bool InsertSlideOfferData()
         {
             string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
             SqlConnection con =null;
             try
             {
                 con = new SqlConnection(cs);
                 SqlCommand cmd = new SqlCommand("spInsertSlideOfferData", con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@slideName", SlideName);
                 cmd.Parameters.AddWithValue("@slideImage", SlideImage);
                 cmd.Parameters.AddWithValue("@slideURL", SlideUrl);
                 cmd.Parameters.AddWithValue("@offerStartDate", OfferStartDate);
                 cmd.Parameters.AddWithValue("@offerEndDate", OfferEndDate);
                 con.Open();
                 int rows = cmd.ExecuteNonQuery();
                 if (rows > 0)
                 {
                     return true;
                 }
                 return false;
             }
             catch
             {
                 return false;
             }
             finally
             {
                 con.Close();
             }
         }
    }
}

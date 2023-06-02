using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataAccessLayer
{
    public class InsertProductDetails : ProductDefaultImage
    {
        
        Guid AdminId = Guid.NewGuid();
        Guid InsertProductImageId = Guid.NewGuid();
        Guid InsertProductId = Guid.NewGuid();
        public int ProductCount { get; set; }
        public bool InsertProduct()
        {
            InsertProductDetails ins = new InsertProductDetails();
             string cs=ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
           
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertProductDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@productImageId", InsertProductImageId);
                cmd.Parameters.AddWithValue("@isDefaultImage", IsDefaultImage);
                cmd.Parameters.AddWithValue("@adminId", AdminId);
                cmd.Parameters.AddWithValue("@productId", InsertProductId);
                cmd.Parameters.AddWithValue("@productTitleOrName", ProductNameOrTitle);
                cmd.Parameters.AddWithValue("@productDescription", ProductDescription);
                cmd.Parameters.AddWithValue("@glitterCoated", GilterCoated);
                cmd.Parameters.AddWithValue("@totalLength", TotalLength);
                cmd.Parameters.AddWithValue("@otherDimension", OtherDimensions);
                cmd.Parameters.AddWithValue("@brandName", BrandName);
                cmd.Parameters.AddWithValue("@modelNumber", ModelNumber);
                cmd.Parameters.AddWithValue("@productType", ProductType);
                cmd.Parameters.AddWithValue("@collectionType", CollectionType);
                cmd.Parameters.AddWithValue("@productColor", ProductColor);
                cmd.Parameters.AddWithValue("@productShade", ProductShade);
                cmd.Parameters.AddWithValue("@productFragrance", ProductFragnance);
                cmd.Parameters.AddWithValue("@productMaterial", ProductMaterial);
                cmd.Parameters.AddWithValue("@productOccasionType", ProductOccasionType);
                cmd.Parameters.AddWithValue("@actualPrice", ActualPrice);
                cmd.Parameters.AddWithValue("@discountPercentage", DiscountPercentage);
                cmd.Parameters.AddWithValue("@effectivePrice", EffectivePrice);
                cmd.Parameters.AddWithValue("@vaseIncluded", VaseIncluded);
                cmd.Parameters.AddWithValue("@vaseMaterial", VaseMaterial);
                cmd.Parameters.AddWithValue("@productRegistrationDate", ProductRegistrationDate);

                con.Open();

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.StackTrace);
                return false;
            }
            finally
            {
                con.Close();
            }

        }
       
    }
}

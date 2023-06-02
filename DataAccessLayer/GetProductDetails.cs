using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.IO;

namespace DataAccessLayer
{
    public class GetProductDetails : ProductDefaultImage
    {
        public string UserId { get; set; }
       
        public DataTable GetRelatedProducts()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("effectPrice");
            dt.Columns.Add("image");
            dt.Columns.Add("discount");
            dt.Columns.Add("actual");
            dt.Columns.Add("name");
            dt.Columns.Add("id");
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("spGetProductsUsingColor", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@color", ProductColor);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["name"] = sdr["productTittleOrName"];
                        dr["effectPrice"] = sdr["effectivePrice"];
                        dr["discount"] = sdr["discountPercentage"];
                        dr["actual"] = sdr["actualPrice"];
                        dr["image"] = Convert.ToBase64String((byte[])sdr["isDefaultImage"]);
                        dr["id"] = sdr["productId"];
                        dt.Rows.Add(dr);
                    }

                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

            }
            return dt;
        }

        public DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("effectPrice");
            dt.Columns.Add("image");
            dt.Columns.Add("discount");
            dt.Columns.Add("actual");
            dt.Columns.Add("name");
            dt.Columns.Add("id");
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand("spGetProductDetailsHomepage", con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            DataRow dr = dt.NewRow();

                            dr["name"] = sdr["productTittleOrName"];
                            dr["effectPrice"] = sdr["effectivePrice"];
                            dr["discount"] = sdr["discountPercentage"];
                            dr["actual"] = sdr["actualPrice"];
                            dr["image"] = Convert.ToBase64String((byte[])sdr["isDefaultImage"]);
                            dr["id"] = sdr["productId"];
                            dt.Rows.Add(dr);
                        }
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                        
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            return dt;
        }
        public DataTable GetProductUsingCategory()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("effectPrice");
            dt.Columns.Add("image");
            dt.Columns.Add("discount");
            dt.Columns.Add("actual");
            dt.Columns.Add("name");
            dt.Columns.Add("id");
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("GetProductByCatagory", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productType", ProductType);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["name"] = sdr["productTittleOrName"];
                        dr["effectPrice"] = sdr["effectivePrice"];
                        dr["discount"] = sdr["discountPercentage"];
                        dr["actual"] = sdr["actualPrice"];
                        dr["image"] = Convert.ToBase64String((byte[])sdr["isDefaultImage"]);
                        dr["id"] = sdr["productId"];
                        dt.Rows.Add(dr);
                    }

                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

            }
            return dt;
        }
        public DataTable GetProductCategory()
        {
            DataTable d = new DataTable();
            d.Columns.Add("imageCatagory");
            d.Columns.Add("type");
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand("spGetProductCategory", con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            DataRow dr = d.NewRow();
                            dr["imageCatagory"] = Convert.ToBase64String((byte[])sdr["isDefaultImage"]);
                            dr["type"] = (sdr["productType"].ToString());
                            d.Rows.Add(dr);
                        }

                    }
                    catch
                    {
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            return d;
        }
        public DataTable GetProductDetailsUsingId()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TitleOrName");
            dt.Columns.Add("Description");
            dt.Columns.Add("actualPrice");
            dt.Columns.Add("effectivePrice");
            dt.Columns.Add("discount");
            dt.Columns.Add("name");
            dt.Columns.Add("image");
            dt.Columns.Add("productType");
            dt.Columns.Add("collectionType");
            dt.Columns.Add("color");
            dt.Columns.Add("shade");
            dt.Columns.Add("fragrance");
            dt.Columns.Add("occassion");
            dt.Columns.Add("gliterCoated");
            dt.Columns.Add("vaseMaterial");
            dt.Columns.Add("vaseIncluded");
            dt.Columns.Add("productMaterial");
            dt.Columns.Add("length");
            dt.Columns.Add("modelName");
            dt.Columns.Add("modelNumber");
            dt.Columns.Add("flowerType");

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("spGetProductDetailsById", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productId", ProductId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["TitleOrName"] = sdr["productTittleOrName"];
                        dr["Description"] = sdr["productDescription"];
                        dr["actualPrice"] = sdr["actualPrice"];
                        dr["effectivePrice"] = sdr["effectivePrice"];
                        dr["discount"] = sdr["discountPercentage"];
                        dr["name"] = sdr["brandName"];
                        dr["image"] = Convert.ToBase64String((byte[])sdr["isDefaultImage"]);
                        dr["productType"] = sdr["productType"];
                        dr["collectionType"] = sdr["collectionType"];
                        dr["color"] = sdr["productColor"];
                        dr["shade"] = sdr["productShade"];
                        dr["fragrance"] = sdr["productFragrance"];
                        dr["occassion"] = sdr["productColor"];
                        dr["gliterCoated"] = sdr["glitterCoated"];
                        dr["vaseIncluded"] = sdr["vaseIncluded"];
                        dr["vaseMaterial"] = sdr["vaseMaterial"];
                        dr["productMaterial"] = sdr["productMaterial"];
                        dr["length"] = sdr["totalLength"];
                        dr["modelName"] = sdr["brandName"];
                        dr["modelNumber"] = sdr["modelNumber"];
                        dr["flowerType"] = sdr["productType"];

                        dt.Rows.Add(dr);

                    }

                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return dt;
            }

        }

        //public DataTable GetSearchingProduct()
        //{
        //    DataTable dt = new DataTable();

        //    dt.Columns.Add("effectPrice");
        //    dt.Columns.Add("image");
        //    dt.Columns.Add("discount");
        //    dt.Columns.Add("actual");
        //    dt.Columns.Add("name");
        //    dt.Columns.Add("type");
        //    dt.Columns.Add("id");
        //    string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(cs))
        //    {

        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand("spSearchEngine", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@productType", ProductType);
        //            con.Open();
        //            SqlDataReader sdr = cmd.ExecuteReader();
        //            while (sdr.Read())
        //            {
        //                DataRow dr = dt.NewRow();
        //                dr["name"] = sdr["productTittleOrName"];
        //                dr["effectPrice"] = sdr["effectivePrice"];
        //                dr["discount"] = sdr["discountPercentage"];
        //                dr["actual"] = sdr["actualPrice"];
        //                dr["image"] = Convert.ToBase64String((byte[])sdr["isDefaultImage"]);
        //                dr["type"] = sdr["productType"];
        //                dr["id"] = sdr["productId"];
        //                dt.Rows.Add(dr);
        //            }

        //        }
        //        catch
        //        {
        //        }
        //        finally
        //        {
        //            con.Close();
        //        }

        //    }
        //    return dt;
        //}

        public List<string> GetSearchingProduct()
        {
            List<string> products = new List<string>();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
               
                try
                {
                    SqlCommand cmd = new SqlCommand("spSearchEngine", con);
                    cmd.Parameters.AddWithValue("@ch", ProductType);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        products.Add(rdr["productType"].ToString());
                    }
                   
                
                }

                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return products;
            }
        }

        //Methode to Get Product List From DataBase
        public DataTable FillGrid()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection con=new SqlConnection(cs))
            {
            DataTable dt = new DataTable();
            try
            {
                //SqlCommand cmd = new SqlCommand("spGetAllProductDetails", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //con.Open();

                //SqlDataReader rdr = cmd.ExecuteReader();
                //while (rdr.Read())
                //{
 
                //}

                SqlDataAdapter sda = new SqlDataAdapter("spGetAllProductDetails", con);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return dt;
        }
        }

        public DataTable BuyNowUserDetails()
        {
            DataTable dt = new DataTable();

            
            dt.Columns.Add("delivery");
            dt.Columns.Add("addressLine");
            dt.Columns.Add("landMark");
            dt.Columns.Add("cityOrVillage");
            dt.Columns.Add("phoneNumber");

            dt.Columns.Add("pinCode");
            //dt.Columns.Add("productId");
      
           
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("spGetAddressByUserId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", UserId);
                   
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DataRow dr = dt.NewRow();
                        
                        dr["delivery"] = sdr["deliveryToName"];
                        dr["addressLine"] = sdr["addressLine"];
                        dr["landMark"] = sdr["landMark"];
                        dr["cityOrVillage"] = sdr["cityOrVillage"];
                        dr["phoneNumber"] = sdr["primaryPhoneNumber"];
                        dr["pinCode"] = sdr["pinCode"];
                        dt.Rows.Add(dr);
                    }

                }
                catch
                {
                }
                finally
                {
                    con.Close();
                }

            }
            return dt;
        }
        public DataTable BuyNowProductDetails()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("effectPrice");
            dt.Columns.Add("discount");
            dt.Columns.Add("actualPrice");

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("spGetPriceDetailsByProductId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productId", ProductId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DataRow dr = dt.NewRow();

                        dr["effectPrice"] = sdr["effectivePrice"];
                        dr["discount"] = sdr["discountPercentage"];
                        dr["actualPrice"] = sdr["actualPrice"];
                        dt.Rows.Add(dr);
                    }

                }
                catch
                {
                }
                finally
                {
                    con.Close();
                }

            }
            return dt;
        }
        public DataSet GetBuyNowUserDetailsByAddressId()
        {
            //DataTable dt=new DataTable();
            DataSet ds=new DataSet();
            //dt.Columns.Add("delivery");
            //dt.Columns.Add("addressLine");
            //dt.Columns.Add("landMark");
            //dt.Columns.Add("cityOrVillage");
            //dt.Columns.Add("phoneNumber");
            //dt.Columns.Add("pinCode");
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spGetAddressByUserId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    //SqlDataReader rdr=cmd.ExecuteReader();
                    sda.Fill(ds);
                   // DataRow dr = dt.NewRow();

                    return ds;

                }
                catch
                {
                }
                finally
                { 
                }
                return ds;
            }
        }
        public DataTable GetLoginCardinality()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("userName");
            dt.Columns.Add("phoneNumber");
           

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("spGetUserNameAndPhoneNumber", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DataRow dr = dt.NewRow();

                        dr["userName"] = sdr["userName"];
                        dr["phoneNumber"] = sdr["phoneNumber"];
                     
                        dt.Rows.Add(dr);
                    }

                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }

            }
            return dt;
        }

        public DataTable GetSlideShareDetails()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("userName");
            dt.Columns.Add("phoneNumber");


            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spGetUserNameAndPhoneNumber", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DataRow dr = dt.NewRow();

                        dr["userName"] = sdr["userName"];
                        dr["phoneNumber"] = sdr["phoneNumber"];

                        dt.Rows.Add(dr);
                    }

                }
                catch
                {
                }
                finally
                {
                    con.Close();
                }

            }
            return dt;
        }

        public DataTable GetAddToCartProduct()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TitleOrName");
            dt.Columns.Add("actualPrice");
            dt.Columns.Add("effectivePrice");
            dt.Columns.Add("discount");
            dt.Columns.Add("image");
            dt.Columns.Add("collectionType");
            dt.Columns.Add("length");
            dt.Columns.Add("productCount");
            dt.Columns.Add("productId");
           

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("spGetAddToCartDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["TitleOrName"] = sdr["productTittleOrName"];
                        dr["actualPrice"] = sdr["actualPrice"];
                        dr["effectivePrice"] = sdr["effectivePrice"];
                        dr["discount"] = sdr["discountPercentage"];
                        dr["image"] = Convert.ToBase64String((byte[])sdr["isDefaultImage"]);
                        dr["collectionType"] = sdr["collectionType"];
                        dr["productCount"] = sdr["productCount"];
                        dr["length"] = sdr["totalLength"];
                        dr["productId"] = sdr["productId"].ToString();

                        dt.Rows.Add(dr);

                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return dt;
            }

        }
        public int GetCartRows()
        {
            DataTable dt = new DataTable();
            int rows = 0;
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("spGetCartRows", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    cmd.Parameters.AddWithValue("@productId",ProductId);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                   
                        dt.Load(sdr);
                        rows = dt.Rows.Count;
                   

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return rows;
            }

        }


        public bool DeleteCartProducts()
        {
           
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("spRemoveProductFromCart", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productId", ProductId);
                    con.Open();
                    int rowEffected = cmd.ExecuteNonQuery();

                    if (rowEffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
               
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class UserSection : UserDetails
    {
        public string GetUserId { get; set; }
        public string GetProductId { get; set; }
        public int ProductCount { get; set; }
        //-----------------------------User Registration--------------------------------
        public bool UserRegister()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spInsertRegistration", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    cmd.Parameters.AddWithValue("@userName", UserName);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@phoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@password", Password);
                    cmd.Parameters.AddWithValue("@dateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@ipAddress", IpAddress);
                    cmd.Parameters.AddWithValue("@registrationDateTime", RegistrationDate);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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

        public DataTable CheckUserLogin()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("spUserLogin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@UserPassword", Password);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        DataRow dr = dt.NewRow();

                        dr["id"] = sdr["userId"];
                        dr["name"] = sdr["userName"];

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
        public bool InsertUserAddress()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("spInsertAddress", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", ExistingId);
                    cmd.Parameters.AddWithValue("@addressId", AddressId);
                    cmd.Parameters.AddWithValue("@addressLine", AddressLine);
                    cmd.Parameters.AddWithValue("@landMark", LandMark);
                    cmd.Parameters.AddWithValue("@cityOrVillage", CityOrVillage);
                    cmd.Parameters.AddWithValue("@pinCode", Pincode);
                    cmd.Parameters.AddWithValue("@primaryPhoneNumber", PrimaryPhoneNumber);
                    cmd.Parameters.AddWithValue("@secondaryPhoneNumber", SecondaryPhoneNumber);
                    cmd.Parameters.AddWithValue("@deliveryToName", DeliveryToName);
                    cmd.Parameters.AddWithValue("@isPrimaryAddress",IsPrimaryAddress);
                    cmd.Parameters.AddWithValue("@isSecondaryAddress",IsSecondaryAddress);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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
         public bool InsertProductToCart()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("spInsertCartProducts", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userId", GetUserId);
                cmd.Parameters.AddWithValue("@productId", GetProductId);
                cmd.Parameters.AddWithValue("@productCount", ProductCount);
               

                con.Open();

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
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

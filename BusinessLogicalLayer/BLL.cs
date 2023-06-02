using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicalLayer
{
    public class BLL
    {
        InsertProductDetails productdetails = new InsertProductDetails();
        GetProductDetails getProduct = new GetProductDetails();
        UserSection section = new UserSection();

        //-----------------Insert Product To Product Cart Table----------------------

        public bool InsertProductToCartBll(string productId,string userId,int productCount)
        {
            section.GetProductId = productId;
            section.GetUserId = userId;
            section.ProductCount = productCount;


            return section.InsertProductToCart();
        }
        //InsertUserAddress address = new InsertUserAddress();
        //InsertUserDetails details = new InsertUserDetails();

        //public bool InsertAddressBll(string addressLine,string landMark,string cityOrVillege,int pinCode,string primaryPhoneNumber, string secondaryPhoneNumber,string deliveryToName,int isPrimaryAddress,int isSecondaryAddress)

        //{
        //    address.AddressLine = addressLine;
        //    address.LandMark = landMark;
        //    address.CityOrVillege = cityOrVillege;
        //    address.PinCode = pinCode;
        //    address.PrimaryPhoneNumber = primaryPhoneNumber;
        //    address.SecondaryPhoneNumber = secondaryPhoneNumber;
        //    address.DeliveryToName = deliveryToName;
        //    address.IsPrimaryAddress = isPrimaryAddress;
        //    address.IsSecondaryAddress = isSecondaryAddress;

        //    return address.InsertAddress();

        //}
        //public bool UserRegistration(string userName,string email,string phoneNumber,string password,DateTime dateOfBirth,DateTime registrationDate, string gender)
        //{
        //    details.UserName = userName;
        //    details.Email = email;
        //    details.PhoneNumber=phoneNumber;
        //    details.Password = password;
        //    details.DateOfBirth = dateOfBirth;
        //    details.RegistrationDateTime = registrationDate;
        //    details.Gender = gender;

        //    return details.UserRegistration();
        //}

        //-------------------------Insert Product Into databse by admin----------------------------
        public bool InsertProductBll(byte[] isDefaultImage, string productNameOrTitle, string ProductDescription, string gilterCoated, string totalLength, string otherDimensions, string brandName, string modelNumber, string productType, string collectionType, string productColor, string productShade, string productFragnance, string productMaterial, string productOccasionType, string actualPrice, string discountPercentage, string effectivePrice, string vaseIncluded, string vaseMaterial, DateTime ProductRegistrationDate)
        {
            productdetails.IsDefaultImage = isDefaultImage;
            productdetails.ProductNameOrTitle = productNameOrTitle;
            productdetails.ProductDescription = ProductDescription;
            productdetails.GilterCoated = gilterCoated;
            productdetails.TotalLength = totalLength;
            productdetails.OtherDimensions = otherDimensions;
            productdetails.BrandName = brandName;
            productdetails.ModelNumber = modelNumber;
            productdetails.ProductType = productType;
            productdetails.CollectionType = collectionType;
            productdetails.ProductColor = productColor;
            productdetails.ProductShade = productShade;
            productdetails.ProductFragnance = productFragnance;
            productdetails.ProductMaterial = productMaterial;
            productdetails.ProductOccasionType = productOccasionType;
            productdetails.ActualPrice = actualPrice;
            productdetails.DiscountPercentage = discountPercentage;
            productdetails.EffectivePrice = effectivePrice;
            productdetails.VaseIncluded = vaseIncluded;
            productdetails.VaseMaterial = vaseMaterial;
            productdetails.ProductRegistrationDate = ProductRegistrationDate;


            return productdetails.InsertProduct();
        }

        //Get All Products
        public DataTable GetAllProductsBll()
        {
            try
            {

                return getProduct.GetAllProducts();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //--------------------Get products catagory---------------------------------
        public DataTable GetProductCategoryBll()
        {
            return getProduct.GetProductCategory();
        }

        //---------------------Get Products using catagory--------------------------
        public DataTable GetProductUsingCategoryBll(string productType)
        {
            getProduct.ProductType = productType;
            try
            {
                return getProduct.GetProductUsingCategory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //---------------------Get Product full details------------------------
        public DataTable GetProductDetailsUsingIdBll(string id)
        {
            getProduct.ProductId = id;
            try
            {
                return getProduct.GetProductDetailsUsingId();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //--------------------Get related products--------------------------

        public DataTable GetRelatedProductsBll(string color)
        {
            getProduct.ProductColor = color;
            try
            {
                return getProduct.GetRelatedProducts();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //-------------------Search Products---------------------------
        public List<string> GetSearchingProductBll(string productType)
        {
            try
            {
                getProduct.ProductType = productType;

                return getProduct.GetSearchingProduct();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //----------------------New user registration---------------------------

        public bool UserRegisterBll(string name,string email,string phoneNumber,string password,DateTime dateOfBirth,string ipAddress,DateTime registrationDate,string gender)
        {
            section.UserName = name;
            section.Email = email;
            section.PhoneNumber = phoneNumber;
            section.Password = password;
            section.DateOfBirth = dateOfBirth;
            section.IpAddress = ipAddress;
            section.RegistrationDate = registrationDate;
            section.Gender = gender;
            
            return section.UserRegister();
        }
        // --------------------Check User Login-------------------------------
        public DataTable CheckUserLoginBll(string email, string password)
        {
            section.Email = email;
            section.Password = password;
            return section.CheckUserLogin();
        }

        //----------------------Get All Products into Admin section---------------------
        public DataTable GetAllPeoductDetailBLL()
        {
            return getProduct.FillGrid();
        }

        public DataTable BuyNowUserDetailsBll(string userId)
        {
            getProduct.UserId = userId;
            return getProduct.BuyNowUserDetails();
        }
        public DataTable BuyNowProductDetailsBll(string productId)
        {
            getProduct.ProductId = productId;
            return getProduct.BuyNowProductDetails();
        }
        public DataSet GetBuyNowUserDetailsByAddressIdBll(string userId)
        {
            getProduct.ProductId = userId;
            return getProduct.GetBuyNowUserDetailsByAddressId();
        }
        public DataTable GetLoginCardinalityBll(string userId)
        {
            getProduct.UserId = userId;
            return getProduct.GetLoginCardinality();
        }
        public bool InsertUserAddressBll(string id,string addressLine,string landMark,string cityOrVillage,int pincode,string primaryPhoneNumber,string secondaryPhoneNumber,string deliveryToName)
        {
            section.ExistingId = id;
            section.AddressLine = addressLine;
            section.LandMark = landMark;
            section.CityOrVillage = cityOrVillage;
            section.Pincode = pincode;
            section.IsPrimaryAddress = 1;
            section.IsSecondaryAddress = 0;
            section.PrimaryPhoneNumber = primaryPhoneNumber;
            section.SecondaryPhoneNumber = secondaryPhoneNumber;
            section.DeliveryToName = deliveryToName;

            return section.InsertUserAddress();
        }
        

        //----------------------------Get AddToCart Details------------------------
        public DataTable GetAddToCartProductBll(string userId)
        {
            getProduct.UserId = userId;
            return getProduct.GetAddToCartProduct();
        }


        public int GetCartRowsBll(string id,string productId)
        {
            getProduct.ProductId = productId;
            getProduct.UserId = id;
            int rows = getProduct.GetCartRows();
            return rows;
        }

        public bool DeleteCartProductsBll(string productId)
        {
            getProduct.ProductId = productId;

            return getProduct.DeleteCartProducts();
        }
    }
}

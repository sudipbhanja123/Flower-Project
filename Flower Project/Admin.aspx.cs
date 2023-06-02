using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using BusinessLogicalLayer;

namespace Flower_Project
{

    public partial class Admin : System.Web.UI.Page
    {
        BLL bll = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadFile(object sender, EventArgs e)
        {
        }
        protected void btnSave_onclick(object sender,EventArgs e)
        {
            
        }
        private void InsertProduct()
        {
            DateTime registrationDate=DateTime.Now;
            string vaseIncluded=null;
            string productMaterial=null;
            string glitterCoated=null;
            string vaseMaterial=null;

            if(radioGliterYes.Checked)
            {
                glitterCoated = "Yes";
            }
            else if (radioGliterNo.Checked)
            {
                glitterCoated = "No";
            }

            if (radioProductMaterialPlastic.Checked)
            {
                productMaterial = "Plastic";
            }
            else if (radioProductMaterialNatural.Checked)
            {
                productMaterial = "Natural";
            }
            else if (radioProductMaterialMixed.Checked)
            {
                productMaterial = "Mixed";
            }

            if (radioVaseIncludeYes.Checked)
            {
                vaseIncluded = "Yes";
            }
            else if (radioVaseIncludeNo.Checked)
            {
                vaseIncluded = "No";
            }

            if (radioVaseMaterialPlastic.Checked)
            {
                vaseMaterial = "Plastic";
            }
            else if (radioVaseMaterialSoil.Checked)
            {
                vaseMaterial = "Soil";
            }
            else if (radioVaseMaterialGlass.Checked)
            {
                vaseMaterial = "Glass";
            }
            else if (radioVaseMaterialMetal.Checked)
            {
                vaseMaterial = "Material";
            }
            else 
            
            {
                vaseMaterial = "null";
            }



            HttpPostedFile postedFile = imgUpload.PostedFile;
            string filename = Path.GetFileName(postedFile.FileName);
            string fileExtention = Path.GetExtension(filename);

            Stream st = postedFile.InputStream;
            BinaryReader br = new BinaryReader(st);
            byte[] image = br.ReadBytes((int)st.Length);
            


            bool result = bll.InsertProductBll(image, inpProductName.Value, comment.Value, glitterCoated, inpLength.Value, inpOtherDimensions.Value, inpBrandName.Value, inpModelNumber.Value, inpFlowerType.Value, inpCollectionType.Value, inpProductColor.Value, inpProductShade.Value, inpProductFragnance.Value, productMaterial, inpOccasionType.Value, inpActualPrice.Value, inpDiscountedPercentage.Value, inpEffectivePrice.Value, vaseIncluded, vaseMaterial, registrationDate);
            if (result)
            {
                Response.Write("Successfull");
               
                
            }
            else
            {
                Response.Write("Not");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            InsertProduct();
            ClearInput();
        }
        private void ClearInput()
        {
            inpProductName.Value = "";
            comment.Value = "";
            inpBrandName.Value = "";
            inpModelNumber.Value = "";
            inpFlowerType.Value = "";
            inpProductColor.Value = "";
            inpProductShade.Value = "";
            inpProductFragnance.Value = "";
            radioProductMaterialPlastic.Checked = false;
            radioProductMaterialNatural.Checked = false;
            radioProductMaterialMixed.Checked = false;

            inpOccasionType.Value = "";
            inpLength.Value = "";
            inpOtherDimensions.Value = "";
            inpActualPrice.Value = "";
            inpDiscountedPercentage.Value = "";
            inpEffectivePrice.Value = "";
            radioGliterYes.Checked = false;
            radioGliterNo.Checked = false;
            radioVaseIncludeYes.Checked = false;
            radioVaseIncludeNo.Checked = false;
            radioVaseMaterialPlastic.Checked = false;
            radioVaseMaterialMetal.Checked = false;
            radioVaseMaterialSoil.Checked = false;
            radioVaseMaterialGlass.Checked = false;
           

        }
    }
}
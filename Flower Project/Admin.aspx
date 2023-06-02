<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Flower_Project.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <!-- Latest compiled and minified CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">

    <!-- Latest compiled JavaScript -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    <style>

    </style>
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >

  <%--<div class="btn-group" role="group" aria-label="Basic radio toggle button group">
       <input type="radio" class="btn-check" name="btnradio" id="btnradio1" autocomplete="off" checked>
       <label class="btn btn-outline-primary px-5 border rounded-0 shadow-none" for="btnradio1">Flower</label>

       <input type="radio" class="btn-check" name="btnradio" id="btnradio2" autocomplete="off" >
       <label class="btn btn-outline-primary px-5 border rounded-0 shadow-none " for="btnradio2">Cake</label>
  </div>--%>

  <!-- Product Details-->
<div class="card border border-1  ">
<button type="button" class="btn text-primary  w-100 rounded-0 shadow-none d-flex justify-content-start" data-toggle="collapse" data-target=".Demo" id="btnProductDetails" runat="server"> Product Details</button>
<div  class="collapse Demo ">
 <div class="card-body container-fluid">
   <input type="text" class="form-control " placeholder="Product Name" runat="server" id="inpProductName" required>
 <textarea class="form-control mt-2 " rows="4" id="comment" name="text" placeholder="Product Description" runat="server"></textarea>
   </div>
  </div>
<!--   General Features -->
  <button type="button" class="btn text-primary   w-100 rounded-0 shadow-none d-flex justify-content-start" data-toggle="collapse" data-target=".GeneralFeatures" id="btnGeneralFeatures" runat="server"> General Features</button>
<div  class="collapse GeneralFeatures  ">
 <div class="card-body container-fluid">
   <input type="text" class="form-control mt-3" placeholder="Brand Name"  id="inpBrandName" runat="server" required>
    <input type="text" class="form-control mt-3 " placeholder="Model Number" id="inpModelNumber" runat="server" required>
   <input type="text" class="form-control mt-3 " placeholder="Flower Type" id="inpFlowerType" runat="server" required>
    <form >
               <label for="" class="form-label ps-2 mt-3">Collection Type</label>
               <select class="form-select" id="inpCollectionType" runat="server" required>
                   <option>Flower</option>
                   <option>Cake</option>
                   <option>Chocolate</option>
                   <option>Gift</option>
                   </select>
        </form>
   <input type="text" class="form-control mt-3 " placeholder="product Color" runat="server" id="inpProductColor" required>
   <input type="text" class="form-control mt-3 " placeholder="product Shade" runat="server" id="inpProductShade" required>
   <input type="text" class="form-control mt-3 " placeholder="Product Fragrance" runat="server" id="inpProductFragnance" required>
   <div class="container-fluid mt-3">
   <label for="" class="form-label">Product Material</label><br>
   <div class="form-check form-check-inline ps-3">
            <input class="form-check-input" type="radio" name="MaterialinlineRadio" id="radioProductMaterialPlastic" value="option1" runat="server" >
          <label class="form-check-label" for="radioProductMaterialPlastic">Plastic</label>
    </div>
   <div class="form-check form-check-inline">
         <input class="form-check-input" type="radio" name="MaterialinlineRadio" id="radioProductMaterialNatural" value="option2" runat="server" >
         <label class="form-check-label" for="radioProductMaterialNatural">Natural</label>
   </div>
      <div class="form-check form-check-inline">
         <input class="form-check-input" type="radio" name="MaterialinlineRadio" id="radioProductMaterialMixed" value="option3" runat="server" >
         <label class="form-check-label" for="radioProductMaterialMixed">Mixed</label>
     </div> </br>
   </div>
     <div class="container-fluid mt-3  px-0">
       <label for="" class="form-label ps-2">Occasion Type</label>
        <input type="text" class="form-control mt-2  " placeholder="Occasion Type"  id="inpOccasionType" runat="server" required>
       </div>
   </div>
    </div>


<!--   Dimensions -->
  <button type="button" class="btn text-primary  w-100 rounded-0 shadow-none d-flex justify-content-start" data-toggle="collapse" data-target=".Dimensions" id="btnDimension" runat="server"> Dimensions</button>
<div  class="collapse Dimensions  ">
 <div class="card-body container-fluid">
   <input type="text" class="form-control " placeholder="Total length"  id="inpLength" runat="server" required>
    <input type="text" class="form-control mt-2 " placeholder="Other Dimensions" id="inpOtherDimensions" runat="server" required>
   </div>
</div>
<!-- Price -->
  <button type="button" class="btn text-primary w-100 rounded-0 shadow-none d-flex justify-content-start" data-toggle="collapse" data-target=".Price" id="btnPrice" runat="server"> Price</button>
<div  class="collapse Price  ">
 <div class="card-body container-fluid">
   <input type="text" class="form-control mt-2" placeholder="Actual Price" id="inpActualPrice" runat="server" required>
    <input type="text" class="form-control mt-2 " placeholder="Discount Percentage (%)" id="inpDiscountedPercentage" runat="server" required>
    <input type="text" class="form-control mt-2  " placeholder="Effective Price" id="inpEffectivePrice" runat="server" required> 
  </div>
</div>

<!-- Glitter Features -->

  <button type="button" class="btn  text-primary  w-100 rounded-0 shadow-none d-flex justify-content-start" data-toggle="collapse" data-target=".GlitterFeatures" runat="server" id="btnGlitterFeatures"> Glitter  Features</button>
<div  class="collapse GlitterFeatures  ">
 <div class="card-body container-fluid ">
     <div class="container-fluid  ">
        <label for="" class="form-label ">Glitter Coated</label><br>
          <div class="form-check form-check-inline ">
          <input class="form-check-input " type="radio" name="GlitterinlineRadio" id="radioGliterYes" value="option4" runat="server">
          <label class="form-check-label " for="radioGliterYes">Yes</label>
         </div>
         <div class="form-check form-check-inline ">
          <input class="form-check-input" type="radio" name="GlitterinlineRadio" id="radioGliterNo" value="option5" runat="server">
          <label class="form-check-label" for="radioGliterNo">No</label>
        </div>
   </div>
  </div>
  </div> 
<!-- Vase Features -->
     <button type="button" class="btn text-primary shadow-none rounded-0  d-flex justify-content-start" data-toggle="collapse" data-target=".VaseFeatures" runat="server" id="btnVaseFeatures"> Vase Features </button>
<div  class="collapse VaseFeatures  ">
 <div class="card-body container-fluid">
     <div class="container-fluid   ">
        <label for="" class="form-label ">Vase Included</label><br>
          <div class="form-check form-check-inline ">
          <input class="form-check-input " type="radio" name="vaseIncludeRadio" id="radioVaseIncludeYes" value="option6" runat="server">
          <label class="form-check-label " for="radioVaseIncludeYes">Yes</label>
         </div>
         <div class="form-check form-check-inline ">
          <input class="form-check-input" type="radio" name="vaseIncludeRadio" id="radioVaseIncludeNo" value="option7" runat="server">
          <label class="form-check-label" for="radioVaseIncludeNo">No</label>
        </div>
            </div>
       <div class="container-fluid  mt-3 ">
        <label for="" class="form-label ">Vase Material</label><br>
           
          <div class="form-check form-check-inline ">
          <input class="form-check-input " type="radio" name="VaseMaterialRadio" id="radioVaseMaterialPlastic" value="option8" runat="server">
          <label class="form-check-label " for="radioVaseMaterialPlastic">Palstic</label>
         </div>
         <div class="form-check form-check-inline ">
          <input class="form-check-input" type="radio" name="VaseMaterialRadio" id="radioVaseMaterialSoil" value="option9" runat="server">
          <label class="form-check-label" for="radioVaseMaterialSoil">Soil</label>
        </div>
         <div class="form-check form-check-inline ">
          <input class="form-check-input" type="radio" name="VaseMaterialRadio" id="radioVaseMaterialGlass" value="option10" runat="server">
          <label class="form-check-label" for="radioVaseMaterialGlass">Glass</label>
        </div>
         <div class="form-check form-check-inline ">
          <input class="form-check-input" type="radio" name="VaseMaterialRadio" id="radioVaseMaterialMetal" value="option11" runat="server">
          <label class="form-check-label" for="radioVaseMaterialMetal">Metal</label>
        </div>
   </div>
  </div>
  </div>
<!-- Images -->
  <button type="button" class="btn text-primary shadow-none rounded-0 d-flex justify-content-start" id="btnImage" data-toggle="collapse" data-target=".Images" runat="server"> Images </button>
  <div class="collapse Images">
     <div class=" card-body container-fluid">
     <input class="form-control form-control-sm d-flex flex-row-reverse" id="imgUpload" type="file" runat="server" required>
     </div>

  </div>
<!-- Save Button -->
<div class="container-fluid  pe-0 mt-2"> 
 <%-- <button class="btn btn-primary float-end px-4" type="button" runat="server" id="btnSave" onclick ="onclick()"> SAVE  </button>--%>
  
  <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click"  style="float:right;width:100px;background-color:#4B7BE5;color:white;border:0;border-radius:5px;font-size:20px;margin-right:10px;"/>  
</div>




</asp:Content>

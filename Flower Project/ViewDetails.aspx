 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewDetails.aspx.cs" Inherits="Flower_Project.ViewDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://fonts.googleapis.com/css2?family=Dancing+Script&family=IBM+Plex+Sans:wght@100&family=Josefin+Sans&family=Noto+Sans+JP:wght@300&family=Open+Sans:ital,wght@0,300;1,300&family=Poppins:wght@200;300&family=Raleway:wght@300&family=Roboto+Flex:opsz,wght@8..144,300;8..144,400&family=Roboto:wght@300&display=swap" rel="stylesheet">
    <script src="https://kit.fontawesome.com/5a660edc7c.js" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
  <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Dancing+Script&display=swap" rel="stylesheet">
<link href="https://fonts.googleapis.com/css2?family=Dancing+Script&family=IBM+Plex+Sans:wght@100&family=Josefin+Sans&family=Noto+Sans+JP:wght@300&family=Open+Sans:ital,wght@0,300;1,300&family=Poppins:wght@200&family=Raleway:wght@300&family=Roboto+Flex:opsz,wght@8..144,300;8..144,400&display=swap" rel="stylesheet">
<!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>

<!-- jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

<!-- Popper JS -->
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>

<!-- Latest compiled JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

 <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css">

 <link rel="Stylesheet" href="~/CSS/Details.css" />
</head>
<body>



    <form id="form1" runat="server">




        <div class="Header d-flex  justify-content-start mb-2 py-3 gap-3 align-items-center border border-1">
             
             <img src="https://thumbs.dreamstime.com/b/blossom-lily-lotus-flower-logo-template-illustration-design-vector-eps-178266262.jpg" class="img-fluid " alt="Responsive image" runat="server">
             <input type="text" id="txtSearch" placeholder="Search for products"  class="SearchProduct shadow-none rounded-0 form-control ms-5" style="width:65%;" runat="server"></input>
             <button class="btnSearch btn btn-default py-3 px-3" runat="server"><i class="bi bi-search" runat="server"></i></button>
             
             <i class="btnCart bi bi-cart " style="" runat="server"></i> 
                 <div class="dropdown">
                   <button class="btnAccount dropdown dropdown-toggle" data-toggle="dropdown" ><i class="bi bi-person-fill" runat="server"></i></button>
                   
                   <ul class="btnAccountItem dropdown-menu dropdown-menu-end p-0" runat="server">
                      <li><a class="dropdown-item" href="#" runat="server" id="profile"><span runat="server"><i class="bi bi-person-circle" runat="server"></i></span>Account</a></li>
                      <li><a class="dropdown-item" href="#" runat="server"><span runat="server"><i class="bi bi-book-half" runat="server"></i></span>Orders</a></li>
                      <li><a class="dropdown-item" href="#" runat="server"><span runat="server"><i class="bi bi-bell-fill" runat="server"></i></span>Notifications</a></li>
                      <li><a class="dropdown-item" href="#" runat="server" Id="aLogin"><span runat="server"><i class="bi bi-box-arrow-left" runat="server"></i></span></a></li>
                   </ul>
                 </div>
               <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
       </div>




    <div class="row g-4 m-0 p-0" runat="server" style="margin-top:70px !important;">
    <div class="col-lg-4" id="productimageDiv" runat="server">
    <div class='p-4 shadow' style="border-radius:12px; position:sticky;top:15%;">
    <div  style="height:;width:"100%">
        <img id="ProductImage" style="height:100%;width:100%" runat="server" class='img-fluid'>
        </div>
        <div class="w-100 " runat="server">
            <%--<div class="btnOfProduct btn flex" style="margin-right:5%;" id="btnBuyNow" runat="server">Buy Now</div>--%>
            <div class='row p-0 m-0'>
            <div class='col-6'>
            <asp:Button ID="btnBuyNow" runat="server" Text="Buy Now" 
                class="btn btn-primary w-100 py-3 fs-5"
                onclick="btnBuyNow_Click"/>
                </div>
                <div class='col-6'>
            <asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" 
                        class="btn btn-warning w-100 py-3 fs-5" onclick="btnAddToCart_Click"/>
            </div>
           <%-- <div class="btnOfProduct btn flex" style="background-color:#F8B400;margin-left:5%" id="btnAddToCart" runat="server">Add to Cart</div>--%>
        </div>
        </div>
        </div>
       
    </div>
    <div class="col-lg-8" runat="server">
    <div class='p-4 shadow' style="border-radius:12px;">
        <h1 id="ProductName" class="" runat="server"></h1>
        <label id="ProductEffectivePrice" runat="server"><i class="fa-solid fa-indian-rupee-sign" runat="server"><span id="EffectivePrice" runat="server"></span></i></label>
        <label id="ProductActualPrice" class="" runat="server"><i class="fa-solid fa-indian-rupee-sign" runat="server"><span id="ActualPrice" runat="server"></span></i></label>
        <label id="Percentage" class="" runat="server"><span id="PercentageOfDiscount" runat="server"></span>% off</label><br>
        <label id="Highlights" class="" runat="server">Highlights :
            <ul style="display: inline-block;margin-left: 20px;color: black;font-weight: 500;">
                <li>Type: <span id="lblType" runat="server"></span></li>
                <li>Vase Included: <span id="labelVaseIncludeStatus" runat="server"></span></li>
                <li>Flower Material: <span id="labelFlowerMaterial" runat="server"></span></li>
                <li>Vase Material: <span id="labelVaseMaterial" runat="server"></span></li>
                <li>Length: <span id="lblLength" runat="server"></span></li>
            </ul>
        </label>
        <label id="Seller" class="features">Seller : <span id="SellerName" style="display: inline-block;margin-left: 60px;color:#00FFC6 ;font-weight: 500;">Paromita Flowers</span></label>
        <label id="Description" class="">Description : <span id="lbldescription" style="display: inline-block;margin-left: 103px;color:black ;font-weight: 400;" runat="server"></span></label>
        <div class="SpecificationMain container-fluid" style="border: 1px solid #878787;">
               <div class="Specification container-fluid"style="">
                <label  style="float:left;">Specifications</label>
               </div>

               <div class="inTheBox container-fluid">
                <label id="lblIntheBox"for="">In The Box</label>
                <label id="Seller" class="features d-block">Selles Package : <span id="lblNumberOfSellerPackage" style="display: inline-block;margin-left: 60px;color:black ;font-weight: 500;margin-top: 20px;" runat="server">1</span></label>
                <label id="Seller" class="features d-block">Pack of : <span id="lblPackOf" style="display: inline-block;margin-left: 110px;color:black ;font-weight: 500;" runat="server">1</span></label>
               </div>
               <div class="General container-fluid" style="" runat="server">
                <label  style="float:left;" runat="server">General</label>
               </div>

               <div class="inGeneral container-fluid">
                <label id="lblBrand" class="generalFeatures d-block" style="">Brand <span id="lblBrandName" style="display: inline-block;margin-left: 156px;color:black ;font-weight: 400;margin-top: 20px;" runat="server"></span></label>
                <label id="lblModelName" class="generalFeatures d-block">Model Name <span id="lblModelName" style="display: inline-block;margin-left: 110px;color:black ;font-weight: 400;" runat="server"> </span></label>
                <label id="lblModelNumber" class="generalFeatures d-block">Model Number <span id="lblModelNumber" style="display: inline-block;margin-left: 96px;color:black ;font-weight: 400;" runat="server"></span></label>
                <label id="lblFlowerType" class="generalFeatures d-block">Flower Type <span id="lblFlowerType" style="display: inline-block;margin-left: 115px;color:black ;font-weight: 400;" runat="server"></span></label>
                <label id="lblCollectionType" class="generalFeatures d-block">Collection Type <span id="lblCollectionType" style="display: inline-block;margin-left: 94px;color:black ;font-weight: 400;" runat="server"></span></label>
                <label id="lblColor" class="generalFeatures d-block">Color <span id="lblColor" style="display: inline-block;margin-left: 159px;color:black ;font-weight: 400;" runat="server"></span></label>
                <label id="lblShade" class="generalFeatures d-block">Shade <span id="lblShade" style="display: inline-block;margin-left: 153px;color:black ;font-weight: 400;" runat="server"></span></label>
                <label id="lblFragrance" class="generalFeatures d-block">Fragrance <span id="lblFragrance" style="display: inline-block;margin-left: 128px;color:black ;font-weight: 400;" runat="server"></span></label>
                <label id="FolwerMaterial" class="generalFeatures d-block">Flower Material <span id="lblFlowerMaterial" style="display: inline-block;margin-left: 92px;color:black ;font-weight: 400;" runat="server"></span></label>
               </div>
               
               <div class="VaseFeatures container-fluid"style="">
                <label  style="float:left;" runat="server">Vase Features</label>
               </div>

               <div class="inVaseFeaures container-fluid">
                <label id="Seller" class="features d-block">Vase included <span id="lblVaseIcludedStatus" style="display: inline-block;margin-left: 94px;color:black ;font-weight: 400;margin-top: 20px;" runat="server"></span></label>
                <label id="Seller" class="features d-block">Vase Material <span id="lblVaseMaterial" style="display: inline-block;margin-left: 96px;color:black ;font-weight: 400;" runat="server"></span></label>
               </div>

               <div class="AdditionalFeatures container-fluid"style="">
                <label  style="float:left;">Aditional Features</label>
               </div>

               <div class="inAdditionalFeaures container-fluid">
                <label id="Seller" class="features d-block">Glitter Coated <span id="lblGliterCoated" style="display: inline-block;margin-left: 92px;color:black ;font-weight: 400;margin-top: 20px;" runat="server"></span></label>
                <label id="Seller" class="features d-block">Dust Resistant <span id="lblDust" style="display: inline-block;margin-left: 91px;color:black ;font-weight: 400;" runat="server"></span></label>
               </div>

               <div class="Dimensions container-fluid"  runat="server">
                <label  style="float:left;" runat="server">Dimensions</label>
               </div>

               <div class="inDimension container-fluid">
                <label id="" class="features d-block">Total Length<span id="lblTotalLength" style="display: inline-block;margin-left: 110px;color:black ;font-weight: 400;margin-top: 20px;" runat="server"></span></label>
               
               </div>
        </div>
        </div>
    </div>
</div>
    </form>
</body>
</html>

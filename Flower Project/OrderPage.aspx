<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderPage.aspx.cs" Inherits="Flower_Project.OrderPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">

    <style>
        .row{
  height:430px;
}
    </style>
</head>
<body>
    <div class="container-fluid"> 
<div class="input-group">
      <input type="text" class="form-control" placeholder="Search your order here" name="email">
      <span class="input-group-text btn-primary">Search orders</span>
    </div>

<div class="row mx-1 mt-2 " >
  <div class="col-sm-4 shadow-sm bg-body rounded"><h2>Filters</h2><hr><h5>ORDER STATUS</h5>
  <div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
  <label class="form-check-label" for="flexCheckDefault">
    <display6>On the way</dispaly6>
  </label>
</div>

    <div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
  <label class="form-check-label" for="flexCheckDefault">
    <display6>Delivered</dispaly6>
  </label>
</div>
    
    <div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
  <label class="form-check-label" for="flexCheckDefault">
    <display6>Canceled</dispaly6>
  </label>
</div>
  
    <div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
  <label class="form-check-label" for="flexCheckDefault">
    <display6>Returned</dispaly6>
  </label>
</div>
    <hr>
    <h5>ORDER TIME</h5>
       <div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
  <label class="form-check-label" for="flexCheckDefault">
    <display6>Last 30 days</dispaly6>
  </label>
</div>
    
       <div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
  <label class="form-check-label" for="flexCheckDefault">
    <display6>2022</dispaly6>
  </label>
</div>
    
       <div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
  <label class="form-check-label" for="flexCheckDefault">
    <display6>2021</dispaly6>
  </label>
</div>
    
      <div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
  <label class="form-check-label" for="flexCheckDefault">
    <display6>2020</dispaly6>
  </label>
</div>
    
       <div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
  <label class="form-check-label" for="flexCheckDefault">
    <display6>2019</dispaly6>
  </label>
</div>
 
       <div class="form-check">
  <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
  <label class="form-check-label" for="flexCheckDefault">
    <display6>Older</dispaly6>
  </label>
</div>
    
</div>
    <div class="col-sm-8 shadow-sm bg-body rounded border" style="height:150px" >
    
       <table class="table">
   
    <tbody>
      <tr>
        <td><img src="https://media.istockphoto.com/photos/young-asian-influencer-smile-woman-walk-and-relax-on-the-beach-picture-id1319897509?s=612x612" height="100px" width="100px">
 </td>
        <td><a href="#">KASHVI ENTPRISES Women A-line Red Dress<a> <p class="text-secondary">Color:Red<br>
          Seller:Kashvastor</p>
        </td>
        <td><a href="#">$320<a></td>
          <td><a href="#">Delivery on April 22</a><p>Your item has been delivered</p></td>
      </tr>  
          </table>
         </div> 
          
</div>
    
</div>
</body>
</html>

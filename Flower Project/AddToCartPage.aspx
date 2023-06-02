<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="AddToCartPage.aspx.cs" Inherits="Flower_Project.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <script src="https://cdn.tailwindcss.com"></script>
    <script src="https://kit.fontawesome.com/f355e557f3.js" crossorigin="anonymous"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HomePage" runat="server">
<body class=" md:p-0 md:p-4 bg-white">
    <div class="" style="height: 85vh; width:100%;" id="mainDiv" runat="server">
    <div  id="main" runat="server">
    <div class="grid grid-cols-4 px-2 py-4 gap-2 fixed mt-15 bg-teal-400 text-white font-semibold shadow-md mb-2" onclick="showPrice()">
        <p class="col-span-3">Total  Order Price</p>
        <p class="col-span-1">12,000</p>
    </div>
  
    <div id="product" runat="server" class=" grid grid-cols-1 lg:grid-cols-6 md:float-left   lg:gap-2 gap-2 md:grid-cols-5 md:gap-2 ">
        <div id="productsContainer" class="Products  col-span-1 lg:col-span-4 md:col-span-3 overflow-auto float-right md:float-left" runat="server"></div>
        <div class="PriceDetails col-span-1 lg:col-span-2 h-80 hidden sticky top-2 float-left md:inline-block  md:col-span-2 md:float-right ml-4 mr-4 md:mr-0 md:ml-0 shadow-inner shadow-white-700 bg-gray-100 rounded ">
            <div class="w-full px-3 py-3 bg-teal-400 rounded text-white text-2xl shadow" style="border-bottom: 2px solid lightgray; " >
                Price Details
            </div>
            <div class="grid grid-cols-5 py-3 px-3 text-lg" style="border-bottom: 2px solid lightgray;border-style: dashed;">
                <div class="col-span-3">
                  <p>Price(<span>1</span>items)</p>
                  <p class="mt-6">Delivery Charges</p>
                </div>
                <div class="col-span-1 px-5">
                    <p><span class="font-sans">₹</span><span id="totalPrice" runat="server">36,657</span></p>
                    <p class="text-green-500 mt-6">Free</p>
                </div>
            </div>
            <div class="grid grid-cols-5 p-3 text-lg" >
                <div class="col-span-3 py-3">
                  <p class="">Total Payable</p>
                </div>
                <div class="col-span-1 py-3 px-5">
                    <p class=""><span class="font-sans">₹</span><span id="totalPayable" runat="server">36,657</span></p>
                    
                </div>
            </div>
            <p class="text-green-500 px-3 text-lg font-bold py-3">Your Total Savings on this order <span class="font-sans">₹</span><span id="totalSaving" runat="server">1425</span></p>
        </div>
    </div>
</div>
</div>
<div class="w-full flex flex-row justify-end  md:pr-0 bg-transparent ml-" style="height: 10vh;" style="position:fixed;">
    <input class="right bg-teal-400  mt-3 mb-3 text-sm md:text-md lg:text-lg text-white font-semibold rounded px-2"  type="button" value="PLACE ORDER"/>
</div>

    <script>

        function QuantityIncrease(id) {
            var Quantity = parseInt(document.getElementById(id).innerText);
            Quantity += 1;
            document.getElementById(id).innerText = Quantity;
        }
        function QuantityDecrease(id) {
            var Quantity = parseInt(document.getElementById(id).innerText);
            if (Quantity > 1) {
                Quantity -= 1;
            }
            document.getElementById(id).innerText = Quantity;
        } 
</script>
</body>
</asp:Content>

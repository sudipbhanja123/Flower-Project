<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewDetailsUnderMain.aspx.cs" Inherits="Flower_Project.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script src="https://cdn.tailwindcss.com"></script>
  <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400&display=swap" rel="stylesheet">
</head>
<style>
    body{
        font-family: 'Poppins', sans-serif;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HomePage" runat="server">
<div class="grid grid-cols-1  md:grid-cols-6 gap-0 md:!gap-2 p-2 sm:p-4" id="main" runat="server">
        <div class=" col-span-1 lg:col-span-2 md:col-span-3 ">
        <div class=" md:sticky top-28">            <img class="w-full h-28 md:h-96" style="height:400px;" id="ProductImage" runat="server"/>
            <div class="my-2 md:mb-0">
                <div class="grid grid-cols-1 md:grid-cols-2 gap-2 md:gap-2">
                    <div>
                       
    <asp:Button ID="btnAddToCard" runat="server" Text="Add to cart" 
                            class="inline-block px-6 w-full py-2.5 bg-yellow-500 text-white font-medium text-xs leading-tight  rounded shadow-md hover:bg-yellow-600 hover:shadow-lg focus:bg-yellow-600 focus:shadow-lg focus:outline-none focus:ring-0 active:bg-yellow-700 active:shadow-lg transition duration-150 ease-in-out" 
                            onclick="btnAddToCard_Click" style="cursor:pointer"/>
                    </div>
                    <div>
                       
        <asp:Button ID="btnBuyNow" runat="server" Text="Buy now" 
                            class="inline-block px-6 w-full py-2.5 bg-teal-600 text-white font-medium text-xs leading-tight  rounded shadow-md hover:bg-teal-700 hover:shadow-lg focus:bg-teal-700 focus:shadow-lg focus:outline-none focus:ring-0 active:bg-violet-700 active:shadow-lg transition duration-150 ease-in-out" 
                            onclick="btnBuyNow_Click1" style="cursor:pointer"/>
                    </div>
                </div>
            </div>
            </div>

        </div>
        <div class="col-span-1 lg:col-span-4 md:col-span-3">
            <div class="shadow bg-gray-100 p-3 h-full w-full pb-6">
                <h1 class="text:md sm:text-2xl" style="text-overflow: ellipsis;white-space: nowrap;overflow: hidden;" id="ProductName" runat="server">Flipkart Perfect Homes Artificial Flowers with White Pot for Home Décor and Gifting White, Pink Orchids Artificial Flower with Pot  (16.5 inch, Pack of 1, Flower Bunch)</h1>
                <span class="text-yellow-600 text-sm font-medium">Special price</span>
                <div class="flex items-center">
                    <span class="text-md sm:text-2xl font-medium" id="EffectivePrice" runat="server"></span>
                    <span class="text-xs sm:text-sm text-gray-500 ml-3" style="text-decoration: line-through;" id="ActualPrice" runat="server"></span>
                    <span class="text-xs sm:text-md text-yellow-600 ml-3" id="PercentageOfDiscount" runat="server"></span>
                </div>
                
                <div class="grid grid-cols-4 lg:grid-cols-6 lg:grid-cols-6 md:grid-cols-5  mt-2">
                    
                        <div class="col-span-1 lg:col-span-1 md:col-span-2">
                            <span class="text-xs sm:text-sm text-gray-500 font-bold">Highlight</span>
                        </div>
                        <div class="col-span-3 lg:col-span-5 md:col-span-3">
                            <ul class="text-xs pl-4 sm:pl-0  sm:text-sm" style="list-style-type: disc;">
                                <li class="text-gray-500">Type: <span class="text-gray-800" id="productType" runat="server"></span></li>
                                <li class="text-gray-500">Vase Included: <span class="text-gray-800" id="VaseIncludeStatus" runat="server"></span></li>
                                <li class="text-gray-500">Flower Material: <span class="text-gray-800" id="FlowerMaterial" runat="server"></span></li>
                                <li class="text-gray-500">Vase Material: <span class="text-gray-800" id="highlightVaseMaterial" runat="server"></span></li>
                                <li class="text-gray-500">Length: <span class="text-gray-800" id="Length" runat="server"></span></li>
                            </ul>
                        </div>
                    
                </div>
                <div class=" h-5 grid grid-cols-4 lg:grid-cols-6 md:grid-cols-5 mt-2">
                    <div class="col-span-1 lg:col-span-1 md:col-span-2">
                        <span class="font-bold text-xs sm:text-sm text-gray-500">Seller</span>
                    </div>
                    <div class="col-span-3 lg:col-span-5 md:col-span-3">
                        <p  class="h-full text-teal-700 pl-4 sm:pl-0 text-xs sm:text-sm p-0" style="transition:all 1s;" id="describedText">
                            Paromita Flowers
                        </p>
                    </div>
                </div>
                <div class="grid grid-cols-4 lg:grid-cols-6 md:grid-cols-5  mt-2">
                    <div class="col-span-1 lg:col-span-1 md:col-span-2">
                        <span class="font-bold text-xs sm:text-sm text-gray-500">Description</span>
                    </div>
                    <div class="col-span-3 lg:col-span-5 md:col-span-3 ">
                        <p  class="h-24 text-xs sm:text-sm pl-4 sm:pl-0 overflow-hidden p-0" style="transition:all 1s;" id="description" runat="server">
                            

                        </p>
                        <span class="text-blue-500 pl-4 sm:pl-0 text-xs sm:text-sm cursor-pointer" onclick="readMore()" id="readMoreButton">Read more</span>
                    </div>
                </div>
                <div class="grid grid-cols-4 mt-2" style="border: 2px solid lightgray;">
                    <div class="col-span-4 px-6 py-3 sm:p-6" style="border-bottom: 2px solid lightgray;">
                      <p class="text-md sm:text-3xl" >Specifications</p>
                    </div>
                    <div class="col-span-4 ">
                            <div class="grid grid-cols-1 px-6 py-1 sm:py-3 " style="border-bottom: 2px solid lightgray;">
                                <div class="col-span-1">
                                    <p class="font-bold text-sm sm:text-lg">In The Box</p>
                                </div>
                                <div class="col-span-1 ">
                                    <div class="grid grid-cols-6 md:grid-cols-6 ">
                                        <div class="col-span-3 text-xs sm:text-sm mt-3 md:col-span-3">
                                            <p class="py-1">Sales Package</p>
                                            <p class="py-1">Pack of</p>
                                           
                                        </div>
                                        <div class="col-span-3 mt-3 text-xs sm:text-sm md:col-span-3">
                                            <p  class="py-1" id="BrandName" runat="server"></p>
                                            <p class="py-1" id="ModelName" runat="server"></p>
                                      
                                        </div>
                                </div>
                            </div>
                      </div>
                      <div class="col-span-4 mt-3 " style="border-bottom:2px solid lightgray;">
                        <div class="grid grid-cols-1 px-6 py-1 sm:py-3">
                            <div class="col-span-1 ">
                                <p class="font-bold text-sm sm:text-lg">General</p>
                            </div>
                            <div class="col-span-1 ">
                                <div class="grid grid-cols-6 md:grid-cols-6 ">
                                    <div class="col-span-3 text-xs sm:text-sm  mt-3 md:col-span-3">
                                        <p class="py-1 ">Brand</p>
                                        <p class="py-1 ">Model name</p>
                                        <p class="py-1 ">Model Number</p>
                                        <p class="py-1">Flower Type</p>
                                        <p class="py-1">Collection Type</p>
                                        <p class="py-1">Color</p>
                                        <p class="py-1">Shade</p>
                                        <p class="py-1">Fragrance</p>
                                        <p class="py-1">Flower Material</p>
                                    </div>
                                    <div class="col-span-3 text-xs sm:text-sm  mt-3 md:col-span-3">
                                        <p class="py-1 overflow-hidden" id="generalBrandName" runat="server"></p>
                                        <p class="py-1 overflow-hidden" id="generalModelName" runat="server"> </p>
                                        <p class="py-1 overflow-hidden" id="ModelNumber" runat="server"></p>
                                        <p class="py-1" id="FlowerType" runat="server"></p>
                                        <p class="py-1" id="CollectionType" runat="server"></p>
                                        <p class="py-1" id="Color" runat="server"></p>
                                        <p class="py-1" id="Shade" runat="server"></p>
                                        <p class="py-1" id="Fragrance" runat="server"></p>
                                        <p class="py-1" id="generalFlowerMaterial" runat="server"></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                  </div>
                  <div class="grid grid-cols-1 px-6 py-1 sm:py-3" style="border-bottom:2px solid lightgray ;">
                    <div class="col-span-1 mt-3 ">
                        <p class="font-bold text-xs sm:text-lg">Vase Features</p>
                    </div>
                    <div class="col-span-1 ">
                        <div class="grid grid-cols-6 md:grid-cols-6 ">
                            <div class="col-span-3 text-xs sm:text-sm  mt-3 md:col-span-3">
                                <p class="py-1">Vase Included</p>
                                <p class="py-1">Vase Material</p>
                               
                            </div>
                            <div class="col-span-3 text-xs sm:text-sm mt-3 md:col-span-3">
                                <p class="py-1" id="VaseIcludedStatus" runat="server"></p>
                                <p class="py-1" id="VaseMaterial" runat="server"></p>
                          
                            </div>
                    </div>
                </div>

                </div>
                <div class="grid grid-cols-1 px-6 py-1 sm:py-3" style="border-bottom:2px solid lightgray;">
                    <div class="col-span-1 mt-3 ">
                        <p class="font-bold text-xs sm:text-lg">Additional Features</p>
                    </div>
                    <div class="col-span-1">
                        <div class="grid grid-cols-6 md:grid-cols-6 ">
                            <div class="col-span-3 text-xs sm:text-sm mt-3 md:col-span-3">
                                <p class="py-1">Glitter Coated</p>
                                <%--<p>Dust Resistant</p>--%>
                               
                            </div>
                            <div class="col-span-3 text-xs sm:text-sm mt-3 md:col-span-3">
                                <p class="py-1" id="GliterCoated" runat="server"></p>
                                <%--<p id="ProductName" runat="server">No</p>--%>
                          
                            </div>
                    </div>
                </div>

            </div>
            <div class="grid grid-cols-1 px-6 py-1 sm:py-3">
                <div class="col-span-1 mt-3">
                    <p class="font-bold text-xs sm:text-lg">Dimensions</p>
                </div>
                <div class="col-span-1">
                    <div class="grid grid-cols-6 md:grid-cols-6 ">
                        <div class="col-span-3 text-xs sm:text-sm mt-3 md:col-span-3">
                            <p class="py-1">Total Length</p>
                        </div>
                        <div class="col-span-3 text-xs sm:text-sm mt-3 md:col-span-3">
                            <p class="py-1" id="TotalLength" runat="server"></p>
                            
                      
                        </div>
                </div>
            </div>
        </div>
    </div>
    </div>
    </div>
       
    </div>
    </div>
    <div class="grid grid-cols-6 " id="productsContainer" runat="server"></div>
</div>


    <script>
        function readMore() {
            var para = document.getElementById('describedText');
            para.classList.toggle('!h-auto')

        }
    </script>
</asp:Content>

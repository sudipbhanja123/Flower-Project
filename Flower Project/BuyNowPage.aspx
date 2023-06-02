<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuyNowPage.aspx.cs" Inherits="Flower_Project.BuyNowPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://cdn.tailwindcss.com"></script>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300&display=swap" rel="stylesheet">
</head>
<style>
    body{
        font-family: 'Poppins', sans-serif;
    }
</style>
<body>
<%--<script language="c#" runat="server">
    private void aLoginAnotherAccount_ServerClick(object sender, EventArgs e)
    {
        Response.Redirect("./HomePageUnderMain.aspx"); 
    }
</script>--%>
 <script>

     function showOrderClickingNewAddress(first, second) 
     {
         var firstElem = document.getElementById(first);
         var secondElem = document.getElementById(second);
         firstElem.style.display = 'none';
         if (secondElem && secondElem.style.display == 'none') {
             secondElem.style.display = 'flex';
         }
     }
     function showHide(id) {
         var el = document.getElementById(id);
         if (el && el.style.display == 'none')
             el.style.display = 'flex';
         else
             el.style.display = 'none';
     }
     function showDeliveryAddress(id) {
         var elem = document.getElementById(id);
         if (elem && elem.style.display == 'none')
             elem.style.display = 'block';
         else
             elem.style.display = 'none';
     }
     function showNewAddress(id) {
         var elem = document.getElementById(id);
         if (elem && elem.style.display == 'none')
             elem.style.display = 'block';
         else
             elem.style.display = 'none';
     }
     function showOrderSummary( id) {
         var elem = document.getElementById(id);

         if (elem && elem.style.display == 'none')
             elem.style.display = 'flex';
         else
             elem.style.display = 'none';
     }
     function QuantityIncrease(id) {
         var Quantity = parseInt(document.getElementById(id).value);
         Quantity += 1;
         document.getElementById(id).value = Quantity;
     }
     function QuantityDecrease(id) {
         var Quantity = parseInt(document.getElementById(id).value);
         if (Quantity > 1) {
             Quantity -= 1;
         }
         document.getElementById(id).value = Quantity;
     } 
    </script>
     <form id="form1" runat="server">
    <div class=" grid grid-cols-1 lg:grid-cols-6 p-4 lg:gap-2 gap-2 md:grid-cols-5 md:gap-2">
        <div class="col-span-1 xs:col-span-1 lg:col-span-4 md:col-span-3  ">
            <div class="grid grid-cols-7 lg:grid-cols-7 md:grid-cols-7 shadow-md p-2 gap-2 rounded">
                <div class="col-span-5 lg:col-span-6 md:col-span-5   p-6">
                    <p class=""><span class="px-2 mr-2 bg-white shadow text-black rounded">1</span><span class="font-semibold text-2xl text-teal-500">LOGIN</span></p>
                    <p class="ml-7 text-md"  runat="server"><span id="txtName" runat="server">Hiranmoy Poria</span> <span id="txtPhoneNumber" runat="server">+918367848157</span></p>
                </div>
                <div class="col-span-2  lg:col-span-1 py-6 md:col-span-2">
                    
                      <button onclick="showHide('asd')" class="w-full shadow-inner rounded-tr-xl rounded-bl-xl shadow-black bg-transparent hover:bg-amber-300 text-amber-400 font-semibold hover:text-white md:py-2 md:px-4 px-2 py-2 md:text-sm md:px-2 border-2 border-amber-700 hover:border-transparent rounded" type="button"  data-bs-toggle="collapse" data-bs-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample">
                        Change
                      </button>
                     
                </div>

            </div>
            <div  class="grid grid-cols-6  p-2 rounded mt-2 shadow-md border-2 border-violet-700" style="display:none;" id="asd">
                <div  class="col-span-3 text-gray-700 p-4">
                    <div class="grid grid-cols-4 ">
                        <div class="col-span-2 text-gray-500">
                            <p>Name</p>
                            <p class="mt-2">Phone</p>
                        </div>
                        <div class="col-span-2 text-black">
                            <p id="txtName1" runat="server">Hiranmoy Poria</p>
                            <p class="mt-2">+<span id="txtPhoneNumber1" runat="server">918367848157</span></p>
                        </div>
                      
                    </div>
                    <button class='mt-3 text-blue-500 underline' id="btnLogout" runat="server">Login & Sign Up to another account</button>
                    <button class="bg-teal-600 text-white hover:bg-teal-700 block font-bold py-3 mt-4 px-6 shadow-inner shadow-black rounded">
                        CONTINUE CHECKOUT
                      </button>
                    
                  </div>
            </div>
            <div class="grid grid-cols-1 shadow bg-teal-600 text-white mt-2 rounded" onclick="showDeliveryAddress('deliveryAddress')" id="divDeliver">
                <div class="col-span-1 p-4 text-lg">
                <p class="" ><span class="px-2 mr-2 bg-white shadow text-black rounded">2</span><span>Delivery Address</span></p>
                </div>
            </div>
            <div class="grid grid-cols-1 p-4  mt-2 shadow-md" id="deliveryAddress" style="display: block;" runat="server">
                <%--<div class="col-span-1 border-b-2 border-lightgray-500 py-3" >
                    <input class="form-check-input appearance-none rounded-full h-4 w-4 border border-gray-300 bg-white checked:border-4 checked:border-blue-600 focus:outline-none transition duration-200 mt-1 align-top bg-no-repeat bg-center bg-contain float-left mr-2 cursor-pointer" type="radio" name="flexRadioDefault" id="flexRadioDefault1" runat="server">
                    <p class="form-check-label inline-block text-gray-800 font-semibold" for="flexRadioDefault1">
                        <span id="lblName" runat="server">Hiranmoy Poria</span><span class="px-6" id="lblContact" runat="server">8367848157</span>
                    </p>
                    <p class="mt-2 font-xs" style="font-size: 10px;" id="lblAddress" runat="server"></p>
                    <button type="button" onclick="showOrderSummary('OrderSummary')" class="bg-teal-600 mt-4 shadow-inner border-2 border-teal-700 shadow-black hover:bg-teal-700 text-white font-bold py-2 px-6 border border-violet-700 rounded inline-block" id="deliver1">
                        DELIVER HERE
                      </button>
                      <button  class=" inline-block shadow-inner shadow-black bg-transparent hover:bg-amber-300 text-amber-400 font-semibold hover:text-white px-6 py-2 border-2 border-amber-700 hover:border-transparent rounded" type="button">
                        Remove
                      </button>
                </div>
                <div class="col-span-1 border-b-2 border-lightgray-500 py-3" >
                    <input class="form-check-input appearance-none rounded-full h-4 w-4 border border-gray-300 bg-white checked:border-4 checked:border-blue-600 focus:outline-none transition duration-200 mt-1 align-top bg-no-repeat bg-center bg-contain float-left mr-2 cursor-pointer" type="radio" name="flexRadioDefault" id="flexRadioDefault1">
                    <p class="form-check-label inline-block text-gray-800 font-semibold" for="flexRadioDefault1">
                        <span id="lblName1" runat="server">Hiranmoy Poria</span><span class="px-6" id="lblContact1" runat="server">8367848157</span>
                    </p>
                    <p class="mt-2 font-xs" style="font-size: 10px;" id="lblAddress1" runat="server"></p>
                    <button type="button" class="bg-teal-600 shadow-inner shadow-black mt-4 hover:bg-teal-700 text-white font-bold py-2 px-6 border border-teal-700 rounded" onclick="showOrderSummary('OrderSummary')">
                        DELIVER HERE
                      </button>
                      <button  class=" inline-block shadow-inner shadow-black bg-transparent hover:bg-amber-300 text-amber-400 font-semibold hover:text-white px-6 py-2 border-2 border-amber-700 hover:border-transparent rounded" type="button">
                        Remove
                      </button>
                </div>--%>
            </div>
            <div class="grid grid-cols-1 mt-2 text-blue-500">
                <div class="col-span-1 p-4 shadow-md " onclick="showNewAddress('newAddress')">
                    <p class=" font-semibold">+<span class="px-6">Add new address</span></p>
                </div>
            </div>
            <div class="grid grid-cols-1 shadow-md p-4 " style="display:none" id="newAddress" runat="server">
                <div class="col-span-1">
                    <div class="grid grid-cols-4 xs:grid-cols-1 gap-4 ">   
                        <div class="col-span-2 xs:col-span-1">
                            <p class="font-semibold text-sm sm:text-lg">Name</p>
                            <input type="text" class="form-control mt-2 block w-full h-12 px-2 py-1 text-sm font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none" id="InputName" placeholder="Name" runat="server"/>
                            <p class="font-semibold text-sm sm:text-lg mt-2">Pin Code</p>
                            <input type="text" class="form-control mt-2 block w-full h-12 px-2 py-1 text-sm font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none" id="inputPinCode" placeholder="Pin code" runat="server"/>
                        </div>
                        <div class="col-span-2 xs:col-span-1>
                            <p class="font-semibold text-sm sm:text-lg">Phone Number</p>
                            <input type="text" class="form-control mt-2 block w-full h-12 px-2 py-1 text-sm font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none" id="inputPhone1" placeholder="Phone Number" runat="server"/>
                            <p class="font-semibold text-sm sm:text-lg mt-2" >Locality</p>
                            <input type="text" class="form-control mt-2 block w-full h-12 px-2 py-1 text-sm font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none" id="inputLocality" placeholder="Locality" runat="server"/>
                        </div>
                        
                    </div>
                </div>
                <div class="col-span-1 mt-2">
                    <p class="font-semibold text-sm sm:text-lg">Address</p>
                    <textarea class="mt-2 form-control  block w-full px-3 py-1.5 text-base text-gray-700 bg-white focus:border-blue-600 focus:outline-none bg-clip-padding border border-solid border-gray-300  rounded transition ease-in-out m-0 focus:text-gray-700 focus:bg-white" id="inputFullAddress" rows="3" placeholder="Full Address" runat="server"></textarea>
                </div>
                <div class=" col-span-1 mt-2">
                    <div class="grid grid-cols-4 gap-4 ">   
                        <div class="col-span-2">
                            <p class="font-semibold text-sm sm:text-lg">City/District/Town</p>
                            <input type="text" class="form-control mt-2 block w-full h-12 px-2 py-1 text-sm font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none" id="InputCity" placeholder="city/district/town" runat="server"/>
                            <p class="font-semibold text-sm sm:text-lg mt-2">Landmark(optional)</p>
                            <input type="text" class="form-control mt-2 block w-full h-12 px-2 py-1 text-sm font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none" id="inputLandMark" placeholder="landmark" runat="server"/>
                        </div>
                        <div class="col-span-2">
                            <p class="font-semibold text-sm sm:text-lg">State</p>
                            <input type="text" class="form-control mt-2 block w-full h-12 px-2 py-1 text-sm font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none" id="inputState" placeholder="state" runat="server"/>
                            <p class="font-semibold text-sm sm:text-lg mt-2" >Mobile number(optonal)</p>
                            <input type="text" class="form-control mt-2 block w-full h-12 px-2 py-1 text-sm font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none" id="inputPhone2" placeholder="mobile number(optional)" runat="server"/>
                        </div>
                      
                </div>
            </div>
            <div class="col-span-1 mt-4">
                <div class="grid grid-cols-5 xs:grid-cols-5 gap-4">
                    <div class="col-span-1 xs:col-span-3">
                        <%--<button class="bg-teal-600 hover:bg-teal-700 text-white font-bold py-2 px-4 border border-teal-700 shadow-inner shadow-black rounded" id="btnSaveAndDeliver" runat="server">
                            Save & Deliver
                          </button>--%>
                        <asp:Button ID="btnSaveAndDeliver" 
                            class="bg-violet-600 hover:bg-violet-700 text-white font-bold py-2 px-4 border border-violet-700 shadow-inner shadow-black rounded" 
                            runat="server" Text="Save & Deliver" onclick="btnSaveAndDeliver_Click1" />
                    </div>
                    <div class="col-span-1 xs:col-span-2">
                        <button class="bg-transparent shadow-inner shadow-black hover:text-white hover:bg-amber-400 text-amber-300 font-bold py-2 px-4 border-2 border-amber-700 rounded">
                            Cancel
                          </button>
                    </div>

                </div>
                
            </div>
            </div>
            <div class="grid grid-cols-1 shadow-md text-white mt-2 rounded" id="divOrderSummary" runat="server">
                <div class="col-span-1 p-4 text-lg text-gray-500">
                    <p class=""><span class="px-2 mr-2 bg-white shadow text-black rounded">3</span><span>Order Summary</span></p>
                </div>
               

            </div>
            <div class="w-full" id="OrderSummary" style="display: none;" runat="server">
            <div  class="grid grid-cols-12 shadow p-4 gap-4 py-2" >
                <div class="lg:col-span-2 py-4 md:col-span-4 sm:col-span-3 col-span-4 shadow-violet lg:px-6 md:px-9 sm:px-7 px-10 ">
                    <img class="rounded shadow " src="https://rukminim1.flixcart.com/image/416/416/kg8avm80/mobile/y/7/n/apple-iphone-12-dummyapplefsn-original-imafwg8dpyjvgg3j.jpeg?q=70" alt="" id="imgSummery" runat="server">
                        <div class="grid grid-cols-1   gap-4 mt-2 ">
                            <div class="col-span-1 flex">
                                <button onclick="QuantityDecrease('Quantity')" id="btnDecrease" style="float:left" type="button" class="inline-block border border-teal  rounded-full  text-black outline-none  uppercase shadow-md   hover:shadow-lg    focus:ring-0 active:bg-teal-700 active:shadow-lg active:text-white transition duration-150 ease-in-out w-6 h-6">-</button>
                                <%--<asp:Button ID="btnDecrease" runat="server" Text="-" style="float:left" class="inline-block border border-teal  rounded-full  text-black outline-none  uppercase shadow-md   hover:shadow-lg    focus:ring-0 active:bg-teal-700 active:shadow-lg active:text-white transition duration-150 ease-in-out w-6 h-6"/>--%>
                                <input id="Quantity" style="float:left; width:50%;" class=" text-center inline-block " value="1" runat="server"/>
                                <button onclick="QuantityIncrease('Quantity')" id="btnIncrease" style="float:left" type="button" class="inline-block border border-teal rounded-full  text-black uppercase shadow-md  hover:shadow-lg    focus:ring-0 active:bg-teal-700 active:shadow-lg active:text-white transition duration-150 ease-in-out w-6 h-6">+</button>
                                <%--<asp:Button ID="btnIncrease" runat="server" Text="+" style="float:left" class="inline-block border border-teal rounded-full  text-black uppercase shadow-md  hover:shadow-lg    focus:ring-0 active:bg-teal-700 active:shadow-lg active:text-white transition duration-150 ease-in-out w-6 h-6">--%>
                            </div>
                         </div>
                   
                </div>
                <div class="col-span-8  md:col-span-8 sm:col-span-8 lg:col-span-10 ">
                    <p class="text-lg font-semibold text-violet-600" style="text-overflow: ellipsis;white-space: nowrap;overflow: hidden;" id="txtFlowerName" runat="server">Flipkart Perfect Homes Artificial Flowers with White Pot for Home Décor and Gifting White, Pink Orchids Artificial Flower with Pot  (16.5 inch, Pack of 1, Flower Bunch)</p>
                    <p class=""><span>16 inch</span>, Pack of <span id="">1</span>, <span>Flower Bunch</span></p>
                    <p class="text-gray-400 py-2"> Seller<span class="text-amber-500 px-4">Paromita Flower</span></p>
                    <p class=""><span class="text-gray-400 line-through">₹<span id="txtActualPrice" runat="server">699</span></span><span class="text-black-500 text-xl font-semibold px-2">₹<span id="txtEffectivePrice" runat="server">235</span></span><span class="px-1 text-green-500"><span class="" id="txtDiscount" runat="server">66</span>% off</span></p>
                    <div class="grid grid-cols-4 mt-7 gap-2" style="">
                        <div class="lg:col-span-3 md:col-span-2 sm:col-span-2 col-span-2">
                            <button type="button" class="border-2 border-amber-700 inline-block px-6 py-2.5 bg-transparent text-amber-400 font-semibold text-md leading-tight uppercase rounded shadow-inner shadow-black hover:bg-amber-300 hover:text-white focus:bg-amber-300  focus:outline-none focus:ring-0 active:bg-amber-300  transition duration-150 ease-in-out">Remove</button>
                        </div>
                        <div class="lg:col-span-1 md:col-span-2 sm:col-span-2 col-span-2">
                            <button type="button" class=" inline-block  px-4 py-2.5 bg-teal-600 text-white font-medium text-medium leading-tight uppercase rounded shadow-inner shadow-black hover:bg-teal-700 focus:bg-teal-700 focus:shadow-lg  focus:ring-0 active:bg-teal-800  transition duration-150 ease-in-out">DELIVER HERE</button>

                        </div>
                    </div>
                    
                </div>
                <div class=" col-span-12 ">
                    <p class="">Delivery in 2 days | <span class="text-green-500 font-normal">Free</span></p>
                   
                </div>
            </div>
        </div>
            <div class="grid grid-cols-1 shadow-md text-white mt-2 rounded">
                <div class="col-span-1 p-4 text-lg text-gray-500">
                    <p class=""><span class="px-2 mr-2 bg-white shadow text-black rounded">4</span><span>Payment Option</span></p>
                </div>

            </div>
           
        </div>
        
        <div class=" col-span-1 xs:col-span-1 lg:col-span-2 h-80  md:col-span-2  shadow-inner shadow-white-700 bg-gray-100 rounded ">
            <div class="w-full px-3 py-3  text-2xl shadow bg-teal-600 text-white" style="border-bottom: 2px solid lightgray; " >
                Price Details
            </div>
            <div class="grid grid-cols-5 py-3 px-3 text-lg" style="border-bottom: 2px solid lightgray;border-style: dashed;">
                <div class="col-span-3">
                  <p>Price(<span>1</span>items)</p>
                  <p class="mt-6">Delivery Charges</p>
                </div>
                <div class="col-span-1 px-5">
                    <p>₹<span id="txtPriceOfItems" runat="server">36,657</span></p>
                    <p class="text-green-500 mt-6">Free</p>
                </div>
            </div>
            <div class="grid grid-cols-5 p-3 text-lg" >
                <div class="col-span-3 py-3">
                  <p class="">Total Payable</p>
                </div>
                <div class="col-span-1 py-3 px-5">
                    <p class="">₹<span id="txtTotalPayable" runat="server">36,657</span></p>
                    
                </div>
            </div>
            <p class="text-green-500 px-3 text-lg font-bold py-3">Your Total Savings on this order ₹<span id="txtSavingOfItems" runat="server">1425</span></p>
        </div>

    </div>
    </form>
</body>
</html>

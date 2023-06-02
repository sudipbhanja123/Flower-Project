<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="HomeUnderMain.aspx.cs" Inherits="Flower_Project.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<script src="https://cdn.tailwindcss.com"></script>
<%-- <style>
 .flex
{
    display:flex;
}
.flex-row
{
    flex-direction:row;
}
.justify-evenly
{
    justify-content:space-evenly;
    align-items:center;
}
.navbtn
{
   color:#712B75;
}
.navbtn:hover
{
  color:#712B75;
  background-color: #FBDFF0;  
}

    .card-body:hover
    {
        cursor:pointer;
       
    }
    .mt-3, .my-3 {
    margin-top: 100px!important;
}

    </style>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HomePage" runat="server">

 <div id="categoryDiv" runat="server" class="grid gap-1 p-2 h-18 lg:h-24 flex flex-row lg:gap-3 flex-wrap justify-between grid-flow-col overflow-x-scroll auto-cols-max  lg:overflow-x-scroll">
        <%--<div class="  h-10 lg:h-14 flex p-1 pr-5 md:pr-2 lg:pr-4 rounded-full border-2 border-teal-600 shadow-md">
            <img src="https://pngimg.com/uploads/lilac/lilac_PNG68.png" class="rounded-full border shadow h-full lg:w-12 w-7 float-left border-teal-300" style="">
            <p class="text-xs py-1 lg:py-1.5 ml-2 font-semibold text-sm lg:text-xl text-teal-800">Orchids</p>
        </div>--%>
    </div>

<div class="grid grid-cols-6 " id="productsContainer" runat="server"></div>

</div>

</asp:Content>

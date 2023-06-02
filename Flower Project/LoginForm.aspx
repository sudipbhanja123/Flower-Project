<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Flower_Project.LoginForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
     function toggleform(){
    var container = document.querySelector('.container');
    container.classList.toggle('active');
    </script>
<script src="https://cdn.tailwindcss.com"></script>
</head>
<style>
        @import url('https://fonts.googleapis.com/css2?family=Poppins&display=swap');
    *
    {
        padding: 0;
        margin: 0;
        font-family: 'Poppins' , sans-serif;
    }
    section
    {
        position: relative;
        min-height: 100vh;
        display: flex;
        justify-content: center;
        align-items: center;
        padding: 20px;
    }
    section .container
    {
        overflow: hidden;
        position: relative;
        width: 800px;
        height: 500px;
        background-color: #fff;
        box-shadow: 0 15px 50px rgba(0,0,0,0.1);
    }
    section .container .user
    {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        display: flex;
    }
    section .container .user .imagebox
    {
        position: relative;
        width: 50%;
        height: 100%;
        transition: 1s;
    }
    section .container .user .imagebox img
    {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        object-fit: cover;
    }
    section .container .user .formbox
    {
        position: relative;
        width: 50%;
        height: 100%;
        background-color: #fff;
        display: flex;
        justify-content: center;
        align-items: center;
        padding: 40px;
        transition: 1s;
    }
    section .container .user .formbox .form h2
    {
        font-size: 22px;
        font-weight: 800;
        letter-spacing: 2px;
        text-transform: uppercase;
        text-align: center;
        margin-bottom: 15px;
        color: #555;
    }
    section .container .user .formbox .form input
    {
        position: relative;
        width: 100%;
        height: 50px !important;
        padding: 0px 10px;
        background-color: #f5f5f5;
        color: #333;
        border: none;
        outline: none;
        margin: 10px 0;
        box-shadow: none;
        letter-spacing: 1px;
        font-weight: 400;
        font-size: 14px;
    }
    section .container .user .formbox .form input[type='submit']
    {
        max-width: 100px;
        background-color: #677eff;
        color: #fff;
        cursor: pointer;
    }
    section .container .user .formbox .form .signup-text
    {
        position: relative;
        margin-top: 10px;
        font-size: 12px;
        letter-spacing: 1px;
        color: #555;
        text-transform: uppercase;
    }
    section .container .user .formbox .form .signup-text a
    {
        text-decoration: none;
        color: #677eff;
        cursor: pointer;
    }
    section .container .signupbox
    {
        pointer-events: none;
    }
    section .container.active .signupbox
    {
        pointer-events: initial;
    }
    section .container .signupbox .formbox
    {
        left: 100%;
    }
    section .container.active .signupbox .formbox
    {
        left: 0;
    }
    section .container .signupbox .imagebox
    {
        left: -100%;
    }
    section .container.active .signupbox .imagebox
    {
        transform: rotate(360deg);
        left: 0;
    }
    section .container.active .signupbox + .main-section
    {
        background-color: blue !important;
    }
    section .container .signinbox .formbox
    {
        left: 0;
    }
    section .container.active .signinbox .formbox
    {
        left: 100%;
        transform: rotate(360deg);
    }
    section .container .signinbox .imagebox
    {
        left: 0;
    }
    section .container.active .signinbox .imagebox
    {
        left: -100%;
    }
    @media (max-width:750px)
    {
        section .container
        {
            max-width: 400px;
        }
        section .container .imagebox
        {
            display: none;
        }
        section .container .user .formbox
        {
            width: 100%;
        }
    }
    
    
    .btn
    {
        background: #2495e0;
        background-image: -webkit-linear-gradient(top, #2495e0, #1f5b80);
        background-image: -moz-linear-gradient(top, #2495e0, #1f5b80);
        background-image: -ms-linear-gradient(top, #2495e0, #1f5b80);
        background-image: -o-linear-gradient(top, #2495e0, #1f5b80);
        background-image: linear-gradient(to bottom, #2495e0, #1f5b80);
        -webkit-border-radius: 28;
        -moz-border-radius: 28;
        border-radius: 28px;
        font-family: Arial;
        color: #ffffff;
        font-size: 18px;
        padding: 7px 20px 10px 20px;
        text-decoration: none;
    }
    
    .btn:hover
    {
        background: #3cb0fd;
        background-image: -webkit-linear-gradient(top, #3cb0fd, #3498db);
        background-image: -moz-linear-gradient(top, #3cb0fd, #3498db);
        background-image: -ms-linear-gradient(top, #3cb0fd, #3498db);
        background-image: -o-linear-gradient(top, #3cb0fd, #3498db);
        background-image: linear-gradient(to bottom, #3cb0fd, #3498db);
        text-decoration: none;
    }
</style>
<body>
    <form id="form1" runat="server">
    <section class="main-section">
        <div class="container"> 
        <div class="user signinbox"> 
        <div class="imagebox"> 
        <img src="https://images.pexels.com/photos/1181325/pexels-photo-1181325.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2">
         </div> <div class="formbox">
          <div class="form"> 
          <h2>Signin</h2> 
          <input type="text" placeholder="Email" id="txtEmail" runat="server">
           <input type="password" placeholder="password" id="txtPassword" runat="server"> 
           <%--<input type="submit" value="Login" runat="server"> --%>
           <asp:Button ID="btnLogin" class="ct104" runat="server" Text="Login" 
                  onclick="btnLogin_Click"></asp:Button>
           <p class="signup-text">Don't have an account? <a href="#" onClick="toggleform();">Signup</a></p> 
           </div> </div> </div> <div class="user signupbox"> <div class="formbox"> 
           <div class="form"> <h2>Signup</h2> <input type="text" placeholder="Name"> 
           <input type="email" placeholder="Email"> <input type="password" placeholder="Password"> 
           <input type="submit" value="Signup"> <p class="signup-text">Already have an account? <a href="#" onClick="toggleform();">Login</a></p>
            </div>
             </div>
              <div class="imagebox"> 
              <img src="https://images.pexels.com/photos/3643925/pexels-photo-3643925.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"> 
              </div> 
              </div> 
              </div>
</section>
    </form>
</body>
</html>

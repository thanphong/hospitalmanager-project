<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QuanLyBenhVien.View.personnel.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="~/Styles/login/stylelogin.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="loginWrapper">
    <!-- New user form -->
    <form action="index.html" id="recover">
        <div class="loginPic">
            <a href="#" title=""><img src="http://i.imgur.com/axskkd0.png" alt=""></a>
            <div class="loginActions">
                <div><a href="#" title="" class="logback flip" style="left: 0px; opacity: 1;"></a></div>
                <div><a href="#" title="Forgot password?" class="logright" style="right: 0px; opacity: 1;"></a></div>
            </div>
        </div>
            
        <input type="text" name="login" placeholder="Your username" class="loginUsername">
        <input type="password" name="password" placeholder="Password" class="loginPassword">
        
        <div class="logControl">
            <div class="memory"><div class="checker" id="uniform-remember2"><span><input type="checkbox" checked="checked" class="check" id="remember2" style="opacity: 0;"></span></div><label for="remember2">Remember me</label></div>
            <input type="submit" name="submit" value="Login" class="buttonM bBlue">
        </div>
    </form>
</div>

<script class="cssdeck" src="//cdnjs.cloudflare.com/ajax/libs/jquery/1.8.0/jquery.min.js"></script>
    </form>
</body>
</html>

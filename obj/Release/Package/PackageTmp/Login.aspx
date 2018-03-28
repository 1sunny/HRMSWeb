<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HRMSWeb.Login" %>


<!DOCTYPE html>
<html>
<head id="head1" runat='server'>
     <link rel="icon" 
      type="image/png" 
      href="images/favicon.png"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>BTC Fashion HRMS</title>
    <!-- CSS -->
    <link href="~/css/style-admin.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="~/css/responsiveslides.css" />
    <!-- JS -->
    <script src="js/jquery-1.8.3.min.js" type="text/javascript"></script>
    <script src="js/jquery-ui.js" type="text/javascript"></script>
     <link rel="stylesheet" href="~/css/jquery-ui.css" />
        
</head>
<body>
    <form id="form1" runat="server">
     
    <div class="clear">
    </div>
    <header>
    <div class="container clearfix">
  <div class="row-fluid show-grid">
  <div class="span4">
    <a title="BTC Fashion HRMS">
       <%-- <img src="images/logo.png" class="featurette-image" alt="" style="border:none;" />--%>

    </a>
    </div>
    <div class="text-logout-box">
    
    </div>
    <div class="text-admin-panel">
    BTC Fashion HRMS
    </div>
    
  </div></div>
</header>
    <div class="divider">
    </div>
    <div class="adm-menu-wrapper">
        
    </div>
    <div class="clear">
    </div>
    <div class="clear">
    </div>
    <div class="row-fluid">
        <div class="adm-container" style="width: auto;"> 
            <table align="right">
        <tr>
            <td>
                Username :
            </td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                Password :
            </td>
            <td>
                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </td>
        </tr>
    </table>
        </div>
    </div>
    <div class="row-fluid">
        <div class="divider">
        </div>
        <div class="container footer">
            <span>&copy; Copyrights 2017 <a href="/">BTC Fashion </a>| Powered by <a href="http://btcfashion.me/"
                target="_blank">BTC Fashion</a> </span>
        </div>
    </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>OBU3 NPI2.0 - Login</title>
    <link rel="stylesheet" href="..\css\style.css" type="text/css" />
    
    </head>
<body style="font-size:68.2%;" >
    <form id="form1" runat="server">  
    <br>
    <div id="login_panel" align="center" style="background-color:White;">
      <table style="border-top: gray 1px solid; border-bottom: gray 1px solid; border-left: gray 1px solid; border-right: gray 1px solid; ">
        <tr>
        <td width="50px" style="font-family: Arial, Helvetica, sans-serif; font-size: 50px; font-weight: bold; color: #005984" >
        <img alt src="../Images/img/Logo-SPIL.gif" style="border-color: #FFFFFF"/>
        </td>
        <td valign="top" width="400px" style="background: #77D7D9">
        <div align="center" 
                style="font-size: xx-large; color: #FFF; font-family: 'Cambria'; font-weight: bolder; margin-top: 60px;">
                                   OBU3 NPI2.0<br>
       </div>       
        <br>
        <div align="center">請輸入您的帳號和密碼:</div>
        <div align="center"><b>帳號：</b><asp:TextBox ID="username" runat="server" Width="150px"></asp:TextBox></div>
        <br>
        <div align="center"><b>密碼：</b><asp:TextBox ID="password" runat="server" Width="150px" TextMode="Password"></asp:TextBox></div>
        <br>
        <div align="center">
              <asp:Button ID="Button1" runat="server" Text="登入" onclick="Button1_Click" /></div>
        </td>
        </tr>       
        <tr>
        <td colspan="2"> 
            <div align="center">    
                <asp:Label ID="lblError" runat="server" ForeColor="Red" Font-Size="Large"></asp:Label>     
            </div>
        </td>
        </tr>      
        <tr>
         <td colspan="2" style="padding: 8px; text-align: left; background-color: #E7E7E7;">
                    <p style="text-align: right">
                        <span style="font-size: 8pt; font-family: Arial">This site is optimized for IE 
                        6.0 or above and is best viewed with screen resolution of 1280 x 1024.
                        <br>
                        Copyright© 2016 SPIL.OBU3 All Rights Reserved.</span></p>
                </td>     
        </tr>
      </table>      
    </div>


    </form>
</body>
</html>

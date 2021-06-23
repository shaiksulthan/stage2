<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowCartPage.aspx.cs" Inherits="ASPAddToCartWebSite.ShowCartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 187px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center; color: #FFFFFF; background-color: #003366">
    
        ASP.NET SHOW CART DEMO WEBSITE</div>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblTotQty" runat="server" style="color: #003366; font-weight: 700"></asp:Label>
                   &nbsp;&nbsp; <asp:Label ID="lblTotAmt" runat="server" style="color: #800000; font-weight: 700"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

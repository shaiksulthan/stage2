<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyFirstWebApp.aspx.cs" Inherits="ASPWebApplicationDemo.MyFirstWebApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Enter your name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Click Me" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />

        HTML CONTROL
        <br />
        <input id="Text1" type="text" />
        <input id="Btn1" type="button" value="button" />

    </form>
</body>
</html>

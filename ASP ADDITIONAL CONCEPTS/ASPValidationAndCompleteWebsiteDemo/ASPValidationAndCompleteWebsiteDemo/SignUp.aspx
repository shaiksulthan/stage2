<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ASPValidationAndCompleteWebsiteDemo.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style13 {
            width: 16%;
            color: #003366;
            height: 23px;
        }
        .auto-style14 {
            width: 18%;
            height: 23px;
        }
        .auto-style15 {
            width: 19%;
            height: 23px;
        }
        .auto-style20 {
        width: 16%;
        color: #003366;
        height: 25px;
    }
    .auto-style21 {
        width: 18%;
        height: 25px;
    }
    .auto-style22 {
        width: 19%;
        height: 25px;
    }
    .auto-style24 {
        width: 16%;
        color: #003366;
    }
    .auto-style25 {
        width: 18%;
    }
    .auto-style26 {
        width: 19%;
    }
    .auto-style27 {
        width: 3%;
    }
    .auto-style28 {}
    .auto-style29 {
        height: 25px;
        width: 3%;
    }
    .auto-style30 {
        height: 23px;
        width: 3%;
    }
    .auto-style31 {
        height: 23px;
        width: 12%;
    }
    .auto-style32 {
        width: 10px;
    }
    .auto-style33 {
        width: 14%;
    }
    .auto-style34 {
        height: 25px;
        width: 14%;
    }
    .auto-style35 {
        height: 23px;
        width: 10px;
    }
    .auto-style36 {
        height: 23px;
        width: 14%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style24"><em><strong>User Name</strong></em></td>
            <td class="auto-style25">
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="User name required" style="color: #800000">*</asp:RequiredFieldValidator>
            </td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24"><em><strong>Password</strong></em></td>
            <td class="auto-style25">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Password required" style="color: #800000">*</asp:RequiredFieldValidator>
            </td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td colspan="2" rowspan="3" style="text-align: center">
                <asp:Image ID="ImgProfilePic" runat="server" Height="79px" Width="92px" />
            </td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24"><strong><em>Re type password</em></strong></td>
            <td class="auto-style25">
                <asp:TextBox ID="txtRePassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtRePassword" Display="Dynamic" ErrorMessage="Retype Password " style="color: #800000">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRePassword" ErrorMessage="Password mismatch" style="font-weight: 700; color: #800000"></asp:CompareValidator>
            </td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20"><em><strong>Email </strong></em></td>
            <td class="auto-style21">
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style22">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email required" style="color: #800000">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Invalid Email id" style="color: #800000; font-weight: 700" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style29"></td>
            <td class="auto-style29"></td>
            <td class="auto-style34"></td>
            <td class="auto-style29"></td>
            <td class="auto-style29"></td>
        </tr>
        <tr>
            <td class="auto-style24"><strong><em>Contact No.</em></strong></td>
            <td class="auto-style25">
                <asp:TextBox ID="txtNo" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style26">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNo" Display="Dynamic" ErrorMessage="Contact no. required" style="color: #800000">*</asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Invalid number" MaximumValue="9999999999" MinimumValue="6300000000" style="color: #800000; font-weight: 700" Type="Double" ControlToValidate="txtNo" Display="Dynamic"></asp:RangeValidator>
            </td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style28" colspan="3">
                <asp:Button ID="btnUpload" runat="server" BackColor="#336699" BorderStyle="None" ForeColor="White" OnClick="btnUpload_Click" Text="Upload" CausesValidation="False" />
                <asp:FileUpload ID="FileUpload1" runat="server" BackColor="White" />
            </td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style14">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" style="color: #800000" ShowMessageBox="True" />
            </td>
            <td class="auto-style15"></td>
            <td class="auto-style30"></td>
            <td class="auto-style30"></td>
            <td class="auto-style31"></td>
            <td class="auto-style35"></td>
            <td class="auto-style36"></td>
            <td class="auto-style30"></td>
            <td class="auto-style30"></td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style25">
                <asp:Button ID="btnRegister" runat="server" BackColor="#009999" BorderStyle="None" ForeColor="White" Text="Register" OnClick="btnRegister_Click" />
               &nbsp;&nbsp;<asp:Button ID="btnCancel" runat="server" BackColor="#FF5050" BorderStyle="None" ForeColor="White" Text="Cancel" OnClick="btnCancel_Click" CausesValidation="False" />
            </td>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style32">&nbsp;</td>
            <td class="auto-style33">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

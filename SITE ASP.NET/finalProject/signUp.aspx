<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="finalProject.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style8 {
        height: 31px;
    }
    .auto-style10 {
        width: 329px;
        height: 53px;
    }
        .auto-style15 {
            width: 303px;
            height: 53px;
        }
        .auto-style16 {
            width: 302px;
        }
        .auto-style17 {
            width: 329px;
            height: 64px;
        }
        .auto-style18 {
            width: 303px;
            height: 64px;
        }
        .auto-style19 {
            width: 329px;
            height: 56px;
        }
        .auto-style20 {
            width: 303px;
            height: 56px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%; height: 276px; margin-top: 0px;">
    <tr>
        <td class="auto-style8" colspan="3" style="font-size: 20px; font-weight: 600; background-color: #C0C0C0; color: #000000">
            <div>
                Welcome Guest</div>
        </td>
    </tr>
    <tr>
        <td class="auto-style19">First Name:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="firstname" runat="server" Width="196px"></asp:TextBox>
        </td>
        <td class="auto-style20">Last Name:&nbsp;&nbsp;
            <asp:TextBox ID="lastname" runat="server" Width="184px"></asp:TextBox>
        </td>
        <td class="auto-style16" rowspan="3">
            <asp:Image ID="Image1" runat="server" Height="321px" ImageUrl="addSomeone.jpg" Width="347px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style17">User Name:&nbsp;&nbsp;
            <asp:TextBox ID="username" runat="server" Width="192px"></asp:TextBox>
        </td>
        <td class="auto-style18">Password:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="password" runat="server" Width="191px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Email:&nbsp;&nbsp;
            <asp:TextBox ID="email" runat="server" Width="219px"></asp:TextBox>
        </td>
        <td class="auto-style15">&nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div style="height: 49px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="error" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="signUp" runat="server" OnClick="signUp_Click" Text="Sign Up" />
            </div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
</table>
</asp:Content>

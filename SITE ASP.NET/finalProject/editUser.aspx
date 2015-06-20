<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="editUser.aspx.cs" Inherits="finalProject.editUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style19 {
            width: 329px;
            height: 56px;
        }
        .auto-style20 {
            width: 303px;
            height: 56px;
        }
        .auto-style17 {
            width: 329px;
            height: 64px;
        }
        .auto-style18 {
            width: 303px;
            height: 64px;
        }
        .auto-style10 {
        width: 329px;
        height: 53px;
    }
        .auto-style15 {
            width: 303px;
            height: 53px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%; height: 276px; margin-top: 0px;">
        <tr>
            <td class="auto-style19">First Name:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="firstname" runat="server" Width="196px"></asp:TextBox>
            </td>
            <td class="auto-style20">Last Name:&nbsp;&nbsp;
                <asp:TextBox ID="lastname" runat="server" Width="184px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">User Name:&nbsp;&nbsp;
                <asp:Label ID="userName" runat="server"></asp:Label>
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
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div style="height: 49px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="error" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Save" runat="server" OnClick="signUp_Click" Text="Save" />
                <br />
                </div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="del" runat="server" BackColor="Red" OnClick="del_Click" Text="Delete my Business Page" />
&nbsp;&nbsp;
                <asp:Label ID="errorText" runat="server" ForeColor="Red"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="YES" runat="server" Height="26px" OnClick="YES_Click" Text="yes" Visible="False" Width="44px" />
    &nbsp;&nbsp;<asp:Button ID="no" runat="server" Height="25px" OnClick="no_Click" Text="NO" Visible="False" Width="53px" />
    &nbsp;&nbsp;&nbsp;</td>
        </tr>
    </table>
</asp:Content>

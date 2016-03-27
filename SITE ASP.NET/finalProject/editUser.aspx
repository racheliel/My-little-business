<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="editUser.aspx.cs" Inherits="finalProject.editUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style17 {
            width: 346px;
            height: 64px;
        }
        .auto-style10 {
        width: 346px;
        height: 53px;
    }
        .auto-style21 {
        width: 365px;
        height: 64px;
    }
    .auto-style22 {
        width: 365px;
        height: 53px;
    }
        .auto-style23 {
            width: 346px;
            height: 106px;
        }
        .auto-style24 {
            width: 365px;
            height: 106px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%; height: 276px; margin-top: 0px;">
        <tr>
            <td class="auto-style23" style="font-size: 26px;">welcome
                &nbsp;&nbsp;<asp:Label ID="name" runat="server"></asp:Label>
                <br />
                <br />
                First Name:&nbsp;
                <asp:TextBox ID="firstname" runat="server" Width="196px"></asp:TextBox>
            </td>
            <td class="auto-style24" style="font-size: 26px;">
                <br />
                <br />
                Last Name:&nbsp;&nbsp;
                <asp:TextBox ID="lastname" runat="server" Width="184px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style17" style="font-size: 26px;">User Name:&nbsp;&nbsp;
                <asp:Label ID="userName" runat="server"></asp:Label>
            </td>
            <td class="auto-style21" style="font-size: 26px;">Password:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="password" runat="server" Width="191px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" style="font-size: 26px;">Email:&nbsp;&nbsp;
                <asp:TextBox ID="email" runat="server" Width="219px"></asp:TextBox>
            </td>
            <td class="auto-style22" style="font-size: 26px;">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div style="height: 49px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="error" runat="server" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Save" runat="server" OnClick="signUp_Click" Text="Save" BackColor="#DADADA" Font-Bold="True" Font-Names="Adobe Hebrew" Font-Size="X-Large" ForeColor="#7B9E46" Height="41px" Width="96px" />
                <br />
                <br />
                <br />
                <br />
                </div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                <br />
                &nbsp;
    <asp:Button ID="del" runat="server" BackColor="White" OnClick="del_Click" Text="Delete my Business Page" Font-Bold="True" Font-Names="Adobe Hebrew" Font-Size="Medium" ForeColor="Red" />
&nbsp;&nbsp;
                <asp:Label ID="errorText" runat="server" ForeColor="Red"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="YES" runat="server" Height="26px" OnClick="YES_Click" Text="yes" Visible="False" Width="44px" Font-Bold="True" Font-Size="Medium" ForeColor="Red" />
                &nbsp;&nbsp;<asp:Button ID="no" runat="server" Height="25px" OnClick="no_Click" Text="NO" Visible="False" Width="53px" Font-Bold="True" Font-Size="Medium" ForeColor="Red" />
                &nbsp;&nbsp;&nbsp;&nbsp;</td>
        </tr>
    </table>
</asp:Content>

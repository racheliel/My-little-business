<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="businessShow.aspx.cs" Inherits="finalProject.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style14 {
            width: 388px;
        }
        .auto-style16 {
            width: 388px;
            height: 20px;
        }
        .auto-style17 {
            width: 652px;
            height: 20px;
        }
        .auto-style18 {
            height: 20px;
        }
        .auto-style19 {
            width: 652px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="busName" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="edit" runat="server" OnClick="Button1_Click" Text="Edit" />
                <asp:Button ID="home" runat="server" OnClick="home_Click" Text="Home" />
            </td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Image ID="logo" runat="server" Height="100px" Width="100px" />
            </td>
            <td class="auto-style17"></td>
            <td class="auto-style18"></td>
        </tr>
        <tr>
            <td class="auto-style14">
                Detailes:
                <asp:Label ID="det" runat="server"></asp:Label>
            </td>
            <td class="auto-style19">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">
                place:
                <asp:Label ID="place" runat="server"></asp:Label>
            </td>
            <td class="auto-style19">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:TemplateField HeaderText="image">
                            <ItemTemplate>
                                <asp:Image ID="img" runat="server" ImageUrl='<%#Eval("image") %>' Height="200" Width="200" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <br />
                <asp:Label ID="errorText" runat="server" ForeColor="Red"></asp:Label>
                </td>
            <td class="auto-style19">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:TextBox ID="TextBox1" runat="server" Height="66px" Width="418px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="getF" runat="server" OnClick="getF_Click" Text="send feedback" />
</asp:Content>

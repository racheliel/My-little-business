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
            width: 464px;
            height: 20px;
        }
        .auto-style18 {
            height: 20px;
        }
        .auto-style19 {
            width: 464px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style14">
                <asp:Label ID="errorText" runat="server" ForeColor="Red"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="YES" runat="server" Height="26px" OnClick="YES_Click" Text="yes" Visible="False" Width="44px" />
                &nbsp;&nbsp;<asp:Button ID="no" runat="server" Height="25px" OnClick="no_Click" Text="NO" Visible="False" Width="53px" />
                &nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td class="auto-style19">
                <asp:Label ID="busName" runat="server"></asp:Label>
            </td>
            <td>
                <asp:Button ID="edit" runat="server" BackColor="#66FF33" Height="25px" OnClick="Button1_Click" Text="Edit" Width="41px" />
                &nbsp;
                <asp:Button ID="home" runat="server" BackColor="#66FF33" Height="25px" OnClick="home_Click" style="margin-top: 0px" Text="Home" Width="83px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style16">
                <asp:Image ID="logo" runat="server" Height="100px" Width="100px" />
            </td>
            <td class="auto-style17">Detailes:
                <asp:Label ID="det" runat="server"></asp:Label>
            </td>
            <td id="favText0" class="auto-style18">
                <asp:Button ID="addFav" runat="server" OnClick="addFav_Click" Text="Add to faivorit" />
                <br />
                <br />
                <asp:Label ID="favText" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style19">place:
                <asp:Label ID="place" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td class="auto-style19">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:TemplateField HeaderText="image">
                            <ItemTemplate>
                                <asp:Image ID="img" runat="server" Height="200" ImageUrl='<%#Eval("image") %>' Width="200" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <br />
                <br />
                <br />
                <br />
            </td>
            <td class="auto-style19">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="table1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="136px" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="table1_SelectedIndexChanged" style="margin-left: 154px; margin-bottom: 0px" Width="535px">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Height="66px" Width="418px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
    <asp:Button ID="getF" runat="server" OnClick="getF_Click" Text="send feedback" />
    <br />
    <br />
    <asp:Button ID="del" runat="server" BackColor="Red" OnClick="del_Click" Text="Delete my Business Page" />
    &nbsp;&nbsp;
    <br />
    <br />
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="business.aspx.cs" Inherits="finalProject.business" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style14 {
            width: 388px;
        }
        .auto-style19 {
            width: 464px;
        }
        .auto-style16 {
            width: 388px;
            }
        .auto-style17 {
            width: 464px;
            height: 20px;
        }
        .auto-style18 {
            height: 20px;
        }
        .auto-style21 {
        width: 382px;
        height: 94px;
    }
    .auto-style22 {
        height: 94px;
    }
    .auto-style24 {
        width: 382px;
        height: 86px;
    }
    .auto-style25 {
        height: 86px;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style14">
                welcome&nbsp;&nbsp;<asp:Label ID="userName" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="errorText" runat="server" ForeColor="Red"></asp:Label>
                </td>
            <td class="auto-style19" style="height: 61px; margin-bottom: 9px; color: #5E6F3A; width: 1154px; margin-top: 0px; font-size: 50px; font-weight: 900; font-family: 'Berlin Sans FB Demi';">
                <asp:Label ID="busName" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16" rowspan="3">
                <asp:Image ID="logo" runat="server" Height="246px" Width="289px" />
            </td>
            <td class="auto-style17" style="font-size: 20px; font-weight: 700; background-color: #FFFFFF; color: #000000;">Category:
                <asp:Label ID="category" runat="server"></asp:Label>
            </td>
            <td id="favText0" class="auto-style18">
                <asp:Button ID="addFav" runat="server" OnClick="addFav_Click" Text="Add to faivorit" BackColor="#DADADA" Font-Names="Adobe Hebrew" Font-Size="X-Large" ForeColor="#7B9E46" Height="31px" Width="161px" />
                <br />
                <br />
                <asp:Label ID="favText" runat="server" ForeColor="Black"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style21" style="font-size: 20px; font-weight: 700; background-color: #FFFFFF; color: #000000;">place:
                <asp:Label ID="place" runat="server"></asp:Label>
            </td>
            <td class="auto-style22"></td>
        </tr>
        <tr>
            <td class="auto-style24" style="font-size: 20px; font-weight: 700; background-color: #FFFFFF; color: #000000;">Detailes:
                <asp:Label ID="det" runat="server"></asp:Label>
            </td>
            <td class="auto-style25"></td>
        </tr>
        <tr>
            <td class="auto-style14">
                <br />
                <br />
                <br />
                <br />
                <br /></td>
            <td class="auto-style19">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="image">
                            <ItemTemplate>
                                <asp:Image ID="img" runat="server" Height="200" ImageUrl='<%#Eval("image") %>' Width="200" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:GridView ID="table1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Font-Size="Larger" Height="136px" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="table1_SelectedIndexChanged" style="margin-left: 154px; margin-bottom: 0px" Width="535px">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" Font-Size="Medium" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" Font-Size="Medium" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" Font-Size="Medium" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333"  />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <br />
    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Height="113px" Width="525px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;<br />
<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="getF" runat="server" OnClick="getF_Click" Text="send feedback" BackColor="#DADADA" Font-Bold="True" Font-Names="Adobe Hebrew" Font-Size="X-Large" ForeColor="#7B9E46" Height="37px" style="margin-left: 0px" Width="215px" />
    <br />
    <br />&nbsp;&nbsp;
    <br />
    <br />
</asp:Content>

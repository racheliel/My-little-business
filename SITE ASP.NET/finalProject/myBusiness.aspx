<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="myBusiness.aspx.cs" Inherits="finalProject.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style17 {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style17">welcome&nbsp;
                <asp:Label ID="userName" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="er" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Business Name:"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="busName" runat="server" Width="249px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="chackBusName" runat="server" OnClick="chackBusName_Click" Text="Add Business Name" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="errorName" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                Logo:&nbsp;&nbsp;
                <asp:FileUpload ID="FileUpload1" runat="server" Width="319px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="logoImage" runat="server" OnClick="logoImage_Click" Text="Add Logo" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="errorLogo" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Image ID="ImgLogo" runat="server" Height="100px" Width="100px" />
                <br />
                <br />
                New Place:&nbsp;
                <asp:DropDownList ID="place" runat="server" DataSourceID="placeE" DataTextField="place" DataValueField="place">
                </asp:DropDownList>
                <asp:SqlDataSource ID="placeE" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT * FROM [Place]"></asp:SqlDataSource>
                <br />
                <br />
                New Category:<asp:DropDownList ID="category" runat="server" DataSourceID="categoryE" DataTextField="category" DataValueField="category" OnSelectedIndexChanged="category_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="categoryE" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
                <br />
                <br />
                <br />
                New Detailes:<br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server" Height="84px" Width="294px"></asp:TextBox>
                <br />
                <br />
                Images:&nbsp;&nbsp;&nbsp;
                <asp:FileUpload ID="FileUpload2" runat="server" Width="296px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <asp:Button ID="upImage" runat="server" OnClick="upImage_Click" Text="Upload Image" />
                &nbsp;&nbsp;
                <asp:Label ID="errorImage" runat="server"></asp:Label>
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:ButtonField CommandName="delete" HeaderText="delete" Text="delete" />
                        <asp:TemplateField HeaderText="image">
                            <ItemTemplate>
                                <asp:Image ID="img" runat="server" Height="100" ImageUrl='<%#Eval("image") %>' Width="100" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
                <br />
                <asp:Button ID="save" runat="server" OnClick="save_Click" Text="Save Business Page" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

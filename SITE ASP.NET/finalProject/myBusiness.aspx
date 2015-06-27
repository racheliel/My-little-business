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
            <td class="auto-style17" style="font-size: 20px; font-weight: 700; background-color: #FFFFFF; color: #000000;">welcome&nbsp;
                <asp:Label ID="userName" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="er" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Business Name:"></asp:Label>
                &nbsp;&nbsp;
                <asp:TextBox ID="busName" runat="server" Width="249px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="checkBusName" runat="server" OnClick="checkBusName_Click" Text="Add Business Name" BorderColor="#DADADA" Font-Bold="True" Font-Names="adobe hebrew" Font-Size="Large" ForeColor="#7B9E46" Width="218px" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="errorName" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                Logo:&nbsp;&nbsp;
                <asp:FileUpload ID="FileUpload1" runat="server" Width="319px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="logoImage" runat="server" OnClick="logoImage_Click" Text="Add Logo" BorderColor="#DADADA" Font-Bold="True" Font-Names="adobe hebrew" Font-Size="Large" ForeColor="#7B9E46" Height="36px" Width="122px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="errorLogo" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Image ID="ImgLogo" runat="server" Height="100px" Width="100px" />
                <br />
                <br />
                New Place:&nbsp;
                <asp:DropDownList ID="place" runat="server" DataSourceID="placeE" DataTextField="place" DataValueField="place" AppendDataBoundItems="True" Height="56px" Width="125px">
                    <asp:ListItem>choose place</asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="placeE" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT * FROM [Place]"></asp:SqlDataSource>
                <br />
                <br />
                New Category:<asp:DropDownList ID="category" runat="server" DataSourceID="categoryE" DataTextField="category" DataValueField="category" OnSelectedIndexChanged="category_SelectedIndexChanged" AppendDataBoundItems="True" Height="56px" Width="127px">
                    <asp:ListItem>choose category</asp:ListItem>
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
                <asp:Button ID="upImage" runat="server" OnClick="upImage_Click" Text="Upload Image" BorderColor="#DADADA" Font-Bold="True" Font-Names="adobe hebrew" Font-Size="Large" ForeColor="#7B9E46" Width="150px" />
                &nbsp;&nbsp;
                <asp:Label ID="errorImage" runat="server"></asp:Label>
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="642px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:ButtonField CommandName="delete" HeaderText="delete" Text="delete" />
                        <asp:TemplateField HeaderText="image">
                            <ItemTemplate>
                                <asp:Image ID="img" runat="server" Height="100" ImageUrl='<%#Eval("image") %>' Width="100" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White"  />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White"  />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
                <br />
                <asp:Button ID="Save" runat="server" OnClick="save_Click" Text="Save" BackColor="#DADADA" Font-Bold="True" Font-Names="Adobe Hebrew" Font-Size="X-Large" ForeColor="#7B9E46" Height="41px" Width="96px" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

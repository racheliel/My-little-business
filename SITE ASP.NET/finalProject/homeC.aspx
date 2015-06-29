<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homeC.aspx.cs" Inherits="finalProject.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style19 {
            width: 70px;
        }
        .auto-style20 {
            width: 1064px;
        }
        .auto-style21 {
            width: 70px;
            height: 30px;
        }
        .auto-style22 {
            width: 1064px;
            height: 30px;
        }
        .auto-style23 {
            height: 30px;
        }
    .auto-style24 {
        width: 70px;
        height: 62px;
    }
    .auto-style25 {
        width: 1064px;
        height: 62px;
    }
    .auto-style26 {
        height: 62px;
    }
        .auto-style27 {
            margin-left: 80px;
        }
        .auto-style28 {
            width: 512px;
        }
        .auto-style29 {
            width: 512px;
            height: 27px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="font-size: 25px; font-weight: 600; margin-left: 408px; margin-top: 19px; margin-bottom: 3px; " class="auto-style29">welcome
            <asp:Label ID="userName" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="auto-style27" colspan="2">&nbsp;<br />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="edit" runat="server" OnClick="edit_Click" Text="Edit my details" BackColor="#DADADA" Font-Bold="True" Font-Names="Adobe Hebrew" Font-Size="X-Large" ForeColor="#7B9E46" Height="31px" />
            &nbsp;
            <asp:Button ID="out" runat="server" OnClick="out_Click" Text="Sign Out" BackColor="#DADADA" Font-Bold="True" Font-Names="Adobe Hebrew" Font-Size="X-Large" ForeColor="#7B9E46" Height="31px" />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="myEve" runat="server" BackColor="#DADADA" ForeColor="#7B9E46" OnClick="myEve_Click" Text="To My Events" Width="169px" Font-Names="Adobe Hebrew" Font-Size="X-Large" Font-Bold="True" Height="31px" />
&nbsp;&nbsp;
                <asp:Button ID="myBus" runat="server" BackColor="#DADADA" Text="To My Business" Width="193px" OnClick="myBus_Click" Font-Bold="True" Font-Names="Adobe Hebrew" Font-Size="X-Large" ForeColor="#7B9E46" Height="31px" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style19">
                            <br />
                        </td>
                        <td class="auto-style20">
                            <asp:ImageButton ID="ImageButton1" runat="server" Height="47px" ImageUrl="boxH.png" Width="194px" OnClick="ImageButton1_Click" />
                            <asp:ImageButton ID="ImageButton2" runat="server" Height="47px" ImageUrl="boxS.png" Width="194px" OnClick="ImageButton2_Click" />
                            <asp:ImageButton ID="ImageButton3" runat="server" Height="47px" ImageUrl="boxM.png" Width="194px" OnClick="ImageButton3_Click" />
                            <asp:ImageButton ID="ImageButton4" runat="server" Height="47px" ImageUrl="boxA.png" Width="194px" OnClick="ImageButton4_Click" />
                            <asp:ImageButton ID="ImageButton5" runat="server" Height="47px" ImageUrl="boxC.png" Width="194px" OnClick="ImageButton5_Click" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style21"></td>
                        <td class="auto-style22">
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Timer ID="Timer" runat="server" Interval="2000" OnTick="Timer1_Tick1">
                                    </asp:Timer>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Image ID="Image1" runat="server" Height="193px" style="margin-right: 0px" Width="382px" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td class="auto-style23"></td>
                    </tr>
                    <tr>
                        <td class="auto-style24"></td>
                        <td class="auto-style25" style="width: 382px; margin-left: 408px; margin-top: 19px; margin-bottom: 3px; height: 27px; font-size: 20px; font-weight: 600;">
                            find business:<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="placeD" runat="server" AppendDataBoundItems="True" DataSourceID="PLACE" DataTextField="place" DataValueField="place" Height="56px" Width="121px">
                                <asp:ListItem>choose place</asp:ListItem>
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="PLACE" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT * FROM [Place]"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            <asp:DropDownList ID="categoryD" runat="server" AppendDataBoundItems="True" DataSourceID="CATEGORY" DataTextField="category" DataValueField="category" Height="55px" Width="122px">
                                <asp:ListItem>choose category</asp:ListItem>
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="CATEGORY" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="ImageButton6" runat="server" Height="35px" ImageUrl="serch.png" OnClick="ImageButton6_Click" Width="42px" />
                            <br />
                            <br />
&nbsp;&nbsp;&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BusName" DataSourceID="result0" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" Width="987px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField CommandName="linkRow" HeaderText="link do business page" Text="go to business page" />
                <asp:BoundField DataField="BusName" HeaderText="BusName" ReadOnly="True" SortExpression="BusName" />
                <asp:BoundField DataField="Place" HeaderText="Place" SortExpression="Place" />
                <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
            </Columns>
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
        &nbsp;&nbsp;&nbsp;
        <asp:SqlDataSource ID="result0" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT BusName, Place, Category FROM BusinessTable"></asp:SqlDataSource>
        <asp:SqlDataSource ID="result1" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT [BusName], [Place], [Category] FROM [BusinessTable] WHERE ([Place] = @Place)">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="choose place" Name="Place" SessionField="placeS" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="result2" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT [BusName], [Place], [Category] FROM [BusinessTable] WHERE ([Category] = @Category)">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="choose category" Name="Category" SessionField="categoryS" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="result3" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT [BusName], [Place], [Category] FROM [BusinessTable] WHERE (([Place] = @Place) AND ([Category] = @Category))">
            <SelectParameters>
                <asp:SessionParameter DefaultValue="choose place" Name="Place" SessionField="placeS" Type="String" />
                <asp:SessionParameter DefaultValue="choose category" Name="Category" SessionField="categoryS" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
                        </td>
                        <td class="auto-style26"></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
</asp:Content>

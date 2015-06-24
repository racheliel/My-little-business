<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="finalProject.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style18 {
            width: 490px;
        }
        .auto-style19 {
            width: 70px;
        }
        .auto-style20 {
            width: 1146px;
        }
        .auto-style21 {
            width: 70px;
            height: 30px;
        }
        .auto-style22 {
            width: 1146px;
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
        width: 1018px;
        height: 62px;
    }
        .auto-style27 {
            height: 24px;
        }
        .auto-style28 {
            height: 27px;
        }
        .auto-style29 {
            width: 1146px;
            height: 62px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="font-size: 20px; font-weight: 600; background-color: #C0C0C0; color: #000000">
        <table style="width:100%;">
            <tr>
                <td class="auto-style18" rowspan="3">Welcome Guest&nbsp;</td>
                <td>User Name:<asp:TextBox ID="UserName" runat="server"></asp:TextBox>
&nbsp;Password:<asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;
        <asp:Button ID="in" runat="server" Height="27px" OnClick="in_Click" Text="Sign In" Width="67px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Small" PostBackUrl="~/forgot.aspx">forgot your password?</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style27" style="font-size: medium">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Don&#39;t have an account?&nbsp;please&nbsp;<asp:Button ID="up" runat="server" OnClick="Button2_Click" Text="Sign Up" Height="27px" Width="66px" style="margin-left: 16px" />
                </td>
            </tr>
        </table>
    </div>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style20">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="47px" ImageUrl="boxH.png" Width="194px" />
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
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Image ID="Image1" runat="server" Height="193px" style="margin-right: 0px" Width="382px" />
                 <asp:Timer ID="Timer" runat="server" Interval="2000" OnTick="Timer1_Tick1">
                   </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
                </td>
                <td class="auto-style23"></td>
            </tr>
            <tr>
                <td class="auto-style24"></td>
                        <td class="auto-style29">find business:<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:DropDownList ID="placeD" runat="server" AppendDataBoundItems="True" DataSourceID="PLACE" DataTextField="place" DataValueField="place">
                                <asp:ListItem>choose place</asp:ListItem>
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="PLACE" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT * FROM [Place]"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            <asp:DropDownList ID="categoryD" runat="server" AppendDataBoundItems="True" DataSourceID="CATEGORY" DataTextField="category" DataValueField="category">
                                <asp:ListItem>choose category</asp:ListItem>
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="CATEGORY" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT * FROM [Category]"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="ImageButton6" runat="server" Height="35px" ImageUrl="serch.png" OnClick="ImageButton6_Click" Width="42px" />
                            <br />
                            <br />
&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BusName" DataSourceID="result0" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" Width="987px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
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
        &nbsp;&nbsp;
        <asp:SqlDataSource ID="result0" runat="server" ConnectionString="<%$ ConnectionStrings:MLBDBConnectionString %>" SelectCommand="SELECT [BusName], [Place], [Category] FROM [BusinessTable]"></asp:SqlDataSource>
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
                            <asp:Label ID="Label1" runat="server" BackColor="Red" BorderColor="Red" Text="To get into the business you need to log in"></asp:Label>
                </td>
                        <td class="auto-style25">
                            &nbsp;</td>
            </tr>
        </table>
    </p>
    <p style="margin-top: 0px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>

</asp:Content>

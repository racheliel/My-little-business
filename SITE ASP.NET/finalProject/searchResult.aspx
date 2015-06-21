<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="searchResult.aspx.cs" Inherits="finalProject.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        search result:</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BusName" DataSourceID="result0" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="BusName" HeaderText="BusName" ReadOnly="True" SortExpression="BusName" />
                <asp:BoundField DataField="Place" HeaderText="Place" SortExpression="Place" />
                <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
            </Columns>
        </asp:GridView>
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
    </p>
</asp:Content>

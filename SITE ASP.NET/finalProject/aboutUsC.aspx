<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="aboutUsC.aspx.cs" Inherits="finalProject.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

    .auto-style14 {
        width: 70px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="background-color: #FFFFFF; color: #000000; font-size: 20px; font-weight: 700;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="out" runat="server" OnClick="out_Click" Text="Sign Out" BorderColor="#DADADA" Font-Bold="True" Font-Names="adobe hebrew" Font-Size="Large" ForeColor="#7B9E46" Height="30px" Width="113px" style="margin-left: 5px" />
                <br />
                <br />
                welcome
            <asp:Label ID="userName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style14">&nbsp;</td>
                        <td>
                            <asp:ImageButton ID="ImageButton1" runat="server" Height="47px" ImageUrl="boxH.png" Width="194px" OnClick="ImageButton1_Click" />
                            <asp:ImageButton ID="ImageButton2" runat="server" Height="47px" ImageUrl="boxS.png" Width="194px" OnClick="ImageButton2_Click" />
                            <asp:ImageButton ID="ImageButton3" runat="server" Height="47px" ImageUrl="boxM.png" Width="194px" OnClick="ImageButton3_Click" />
                            <asp:ImageButton ID="ImageButton4" runat="server" Height="47px" ImageUrl="boxA.png" Width="194px" OnClick="ImageButton4_Click" />
                            <asp:ImageButton ID="ImageButton5" runat="server" Height="47px" ImageUrl="boxC.png" Width="194px" OnClick="ImageButton5_Click" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style14">&nbsp;</td>
                        <td style="font-family: Georgia, 'Times New Roman', Times, serif; font-size: 27px">
                </li>
                            <br />Our project is made for small business owners who wants to publish their business, For fairs organizers who wants to find potential business that are interested in participating in the fair, and for costumers who are interested in buying/ordering a product or a service. 
                            <br />
                            The project &quot;my little business&quot; is a web application that contains all the little businesses and fairs in one place, such that small businesses can be found easily by new costumers, it can be contacted and compared with other small businesses, in addition, the business can find and register itself to future fairs all over the country. Unlike the yellow pages, our project can group all the fairs in one place, and it is possible to register to it easily and comfortably.<br />
&nbsp;The costumers can contact the business directly from the system in order to get price suggestions and details and don&#39;t have to call in order to get them.</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style14">&nbsp;</td>
                        <td><a  href="https://github.com/racheliel/My-little-business/wiki" style="font-size: 26px; font-weight: 900">WIKI link</a></td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

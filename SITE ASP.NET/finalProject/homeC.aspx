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
            width: 371px;
            margin-left: 80px;
        }
        .auto-style28 {
            width: 326px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="background-color: #FFFFFF; color: #000000; font-size: 25px; font-weight: 700;" class="auto-style28">welcome
            <asp:Label ID="userName" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="auto-style27">&nbsp;<asp:Button ID="myEve" runat="server" BackColor="#66FF66" ForeColor="Black" OnClick="myEve_Click" Text="My Events" Width="139px" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="myBus" runat="server" BackColor="#66FF66" Text="My Business" Width="131px" OnClick="myBus_Click" />
            </td>
            <td>
            <asp:Button ID="out" runat="server" OnClick="out_Click" Text="Sign Out" />
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
                        <td class="auto-style25">
                            <asp:TextBox ID="TextBox1" runat="server" Height="27px" TextMode="Search" Width="240px">find a business</asp:TextBox>
                            <asp:ImageButton ID="ImageButton6" runat="server" Height="27px" ImageUrl="serch.png" />
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

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
            width: 1018px;
        }
        .auto-style21 {
            width: 70px;
            height: 30px;
        }
        .auto-style22 {
            width: 1018px;
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
    .auto-style26 {
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
        <asp:Button ID="in" runat="server" Height="26px" OnClick="in_Click" Text="Sign In" Width="68px" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="forgot" runat="server" OnClick="Button1_Click" Text="forgot your password?" Width="230px" style="margin-bottom: 2px; margin-top: 2px;" Height="26px" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Don&#39;t have an account?&nbsp;<asp:Button ID="up" runat="server" OnClick="Button2_Click" Text="Sign Up" Height="26px" Width="68px" style="margin-left: 16px" />
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
                <td class="auto-style25">
                    <asp:TextBox ID="TextBox1" runat="server" Height="27px" TextMode="Search" Width="240px">find a business</asp:TextBox>
                    <asp:ImageButton ID="ImageButton6" runat="server" Height="27px" ImageUrl="serch.png" />
                </td>
                <td class="auto-style26"></td>
            </tr>
        </table>
    </p>
    <p style="margin-top: 0px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>

</asp:Content>

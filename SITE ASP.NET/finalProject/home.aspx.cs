/* It allows the user to login with a username and password or register*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        EventBL eBL = new EventBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "4.png";


        }


        protected void in_Click(object sender, EventArgs e)
        {
            string user = UserName.Text, password = Password.Text;
            Boolean bU = eBL.chackUser(user);
            if (bU)
            {
                Users u = eBL.signIn(password, user);
                if (u != null)
                {
                    Session.Add("user", u.UserName);
                    Session.Add("first", u.FirstName);
                    Session.Add("last", u.LastName);
                    Session.Add("connect", true);
                    Response.Redirect("~/homeC.aspx");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(),"scripts","<script>alert('The password is incorrect, please re-enter your password')</script>");
                }
            }
            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('The user name is incorrect, please re-enter your user name')</script>");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/signUp.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/forgot.aspx");

        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            if (ViewState["imageDisploy"] == null)
            {
                Image1.ImageUrl = "1.png";
                ViewState["imageDisploy"] = 1;
            }
            else
            {
                int i = (int)ViewState["imageDisploy"];
                if (i == 4)
                {
                    Image1.ImageUrl = "1.png";
                    ViewState["imageDisploy"] = 1;
                }
                else
                {
                    i++;
                    Image1.ImageUrl = i.ToString() + ".png";
                    ViewState["imageDisploy"] = i;
                }
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('You most login')</script>");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('You most login')</script>");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/aboutUs.aspx");

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {

        }



    }
}
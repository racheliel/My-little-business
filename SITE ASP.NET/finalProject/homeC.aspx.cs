using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.ImageUrl = "4.png";
            userName.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
            if(userName.Text == "")
                Response.Redirect("~/home.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if ((string)(Session["first"]) != "Guest")
                Response.Redirect("~/salesE.aspx");

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            if ((string)(Session["first"]) != "Guest")  
                Response.Redirect("~/aboutUsC.aspx");

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {

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

        protected void out_Click(object sender, EventArgs e)
        {
            Session.Add("user", "");
            Session.Add("first", "Guest");
            Session.Add("last", "");
            Response.Redirect("~/home.aspx");
        }

        protected void myEve_Click(object sender, EventArgs e)
        {
            if ((string)(Session["first"]) != "Guest")
                Response.Redirect("~/myEvent.aspx");
        }

        protected void myBus_Click(object sender, EventArgs e)
        {
            Business b = eBL.getBusinessForUser((string)(Session["user"]));
            if(b!=null)
                Response.Redirect("~/businessShow.aspx");
            else
                Response.Redirect("~/myBusiness.aspx");


        }





    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('You most login')</script>");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if ((string)(Session["first"]) != "Guest")
                Response.Redirect("~/salesE.aspx");
            else
                 Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('You most login')</script>");
        }


        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            if ((string)(Session["first"]) != "Guest")
            {
                Response.Redirect("~/contactUs.aspx");
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if ((string)(Session["first"]) != "Guest")
                Response.Redirect("~/homeC.aspx");
            else
                Response.Redirect("~/home.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userName.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/homeC.aspx");

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/salesE.aspx");

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/aboutUsC.aspx");

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}
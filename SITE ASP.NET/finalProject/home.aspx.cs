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
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Please enter a valid password.')</script>");
                }
            }
            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Please enter a valid user name.')</script>");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/signUp.aspx");

        }


        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            if (ViewState["imageDisplay"] == null)
            {
                Image1.ImageUrl = "1.png";
                ViewState["imageDisplay"] = 1;
            }
            else
            {
                int i = (int)ViewState["imageDisplay"];
                if (i == 4)
                {
                    Image1.ImageUrl = "1.png";
                    ViewState["imageDisplay"] = 1;
                }
                else
                {
                    i++;
                    Image1.ImageUrl = i.ToString() + ".png";
                    ViewState["imageDisplay"] = i;
                }
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Please login')</script>");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Please login')</script>");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/aboutUs.aspx");

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/contactUs.aspx");
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Session.Add("placeS", "");
            Session.Add("categoryS", "");
            Boolean p = false, c = false;
            if (placeD.Text != "choose place")
            {
                p = true;
                Session.Add("placeS", placeD.Text);
            }
            if (categoryD.Text != "choose category")
            {
                c = true;
                Session.Add("categoryS", categoryD.Text);
            }
            if (c && p)
                Session.Add("defS", "p&c");
            else if (!c && p)
                Session.Add("defS", "p");
            else if (c && !p)
                Session.Add("defS", "c");
            else if (!c && !p)
                Session.Add("defS", "none");

            if (((string)(Session["defS"])) == "p&c")
                GridView1.DataSourceID = result3.ID;

            else if (((string)(Session["defS"])) == "p")
                GridView1.DataSourceID = result1.ID;

            else if (((string)(Session["defS"])) == "c")
                GridView1.DataSourceID = result2.ID;

            else if (((string)(Session["defS"])) == "none")
                GridView1.DataSourceID = result0.ID;

            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void placeD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
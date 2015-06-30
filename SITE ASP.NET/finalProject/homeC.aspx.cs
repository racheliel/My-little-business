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
        string user,first,last;
        int colName =1;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (string)(Session["user"]);
            first = (string)(Session["first"]);
            last = (string)(Session["last"]);
            
            userName.Text =  first+ " " +last ;
            if (userName.Text == " " || (string)(Session["first"]) == "Guest")
                Response.Redirect("~/home.aspx");
            Image1.ImageUrl = "4.png";
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

            Response.Redirect("~/myFavorit.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

            Response.Redirect("~/aboutUsC.aspx");

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {

            Response.Redirect("~/contactUsC.aspx");

        }

        protected void out_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/home.aspx");
        }

        protected void myEve_Click(object sender, EventArgs e)
        {

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

        protected void edit_Click(object sender, EventArgs e)
        {
                Session.Add("user", user);
                Session.Add("first", first);
                Session.Add("last", last);
                string mail = eBL.getMail(user);
                Session.Add("mail", mail);
                Response.Redirect("~/editUser.aspx");
            
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
            else if(!c && !p)
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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName.CompareTo("linkRow") == 0)
            {
                int row = int.Parse(e.CommandArgument.ToString());
                string name = GridView1.Rows[row].Cells[colName].Text.Trim();

             
                    Session.Add("nameBuss", name);

                    Response.Redirect("~/business.aspx");
                

            }
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
                    Image1.ImageUrl = eBL.getAllImageLogo();
                    ViewState["imageDisplay"] = i;
                }
            }
        }



    }
}
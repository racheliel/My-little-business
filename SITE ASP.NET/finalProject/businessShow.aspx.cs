using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace finalProject
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\GitHub\\My-little-business\\SITE ASP.NET\\MLBDB.mdf;Integrated Security=True;Connect Timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {
            Business b = eBL.getBusinessForUser((string)(Session["user"]));
            if (b == null)
            {
                edit.Visible = false;
            }
            else
            {
                edit.Visible = true;
                busName.Text = b.BusName;
                place.Text = b.Place;
                det.Text = b.Detailes;
                SqlDataAdapter da = new SqlDataAdapter("select image from uplodes where BusName='" + busName.Text + "';", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                DataBind();
                logo.ImageUrl = eBL.getImageLogo(busName.Text);
                string str = "";
                LinkedList<Feedback> feedback = eBL.getFeedback(b.BusName);
                if (feedback.Count() != 0)
                { 
                     foreach (Feedback i in feedback)
                     {
                       str += i.Strfeedback + " from: " + i.UserName + '\n'; 
                     }
                }



            }
    
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/myBusiness.aspx");
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/homeC.aspx");

        }

        protected void getF_Click(object sender, EventArgs e)
        {
            if (getF.Text != "" && busName.Text!="")
            {
                Feedback f = new Feedback((string)(Session["user"]), busName.Text, getF.Text);
               eBL.addFeedback(f);
               Response.Redirect("~/businessShow.aspx");
            }
            else
            {
                errorText.Text = "please fill the feedback";
            }
        }
    }
}
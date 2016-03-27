using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace finalProject
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MLBDBConnectionString"].ConnectionString);
        string user, busN;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (string)(Session["user"]);
            userName.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
            if (userName.Text == " " || (string)(Session["first"]) == "Guest")
                Response.Redirect("~/home.aspx");
            Business b = eBL.getBusinessForUser(user);

            if (b == null)
            {
                edit.Visible = false;
                del.Visible = false;
                busN = (string)(Session["nameBuss"]);
            }
            else
            {
                busN = b.BusName;
                edit.Visible = true;
                busName.Text = b.BusName;
                place.Text = b.Place;
                category.Text = b.Category;
                det.Text = b.Detailes;
                SqlDataAdapter da = new SqlDataAdapter("select image from uplodes where BusName='" + busName.Text + "';", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                DataBind();
                logo.ImageUrl = eBL.getImageLogo(busName.Text);

                LinkedList<Feedback> feedback = eBL.getFeedback(busName.Text);
                DataTable dt1 = new DataTable();
                dt1.Columns.Add("Feedback:", typeof(string));
                //            dt1.Columns.Add("stars:", typeof(string));
                dt1.Columns.Add("From:", typeof(string));
                int count = -1;//check if exist event
                foreach (Feedback i in feedback)
                {
                    count = 0;
                    DataRow row1 = dt1.NewRow();
                    row1["Feedback:"] = i.Strfeedback;
                    row1["From:"] = i.UserName;
                    errorText.Text = "";
                    dt1.Rows.Add(row1);

                }

                if (count == -1)
                {
                    errorText.Text = "";
                }
                else
                {
                    errorText.Text = "";

                }

                table1.DataSource = dt1;
                table1.DataBind();


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

       
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {


        }
        protected void table1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void del_Click(object sender, EventArgs e)
        {
        
            errorText.Text = "Are you sure that you want delete this page?";
            YES.Visible = true;
            no.Visible = true;

        }

        protected void no_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/businessShow.aspx");
        }

        protected void YES_Click(object sender, EventArgs e)
        {
            eBL.deleteFavoritByBuss(busN);
            eBL.deleteFeedbackByBuss(busN);
            eBL.deleteLogosByBuss(busN);
            eBL.deleteUpdateByBuss(busN);
            eBL.deleteBusiness(busN);
            Response.Redirect("~/homeC.aspx");
        }

        protected void addFav_Click(object sender, EventArgs e)
        {
         
            Favorit f = new Favorit(user, busN);
            try
            {
                eBL.addFavorit(f);
                favText.Text = "Adding succeeded favorites";
            }
            catch
            {
                favText.Text = "This page exists in favorites";
            }
        }
    }
}

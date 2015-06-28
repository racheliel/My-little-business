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
    public partial class business : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MLBDBConnectionString"].ConnectionString);
        string  busN;
        string user,first,last;       


        protected void Page_Load(object sender, EventArgs e)
        {
            user = (string)(Session["user"]);
            first = (string)(Session["first"]);
            last = (string)(Session["last"]);

            userName.Text = first + " " + last;
            if (userName.Text == " " || (string)(Session["first"]) == "Guest")
                Response.Redirect("~/home.aspx");


            Business b = eBL.getBusiness((string)(Session["nameBuss"]));

            if (b == null)
            {

                busName.Text = "error";
            }
            else
            {
                if(user == b.UserName)
                {
                    TextBox1.Visible = false;
                    getF.Visible = false;
                }
                busN = b.BusName;
                busName.Text = busN;
                place.Text = b.Place;
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

        protected void getF_Click(object sender, EventArgs e)
        {
            if (getF.Text != "" && busName.Text != "")
            {
                Feedback f = new Feedback(user, busN, TextBox1.Text);
                try
                {
                    eBL.addFeedback(f);
                    Response.Redirect("~/business.aspx");
                }
                catch
                {
                    errorText.Text = "Feedback has been entering this business";
                }
            }
            else
            {
                errorText.Text = "please fill the feedback";
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {


        }
        protected void table1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void addFav_Click(object sender, EventArgs e)
        {
            Favorit f = new Favorit(user, busN);
            try { 
            eBL.addFavorit(f);
            favText.Text = "Adding succeeded favorites";
            }
            catch
            {

                favText.Text = "This page exists in favorites";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
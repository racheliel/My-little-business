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
        string user,busN;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (string)(Session["user"]);
            Business b = eBL.getBusinessForUser(user);
            busN = b.BusName;
            if (b == null)
            {
                edit.Visible = false;
                del.Visible = false;
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
                    errorText.Text = "There are no planned events";
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
            if (getF.Text != "" && busName.Text!="")
            {
                Feedback f = new Feedback(user, busN, getF.Text);
               eBL.addFeedback(f);
               Response.Redirect("~/businessShow.aspx");
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

        protected void del_Click(object sender, EventArgs e)
        {
           // Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>if(!window.confirm('Are you sure?')){window.location.href='businessShow.aspx'}else{eBL.deleteBusiness(busN)}</script>");
            errorText.Text = "Are you sure?";
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
    }
}

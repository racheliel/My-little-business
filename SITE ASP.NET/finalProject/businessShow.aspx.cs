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
            }
    
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/myBusiness.aspx");
        }
<<<<<<< HEAD

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
            //   Response.Redirect("~/businessShow.aspx");
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

        protected void favButt_Click(object sender, EventArgs e)
        {
            
            Favorit f = new Favorit(user,busN);
            try
            {
                eBL.addFavorit(f);
                favText.Text = "Added success!";
            }
            catch
            {
                favText.Text = "try again...";
            }
        }
=======
>>>>>>> origin/master
    }
}

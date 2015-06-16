/*This page contains the list of events of the logged in user and gives him the option to add an event, edit or delete event*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject
{
    public partial class salesE : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();
        int colUser=5;
        protected void Page_Load(object sender, EventArgs e)
        {
            userName.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
            LinkedList<Events> userEvents = eBL.getAllEvents();
            DataTable dt = new DataTable();
            dt.Columns.Add("event's name", typeof(string));
            dt.Columns.Add("event's category", typeof(string)); 
            dt.Columns.Add("event's date", typeof(DateTime));
            dt.Columns.Add("event's place", typeof(string));
            dt.Columns.Add("event's Admin", typeof(string)); 
            int count = -1;//check if exist event
            foreach (Events i in userEvents)
            {
                count = 0;
            DataRow row1 = dt.NewRow();
            row1["event's name"] = i.Name;
            row1["event's category"] = i.Catgory;
            row1["event's date"] = i.Date_time;
            row1["event's place"] = i.Place;
            row1["event's Admin"] = i.UserName;
            dt.Rows.Add(row1);
            }
            if (count== -1)
            {
                noEvents.Visible = true;
                noEvents.Text = "There are no planned events";
            }
            else
            {
                noEvents.Text = "";
                noEvents.Visible = false;
            }

            table.DataSource = dt;
            table.DataBind();
        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.CompareTo("Invitation") == 0)
            {
                int row = int.Parse(e.CommandArgument.ToString());
                string user = table.Rows[row].Cells[colUser].Text.Trim();
                string mail = eBL.getMail(user);

                Session.Add("mail", mail);
                Response.Redirect("~/Invitation.aspx");

            }

        }

        protected void out_Click(object sender, EventArgs e)
        {
            Session.Add("user", "");
            Session.Add("first", "Guest");
            Session.Add("last", "");
            Response.Redirect("~/home.aspx");

        }


        protected void addE_Click1(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if ((string)(Session["first"]) != "Guest")
                Response.Redirect("~/homeC.aspx");
            else
                Response.Redirect("~/home.aspx");

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
            if ((string)(Session["first"]) != "Guest")
            {
                Response.Redirect("~/contactUs.aspx");
            }
        }


    }   
}

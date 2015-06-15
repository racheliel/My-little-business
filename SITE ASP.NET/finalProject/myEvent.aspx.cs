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
    public partial class WebForm5 : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();
        int colName = 2, colDate = 4, colPlace = 5 , colCat=3;
        protected void Page_Load(object sender, EventArgs e)
        {
            userName.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
            LinkedList<Events> userEvents = eBL.getEvents((string)(Session["user"]));
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

            if (e.CommandName.CompareTo("deleterow") == 0)
            {
                int row = int.Parse(e.CommandArgument.ToString());
                string name = table.Rows[row].Cells[colName].Text.Trim();
                string cat = table.Rows[row].Cells[colCat].Text.Trim();
                string place = table.Rows[row].Cells[colPlace].Text.Trim();
                string dateString = table.Rows[row].Cells[colDate].Text.Trim();
                DateTime d = Convert.ToDateTime(dateString);

                eBL.deleteEvent( d, (string)(Session["user"]), place,name,cat);
                Response.Redirect("~/myEvent.aspx");

            }
            if (e.CommandName.CompareTo("edit") == 0)
            {
                int row = int.Parse(e.CommandArgument.ToString());
                string name = table.Rows[row].Cells[colName].Text.Trim();
                string cat = table.Rows[row].Cells[colCat].Text.Trim();
                string place = table.Rows[row].Cells[colPlace].Text.Trim();
                string dateString = table.Rows[row].Cells[colDate].Text.Trim();
                DateTime d = Convert.ToDateTime(dateString);

                Session.Add("date", d);
                Session.Add("name", name);
                Session.Add("cat", cat);
                Session.Add("place",place);
                Session.Add("day", dateString.Substring(0, 2));
                Session.Add("mounth", dateString.Substring(3, 2));
                Session.Add("year", dateString.Substring(6, 4));
                Session.Add("hour", dateString.Substring(11, 2));
                Session.Add("minutes", dateString.Substring(14, 2));
                Session.Add("firstTime", "y");

                Response.Redirect("~/editEvent.aspx");

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
            try
            {
          //      if ((string)(Session["first"]) != "Guest" && (string)(Session["connect"]) != "false")
                {
                    Session.Add("addError", "0");
                    Response.Redirect("~/addEvent.aspx");
                }
            }
            catch
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('You most login')</script>");

            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if ((string)(Session["first"]) != "Guest")
                Response.Redirect("~/homeC.aspx");

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            if ((string)(Session["first"]) != "Guest")
                Response.Redirect("~/aboutUsC.aspx");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {

        }


    }   
}

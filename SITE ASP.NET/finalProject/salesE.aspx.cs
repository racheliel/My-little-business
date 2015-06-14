﻿/*This page contains the list of events of the logged in user and gives him the option to add an event, edit or delete event*/
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
        int colName = 3, colDate = 4, colPlace = 5;
        protected void Page_Load(object sender, EventArgs e)
        {
            userName.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
            LinkedList<UsersEvents> userEvents = eBL.getUsersEvents((string)(Session["user"]));
            DataTable dt = new DataTable();
            dt.Columns.Add("event's name", typeof(string)); 
            dt.Columns.Add("event's date", typeof(DateTime));
            dt.Columns.Add("event's place", typeof(string));
            int count = -1;//check if exist event
            foreach (UsersEvents i in userEvents)
            {
                count = 0;
            DataRow row1 = dt.NewRow();
            string str = eBL.getTypeEvent(i.EventID);
            row1["event's name"] = str;
            row1["event's date"] = i.Date_time;
            row1["event's place"] = i.Place;
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
                string place = table.Rows[row].Cells[colPlace].Text.Trim();
                string dateString = table.Rows[row].Cells[colDate].Text.Trim();
                DateTime d = Convert.ToDateTime(dateString);
                int num = eBL.getIDEvent(name);
                eBL.deleteUserEvent(num, d, (string)(Session["user"]), place);
                Response.Redirect("~/connect.aspx");

            }
            if (e.CommandName.CompareTo("edit") == 0)
            {
                int row = int.Parse(e.CommandArgument.ToString());
                string name = table.Rows[row].Cells[colName].Text.Trim();
                string place = table.Rows[row].Cells[colPlace].Text.Trim();
                string dateString = table.Rows[row].Cells[colDate].Text.Trim();
                DateTime d = Convert.ToDateTime(dateString);
                int num = eBL.getIDEvent(name);
                Session.Add("date", d);
                Session.Add("type", name);
                Session.Add("typeID", num);
                Session.Add("place",place);
                Session.Add("day", dateString.Substring(0, 2));
                Session.Add("mounth", dateString.Substring(3, 2));
                Session.Add("year", dateString.Substring(6, 4));
                Session.Add("hour", dateString.Substring(11, 2));
                Session.Add("minutes", dateString.Substring(14, 2));
                Session.Add("firstTime", "y");

                Response.Redirect("~/editEvent.aspx");

            }
            if (e.CommandName.CompareTo("Invitation") == 0)
            {
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
            try
            {
                if ((string)(Session["first"]) != "Guest" && (string)(Session["connect"]) != "false")
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

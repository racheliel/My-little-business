/*It allows the user to edit an existing event*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            userName.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
            if (userName.Text == " " || (string)(Session["first"]) == "Guest")
                Response.Redirect("~/home.aspx");
          if ((string)(Session["firstTime"]) == "y")
          {
            int i, num = 2015;
            for (i = 0; i <= 110; i++)
            {
                year.Items.Add("" + num);
                num++;
            }
            num = 0;
            for (i = 0; i < 24; i++)
            {
                if (num > 9)
                    hour.Items.Add("" + num);
                else
                    hour.Items.Add("0" + num);
                num++;
            }
            num = 0;
            for (i = 0; i < 60; i++)
            {
                if (num > 9)
                    minutes.Items.Add("" + num);
                else
                    minutes.Items.Add("0" + num);
                num++;
            }

            name.Text = (string)(Session["name"]);
                month.Text = (string)(Session["mounth"]);
                day.Text = (string)(Session["day"]);
                year.Text = (string)(Session["year"]);
                hour.Text = (string)(Session["hour"]);
                minutes.Text = (string)(Session["minutes"]);

          }
           
      


        }




        protected void signUp_Click(object sender, EventArgs e)
        {
            try
            {
                eBL.deleteEvent((DateTime)(Session["date"]), (string)(Session["user"]), (string)(Session["place"]), (string)(Session["name"]), (string)(Session["cat"]));

                int y = Convert.ToInt32(year.Text), m = Convert.ToInt32(month.Text), d = Convert.ToInt32(day.Text);
                int h = Convert.ToInt32(hour.Text), mi = Convert.ToInt32(minutes.Text);
                DateTime time = new DateTime(y, m, d, h, mi, 0);

                eBL.createEvent((string)(Session["user"]), time, placeD.Text, name.Text, categoryD.Text);
                Response.Redirect("~/myEvent.aspx");
            }
            catch
            {
                if (year.Text.Equals("year") || month.Text.Equals("month") || day.Text.Equals("day") || hour.Text.Equals("hour") || minutes.Text.Equals("minutes") || name.Text.Equals("") || categoryD.Text.Equals("choose category") || placeD.Text.Equals("choose place"))
                {
                    error.Text = "Event not edited, please fill in all tabs";


                }
                else
                {
                    error.Text = "Event not edited, please chack if all fields are correct";

                }
            }
        }

    }
}
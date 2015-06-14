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
            LinkedList<string> typeE = eBL.getAllEventType();
            foreach (string j in typeE)
            {
                type.Items.Add(j);
            }

                type.Text = (string)(Session["type"]);
                place.Text = (string)(Session["place"]);
                month.Text = (string)(Session["mounth"]);
                day.Text = (string)(Session["day"]);
                year.Text = (string)(Session["year"]);
                hour.Text = (string)(Session["hour"]);
                minutes.Text = (string)(Session["minutes"]);
                if ((string)(Session["type"]) == "Brit")
                    Image.ImageUrl = "4.jpg";
                if ((string)(Session["type"]) == ("Brita"))
                    Image.ImageUrl = "6.jpg";
                if ((string)(Session["type"]) == ("Bar Mitzvah"))
                    Image.ImageUrl = "3.jpg";
                if ((string)(Session["type"]) == ("Bat Mitzvah"))
                    Image.ImageUrl = "5.jpg";
                if ((string)(Session["type"]) == ("Birthday"))
                    Image.ImageUrl = "2.jpg";
                if ((string)(Session["type"]) == ("Wedding"))
                    Image.ImageUrl = "1.jpg";
                if ((string)(Session["type"]) == ("Other"))
                    Image.ImageUrl = "7.jpg";
                Session.Add("firstTime", "Ny");
          }
           
      


        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                eBL.deleteUserEvent((int)(Session["typeID"]), (DateTime)(Session["date"]), (string)(Session["user"]), (string)(Session["place"]));

                int y = Convert.ToInt32(year.Text), m = Convert.ToInt32(month.Text), d = Convert.ToInt32(day.Text);
                int h = Convert.ToInt32(hour.Text), mi = Convert.ToInt32(minutes.Text);
                DateTime time = new DateTime(y, m, d, h, mi, 0);
                if(place.Text.CompareTo("")==0)
                {
                    place.Text = " ";
                }
                eBL.createUserEvent((string)(Session["user"]), eBL.getIDEvent(type.Text), time, place.Text);
                Response.Redirect("~/connect.aspx");
            }
            catch
            {
                if (year.Text.Equals("year") || month.Text.Equals("month") || day.Text.Equals("day") || hour.Text.Equals("hour") || minutes.Text.Equals("minutes") || type.Text.Equals("type"))
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
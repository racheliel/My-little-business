/* This page allows to add a new event the user is connected*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)(Session["addError"])=="0")//eddError-check if this the first time that we enter the page
            {
                Image1.ImageUrl = "4.png";
                error.Text = "";
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

                Session.Add("addError", "1");

            }  
    

        }

        protected void add_Click(object sender, EventArgs e)
        {
          //  try
            {
                int y = Convert.ToInt32(year.Text), m = Convert.ToInt32(month.Text), d = Convert.ToInt32(day.Text);
                int h = Convert.ToInt32(hour.Text), mi = Convert.ToInt32(minutes.Text);
                DateTime time = new DateTime(y, m, d, h, mi, 0);
            

                eBL.createEvent((string)(Session["user"]), time, placeD.Text,name.Text,categoryD.Text);
                Response.Redirect("~/myEvent.aspx");
            }
           // catch
           /* {
                if (placeD.Text.Equals("choose place") || year.Text.Equals("year") || month.Text.Equals("month") || day.Text.Equals("day") || hour.Text.Equals("hour") || minutes.Text.Equals("minutes") || name.Text.Equals("") || categoryD.Text.Equals("choose category"))
                {
                    error.Text = "Please fill all tabs.";
                }
                else
                {
                    error.Text = "Please insert correct values";

                }
            }*/
 
        }

        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            if (ViewState["imageDisplay"] == null)
            {
                Image1.ImageUrl = "1.jpg";
                ViewState["imageDisplay"] = 1;
            }
            else
            {
                int i = (int)ViewState["imageDisplay"];
                if (i == 7)
                {
                    Image1.ImageUrl = "1.jpg";
                    ViewState["imageDisplay"] = 1;
                }
                else
                {
                    i++;
                    Image1.ImageUrl = i.ToString() + ".jpg";
                    ViewState["imageDisplay"] = i;
                }
            }
        }

    }
}
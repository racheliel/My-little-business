/*It allows the user register*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int i, num = 1905;
            for (i = 0; i <= 110; i++)
            {
                year.Items.Add("" + num);
                num++;
            }
        }

        protected void signUp_Click(object sender, EventArgs e)
        {
            if (year.Text.Equals("year") || month.Text.Equals("month") || day.Text.Equals("day") || username.Text.Equals("") || password.Text.Equals("") || email.Text.Equals("") || firstname.Text.Equals("") || lastname.Text.Equals(""))
            {
                error.Text = "you most fill all the tabs";
            }
            else if(eBL.chackUser(username.Text))
            {
                error.Text = "this user name allready exist";
            }
            else
            {
                try
                {
                    int y = Convert.ToInt32(year.Text), m = Convert.ToInt32(month.Text), d = Convert.ToInt32(day.Text);
                    DateTime time = new DateTime(y, m, d);
                    eBL.addNewUser(username.Text, password.Text, email.Text, firstname.Text, lastname.Text, time);
                    Session.Add("user", username.Text);
                    Session.Add("first", firstname.Text);
                    Session.Add("last", lastname.Text);
                    Response.Redirect("~/connect.aspx");

                }
                catch
                {
                    error.Text = "the date isn't correct";

                }

            }
          
        }
    }
}
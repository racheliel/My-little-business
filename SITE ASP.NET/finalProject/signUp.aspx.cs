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
           
        }

        protected void signUp_Click(object sender, EventArgs e)
        {
            if (username.Text.Equals("") || password.Text.Equals("") || email.Text.Equals("") || firstname.Text.Equals("") || lastname.Text.Equals(""))
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
                    eBL.addUser(username.Text, password.Text, email.Text, firstname.Text, lastname.Text);
                    Session.Add("user", username.Text);
                    Session.Add("first", firstname.Text);
                    Session.Add("last", lastname.Text);

                    Response.Redirect("~/homeC.aspx");

                }
                catch
                {
                    error.Text = "the details isn't correct";

                }

            }
          
        }
    }
}
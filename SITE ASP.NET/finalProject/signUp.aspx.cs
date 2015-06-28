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
<<<<<<< HEAD
            if (eBL.checkStr(username.Text) == false)
            {
                error.Text = "Please write letters and numbers";
            }
            else if (username.Text.Equals("") || password.Text.Equals("") || email.Text.Equals("") || firstname.Text.Equals("") || lastname.Text.Equals(""))
=======
            if (eBL.checkUser(username.Text) && eBL.checkPassword(password.Text) && eBL.checkMail(email.Text) && !eBL.isNumerical(firstname.Text) && !eBL.isNumerical(lastname.Text))
>>>>>>> origin/master
            {
                eBL.updateUser(username.Text, password.Text,email.Text , firstname.Text, lastname.Text);
                Session.Add("user", username.Text);
                Session.Add("first", firstname.Text);
                Session.Add("last", lastname.Text);

                Response.Redirect("~/homeC.aspx");
               
            }
            else
            {
                if (!eBL.checkPassword(password.Text))   { error.Text = "invalid password.";     }
                if (!eBL.checkMail(email.Text))          { error.Text = "invalid email.";        }
                if (eBL.isNumerical(firstname.Text))     { error.Text = "first name not valid."; }
                if (eBL.isNumerical(lastname.Text))      { error.Text = "last name not valid.";  }

            }
            }
    }
}
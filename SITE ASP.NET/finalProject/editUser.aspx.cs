using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject
{
    public partial class editUser : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            userName.Text = (string)(Session["user"]);
            firstname.Text = (string)(Session["first"]);
            lastname.Text = (string)(Session["last"]);
            email.Text = (string)(Session["mail"]);

            name.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
            if (userName.Text == " " || (string)(Session["first"]) == "Guest")
                Response.Redirect("~/home.aspx");

        }
        protected void del_Click(object sender, EventArgs e)
        {

            errorText.Text = "Are you sure?";
            YES.Visible = true;
            no.Visible = true;

        }

        protected void no_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/homeC.aspx");
        }

        protected void YES_Click(object sender, EventArgs e)
        {
            string user = userName.Text;
 
            string busN = eBL.getNameBusinessForUser(user);
            if (busN != "")
            {
                eBL.deleteFavoritByBuss(busN);
                eBL.deleteFeedbackByBuss(busN);
                eBL.deleteLogosByBuss(busN);
                eBL.deleteUpdateByBuss(busN);
                eBL.deleteBusiness(busN);
            }
            eBL.deleteEventByUser(user);
            eBL.deleteFavoritByUser(user);

            eBL.deleteUser(user);

            Response.Redirect("~/home.aspx");
        }

        protected void signUp_Click(object sender, EventArgs e)
        {
            if (eBL.checkPassword(password.Text) || eBL.checkMail(email.Text) || !eBL.isNumerical(firstname.Text) || !eBL.isNumerical(lastname.Text)
            {
                error.Text = "Please fill in all the tabs";
            }
            else
            {
                try
                {
                    eBL.updateUser(userName.Text, password.Text, firstname.Text, lastname.Text, email.Text);
                    Session.Add("user", userName.Text);
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
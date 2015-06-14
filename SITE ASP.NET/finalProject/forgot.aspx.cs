/*It allows the user restore the password for anyone who forgot a password by sending a password to the email recorded with*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace finalProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userN = userName.Text;
            Users user = eBL.getPassword(userN);
            if (user!=null)
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(user.EMail);
                mailMessage.From = new MailAddress("my.events.invitation@gmail.com");
                mailMessage.Subject = "your password to My-Events site";
                mailMessage.Body = "your password is: "+ user.Pass;
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 10000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("my.events.invitation@gmail.com", "hlamash1");
                smtpClient.Send(mailMessage);
                error.Text = "E-mail send!";
            }
            else
            {
                error.Text = "uncorrect user name!";
            }
        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/home.aspx");

        }





    }
}
/*It allows the user to send an invitation to miles*/
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
   
    public partial class WebForm1 : System.Web.UI.Page
    {
        string user, fromMail,toMail;
        EventBL eBL = new EventBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            user = (string)(Session["user"]);
            fromMail = eBL.getMail(user);
            toMail = (string)(Session["mail"]);
            to.Text = toMail;
            from.Text = fromMail;
        }

        protected void send_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(toMail);
                mailMessage.From = new MailAddress(fromMail);
                mailMessage.Subject = head.Text;
                mailMessage.Body = body.Text;
               SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);
               smtpClient.EnableSsl = true;
               smtpClient.Timeout = 10000;
               smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
               smtpClient.UseDefaultCredentials = false;
               smtpClient.Credentials = new NetworkCredential("MyLittleBusinessSite@gmail.com", "RMHU100rmhu");
               string strFileName = System.IO.Path.GetFileName(attachment.PostedFile.FileName);
               Attachment attachFile = new Attachment(attachment.PostedFile.InputStream, strFileName);
               mailMessage.Attachments.Add(attachFile);
               smtpClient.Send(mailMessage);
               error.Text = "E-mail send!";

            }
            catch 
            {
                error.Text = "E-mail don't send!";

            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/salesE.aspx");

        }




    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace finalProject
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\GitHub\\My-little-business\\SITE ASP.NET\\MLBDB.mdf;Integrated Security=True;Connect Timeout=30");
        protected void Page_Load(object sender, EventArgs e)
        {
            userName.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
            Business b = eBL.getBusinessForUser((string)(Session["user"]));
            if(b!=null)
            {
                busName.Text = b.BusName;
                chackBusName.Visible = false;
                SqlDataAdapter da = new SqlDataAdapter("select image from uplodes where BusName='"+busName.Text+"';", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                DataBind();
                ImgLogo.ImageUrl = eBL.getImageLogo(busName.Text);

            }
        }

        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {

        }

        protected void upImage_Click(object sender, EventArgs e)
        {
            if(FileUpload2.HasFile)
            {
                //upload images into database
                string str =busName.Text+ FileUpload2.FileName;
                FileUpload2.PostedFile.SaveAs(Server.MapPath(".") + "//uploads//" + str);
                string path = "~//uploads//" + str.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO uplodes (image,BusName) VALUES('" + path + "','" + busName.Text + "');",con);
                cmd.ExecuteNonQuery();
                con.Close();

                //show images in table
                SqlDataAdapter da = new SqlDataAdapter("select image from uplodes where BusName='" + busName.Text + "';", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                DataBind();


            }
            else 
            {
                errorImage.Text = "upload faild";
            }
        }

      

        protected void chackBusName_Click(object sender, EventArgs e)
        {
            Boolean busN = eBL.chackBusinessName(busName.Text);
            if (busN == true)
                errorName.Text = "Business name already exists in the system";
            else
                errorName.Text = "This illegal business name";
        }

        protected void addLogo_Click(object sender, EventArgs e)
        {
      
        }

        protected void save_Click(object sender, EventArgs e)
        {
            Boolean busN = eBL.chackBusinessName(busName.Text);
            Business b = new Business(busName.Text, (string)(Session["user"]), TextBox3.Text, TextBox2.Text);
            if (busN == true)
            {
                eBL.deleteBusiness(busName.Text);

            }
            eBL.addBusiness(b);

            Response.Redirect("~/homeC.aspx");

        }

        protected void addLogo_Click1(object sender, EventArgs e)
        {
        }

        protected void logoImage_Click(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile)
            {
                errorLogo.Text = "";
                //upload logo into database
                string str = busName.Text + FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "//logos//" + str);
                string path = "~//logos//" + str.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO logos (busName,logo) VALUES('" + busName.Text + "','" + path + "');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                ImgLogo.ImageUrl = path;
            }
            else
                errorLogo.Text = "error upload logo";

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            errorLogo.Text = TextBox3.Text;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.CompareTo("deleterow") == 0)
                 {
                     int row = int.Parse(e.CommandArgument.ToString());
                     string path =(string)(GridView1.Rows[row].Cells[0].Text.Trim());
                     eBL.deleteImage(path);
                 }


        }
    }
}
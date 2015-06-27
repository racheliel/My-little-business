using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace finalProject
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MLBDBConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            userName.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
            if (userName.Text == " " || (string)(Session["first"]) == "Guest")
                Response.Redirect("~/home.aspx");

            Business b = eBL.getBusinessForUser((string)(Session["user"]));
            if (b != null)
            {
                busName.Text = b.BusName;
                checkBusName.Visible = false;
                SqlDataAdapter da = new SqlDataAdapter("select image from uplodes where BusName='" + busName.Text + "';", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                DataBind();
                ImgLogo.ImageUrl = eBL.getImageLogo(busName.Text);

            }
            else 
                ImgLogo.ImageUrl = "logoBus.jpg";
            
        }

        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {

        }

        protected void upImage_Click(object sender, EventArgs e)
        {
            Boolean busN = eBL.checkBusinessName(busName.Text);
            if (busN == true)
            {

                if (FileUpload2.HasFile)
                {
                    //upload images into database
                    string str = busName.Text + FileUpload2.FileName;
                    FileUpload2.PostedFile.SaveAs(Server.MapPath(".") + "//uploads//" + str);
                    string path = "~//uploads//" + str.ToString();
                    
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO uplodes (image,BusName) VALUES('" + path + "','" + busName.Text + "');", con);
                     try
                    {   cmd.ExecuteNonQuery();
                        
                    }
                    catch
                    {   
                        con.Close();
                        errorImage.Text = "the photo exist in the business page";
                    }

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
            else
            {
                Business b = new Business(busName.Text, (string)(Session["user"]), TextBox3.Text, place.Text,category.Text);
                eBL.addBusiness(b);
                if (FileUpload2.HasFile)
                {
                    string str = busName.Text + FileUpload2.FileName;
                    FileUpload2.PostedFile.SaveAs(Server.MapPath(".") + "//uploads//" + str);
                    string path = "~//uploads//" + str.ToString();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO uplodes (image,BusName) VALUES('" + path + "','" + busName.Text + "');", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    errorImage.Text = "upload faild";
                }
            }
        }


      

        protected void checkBusName_Click(object sender, EventArgs e)
        {
            Boolean busN = eBL.checkBusinessName(busName.Text);
            if (busN == true)
                errorName.Text = "Business name already exists in the system";
            else
            {
                errorName.Text = "This illegal business name";
        /*        Business b = new Business(busName.Text, (string)(Session["user"]), TextBox3.Text, place.Text, category.Text);
                eBL.addBusiness(b);
                string l = eBL.getImageLogo(busName.Text);
                if (l == "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO logos (logo,busName) VALUES('logoBus.jpg','" + busName.Text + "');", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                */

            }
        }

        protected void addLogo_Click(object sender, EventArgs e)
        {
      
        }


        protected void addLogo_Click1(object sender, EventArgs e)
        {
        }

        protected void logoImage_Click(object sender, EventArgs e)
        {
            Boolean busN = eBL.checkBusinessName(busName.Text);
             if (busN == true)
             {

                 if (FileUpload1.HasFile)
                 {
                     errorLogo.Text = "";
                     //upload logo into database
                     string str = busName.Text + FileUpload1.FileName;
                     FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "//logos//" + str);
                     string path = "~//logos//" + str.ToString();
                     con.Open();
                     SqlCommand cmd = new SqlCommand("UPDATE logos SET logo= '" + path + "' WHERE busName='" + busName.Text + "';", con);
                     cmd.ExecuteNonQuery();
                     con.Close();
                     ImgLogo.ImageUrl = path;
                 }
                 else
                     errorLogo.Text = "error upload logo";
             }
             else
             {
                 Business b = new Business(busName.Text, (string)(Session["user"]), TextBox3.Text, place.Text, category.Text);
                 eBL.addBusiness(b);
                 ImgLogo.ImageUrl = "logoBus.jpg";
                 if (FileUpload1.HasFile)
                 {
                     errorLogo.Text = "";
                     //upload logo into database
                     string str = busName.Text + FileUpload1.FileName;
                     FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "//logos//" + str);
                     string path = "~//logos//" + str.ToString();
                     con.Open();
                    
                         SqlCommand cmd = new SqlCommand("INSERT INTO logos (logo,busName) VALUES('" + path + "','" + busName.Text + "');", con);
                    try
                     {  
                            cmd.ExecuteNonQuery();
                         er.Text = "";
                     }
                     catch
                     {
                         er.Text = "this photo name exist";
                     }
                     con.Close();
                     ImgLogo.ImageUrl = path;
                 }
                 else
                 {
                     errorImage.Text = "upload faild";
                 }
             }


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

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int row = int.Parse(e.RowIndex.ToString());
            string path = (string)(GridView1.Rows[row].Cells[2].Text.Trim());
            er.Text = path;
            eBL.deleteImage(path);
            Response.Redirect("~/myBusiness.aspx");


        }

        protected void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            Boolean busN = eBL.checkBusinessName(busName.Text);
            if ((busName.Text == "" || place.Text == "choose place" || category.Text == "choose category") && busN == false)
            {
                er.Text = "please fill business name,place and category";

            }
            else
            {
                Business b = new Business(busName.Text, (string)(Session["user"]), TextBox3.Text, place.Text, category.Text);
                if (busN == true)
                {
                    if (TextBox3.Text != "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE BusinessTable SET Detailes='" + TextBox3.Text + "' where UserName='" + (string)(Session["user"]) + "';", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (place.Text != "choose place")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE BusinessTable SET Place='" + place.Text + "' where UserName='" + (string)(Session["user"]) + "';", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (category.Text != "choose category")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE BusinessTable SET Category='" + category.Text + "' where UserName='" + (string)(Session["user"]) + "';", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    string l = eBL.getImageLogo(busName.Text);
                    if (l == "")
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO logos (logo,busName) VALUES('logoBus.jpg','" + busName.Text + "');", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                {
                    eBL.addBusiness(b);
                }

                Response.Redirect("~/businessShow.aspx");

            }
        }
    }
}
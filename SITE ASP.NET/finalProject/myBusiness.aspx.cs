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
          //  errorImage.Text = "";
            userName.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
            Business b = eBL.getBusinessForUser((string)(Session["user"]));
            if(b!=null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("image", typeof(string));
                busName.Text = b.BusName;
                chackBusName.Visible = false;
                ImgLogo.ImageUrl = eBL.getImageLogo(busName.Text);
                LinkedList<string> img = eBL.allImageForBusiness(b.BusName);
                foreach (string i in img)
                {
                    DataRow row1 = dt.NewRow();
                    row1["image"] = i;
                    dt.Rows.Add(row1);
                }

            }
        }

        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {

        }
            protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName.CompareTo("deleterow") == 0)
            {
                int row = int.Parse(e.CommandArgument.ToString());
                string name = table.Rows[row].Cells[4].Text.Trim();
                string cat = table.Rows[row].Cells[3].Text.Trim();
                string place = table.Rows[row].Cells[5].Text.Trim();
                string dateString = table.Rows[row].Cells[6].Text.Trim();
                DateTime d = Convert.ToDateTime(dateString);

                eBL.deleteEvent( d, (string)(Session["user"]), place,name,cat);
                Response.Redirect("~/myEvent.aspx");

            }
         }
        protected void upImage_Click(object sender, EventArgs e)
        {
            Boolean busN = eBL.chackBusinessName(busName.Text);
            if (busN == true)
            {

                if (FileUpload2.HasFile)
                {
                    //upload images into database
                    string str = busName.Text + FileUpload2.FileName;
                    FileUpload2.PostedFile.SaveAs(Server.MapPath(".") + "//uploads//" + str);
                    string path = "~//uploads//" + str.ToString();
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO uplodes (image,BusName) VALUES('" + path + "','" + busName.Text + "');", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch
                    {
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
                Business b = new Business(busName.Text, (string)(Session["user"]), TextBox3.Text, TextBox2.Text);
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
            if (busN == true)
            {
                if (TextBox3.Text != "" && TextBox2.Text != "")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE BusinessTable SET Detailes='" + TextBox3.Text + "', place='" + TextBox2.Text + "' where UserName='" + (string)(Session["user"]) + "';", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else if(TextBox2.Text!="")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE BusinessTable SET place='" + TextBox2.Text + "' where UserName='" + (string)(Session["user"]) + "';", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else if(TextBox3.Text!="")
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE BusinessTable SET Detailes='" + TextBox3.Text + "' where UserName='" + (string)(Session["user"]) + "';", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            Response.Redirect("~/businessShow.aspx");

        }

        protected void addLogo_Click1(object sender, EventArgs e)
        {
        }

        protected void logoImage_Click(object sender, EventArgs e)
        {
             Boolean busN = eBL.chackBusinessName(busName.Text);
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
                     SqlCommand cmd = new SqlCommand("UPDATE logos SET logo= '" + path + "' WHERE busName='"+busName.Text+"';", con);
                     cmd.ExecuteNonQuery();
                     con.Close();
                     ImgLogo.ImageUrl = path;
                 }
                 else
                     errorLogo.Text = "error upload logo";
             }
             else
             {
                 Business b = new Business(busName.Text, (string)(Session["user"]), TextBox3.Text, TextBox2.Text);
                 eBL.addBusiness(b);
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
                 {
                     errorImage.Text = "upload faild";
                 }
             }

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            errorLogo.Text = TextBox3.Text;
        }


        protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.CompareTo("deleterow") == 0)
            {
                int row = int.Parse(e.CommandArgument.ToString());
                string path = (string)(GridView1.Rows[row].Cells[1].Text.Trim());
                eBL.deleteImage(path);
                Response.Redirect("~/myBusiness.aspx");


            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string path = (string)(GridView1.Rows[e.RowIndex].Cells[1].Text.Trim());
            eBL.deleteImage(path);

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void table_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
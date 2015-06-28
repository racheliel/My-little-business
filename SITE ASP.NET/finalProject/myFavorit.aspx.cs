using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject
{
    public partial class myFavorit : System.Web.UI.Page
    {
        EventBL eBL = new EventBL();
        int colName = 2;
        protected void Page_Load(object sender, EventArgs e)
        {
            userName.Text = (string)(Session["first"]) + " " + (string)(Session["last"]);
            if (userName.Text == " " || (string)(Session["first"]) == "Guest")
                Response.Redirect("~/home.aspx");
            LinkedList<Favorit> allBuss = eBL.getFavorit((string)(Session["user"]));
            DataTable dt = new DataTable();
            dt.Columns.Add("business's name", typeof(string));
            int count = -1;//check if exist event
            foreach (Favorit i in allBuss)
            {
                count = 0;
                DataRow row1 = dt.NewRow();
                row1["business's name"] = i.BusName;

                dt.Rows.Add(row1);
            }
            if (count == -1)
            {
                noEvents.Visible = true;
                noEvents.Text = "There are no planned faivorit";
            }
            else
            {
                noEvents.Text = "";
                noEvents.Visible = false;
            }

            table.DataSource = dt;
            table.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void table_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName.CompareTo("deleterow") == 0)
            {
                int row = int.Parse(e.CommandArgument.ToString());
                string name = table.Rows[row].Cells[colName].Text.Trim();
                Favorit f = new Favorit((string)(Session["user"]), name);
                eBL.deleteFavorit(f);
                Response.Redirect("~/myFavorit.aspx");

            }
            if (e.CommandName.CompareTo("linkRow") == 0)
            {
                int row = int.Parse(e.CommandArgument.ToString());
                string name = table.Rows[row].Cells[colName].Text.Trim();

                Session.Add("nameBuss", name);

                Response.Redirect("~/business.aspx");

            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/homeC.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

                Response.Redirect("~/salesE.aspx");

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/myFavorit.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
                Response.Redirect("~/aboutUsC.aspx");

        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/contactUsC.aspx");
        }

        protected void out_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/home.aspx");
        }
    }
}
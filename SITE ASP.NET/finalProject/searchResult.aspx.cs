using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalProject
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (((string)(Session["defS"])) == "p&c")
                GridView1.DataSourceID = result3.ID;
            
            else if (((string)(Session["defS"])) == "p")
                GridView1.DataSourceID = result1.ID;
           
            else if (((string)(Session["defS"])) == "c")
                GridView1.DataSourceID = result2.ID;

            else if (((string)(Session["defS"])) == "none")
                GridView1.DataSourceID = result0.ID;

            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
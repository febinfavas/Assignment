using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthApp
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            if(Session["username"]== null)
            {
                Response.Redirect("Login.aspx");
            }
            LabeluserDetail.Text = (String)Session["username"];
        }

        protected void ButtonLogout_Click(object sender, EventArgs e) {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}
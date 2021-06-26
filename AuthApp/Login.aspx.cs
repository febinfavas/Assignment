using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AuthApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            LabelErrMsg.Visible = false;
        }

        protected void ButtonLogin_Click(object sender, EventArgs e) {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;initial catalog=AuthApp;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM UserTable WHERE username=@username AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, conn);
                sqlCmd.Parameters.AddWithValue("@username",TextBoxUserName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password",TextBoxPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["username"] = TextBoxUserName.Text.Trim();
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    LabelErrMsg.Text = "Invalid Login Credential !!";
                    LabelErrMsg.Visible = true;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AuthApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            LabelErrmsg2.Visible = false;
        }

        protected void ButtonLogin_Click(object sender, EventArgs e) {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;initial catalog=AuthApp;Integrated Security=True;");
            conn.Open();
           
            SqlCommand sqlCmd = new SqlCommand("INSERT INTO UserTable VALUES(@username,@password)", conn);
            sqlCmd.Parameters.AddWithValue("@username", TBUserName.Text.Trim());
            sqlCmd.Parameters.AddWithValue("@password", TBPassword.Text.Trim());
            sqlCmd.ExecuteNonQuery();
            sqlCmd.Dispose();
            conn.Close();
            LabelErrmsg2.Text = "Registration SuccessFull";
            LabelErrmsg2.Visible = true;
            clearFields();
        }

        public void clearFields() {
            TBUserName.Text = "";
            TBPassword.Text = "";
            TBConfirmPassword.Text = "";
        }
    }
} 
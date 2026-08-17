using System;
using System.Web.UI;

namespace second
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "admin@gmail.com" &&
                txtPassword.Text == "12345")
            {
                Session["User"] = txtEmail.Text;
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid Email or Password";
            }
        }
    }
}
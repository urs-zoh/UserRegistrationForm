using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserRegistrationForm
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                DateTime dateOfBirth;
                if (!DateTime.TryParse(txtDateOfBirth.Text, out dateOfBirth))
                {
                    lblMessage.Text = "Invalid Date of Birth!";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                string email = txtEmail.Text;
                string login = txtLogin.Text;
                string password = txtPassword.Text;

                //The saving to DB can be added here

                lblMessage.Text = "Registration Successful!";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                ClearFields();
            }
        }

        private void ClearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtDateOfBirth.Text = "";
            txtEmail.Text = "";
            txtLogin.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
    }
}
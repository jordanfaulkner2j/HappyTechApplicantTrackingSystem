using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicantTrackingSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            // validate login credentials
            if (LoginValidation.ValidateCredentials(textBoxEmail.Text, textBoxPassword.Text))
            {
                // hide current form
                this.Hide();

                // set default values for text boxes
                textBoxEmail.Text = "Employee Email";
                textBoxPassword.Text = "Password";
                // enable password visibility with null character
                textBoxPassword.PasswordChar = '\0';

                // create main form and open it
                using (Main MainApplication = new Main())
                    MainApplication.ShowDialog();

                // once main application closes, open login page again
                this.Show();
            }
            // else if credentials invalid
            else
            {
                // return error message
                MessageBox.Show("Please try again or contact your administrator.", "Invalid Credentials");
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            // if text box is empty or set to default, clear its content
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || textBoxEmail.Text == "Employee Email")
            {
                textBoxEmail.Clear();
            }

            // set font to default black color
            textBoxEmail.ForeColor = Color.Black;
            // clear error message
            errorProvider.SetError(textBoxEmail, string.Empty);
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            // disable login button until text box content is validated
            buttonLogIn.Enabled = false;

            // if text box for email is empty, display error and keep login button disabled
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                errorProvider.SetError(textBoxEmail, "Missing employee email!");
            }
            // else check if email contains @ character
            else
            {
                foreach (char character in textBoxEmail.Text)
                {
                    // if true, enable login button and quit validation
                    if (character == '@')
                    {
                        buttonLogIn.Enabled = true;
                        return;
                    }
                }

                // else change text box font color and display appropriate error message
                textBoxEmail.ForeColor = Color.DarkRed;
                errorProvider.SetError(textBoxEmail, "Please enter your full email address.");
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            // if password is not censored, clear content of text box and disable visibility
            if (textBoxPassword.PasswordChar != '*')
            {
                textBoxPassword.Clear();
                textBoxPassword.PasswordChar = '*';
            }

            // clear error message once entered
            errorProvider.SetError(textBoxPassword, string.Empty);
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            // disable login button until text box content is validated
            buttonLogIn.Enabled = false;

            // if text box for password is blank, display error
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                errorProvider.SetError(textBoxPassword, "Password is blank!");
            }
            // if text box is not empty and email text box has no errors active, enable login button
            else if (string.IsNullOrWhiteSpace(errorProvider.GetError(textBoxEmail)))
            {
                errorProvider.SetError(textBoxPassword, string.Empty);
                buttonLogIn.Enabled = true;
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // if user presses enter key once finished typing password
            if (e.KeyCode == Keys.Enter)
            {
                // check for missing credentials
                textBoxPassword_Leave(this, null);

                // if no errors active and login enabled, proceed with login
                if (buttonLogIn.Enabled == true)
                {
                    buttonLogIn.PerformClick();
                }
            }
        }
    }
}

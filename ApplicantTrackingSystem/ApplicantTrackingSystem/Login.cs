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
        // constant values for default text box fields
        private const string DEFAULT_EMAIL_TEXT = "Employee Email";
        private const string DEFAULT_PASSWORT_TEXT = "Password";

        // constant name of log file storing recent email addresses
        private const string MAIL_LOG_FILE = "mailLog.txt";
        // constant value for maximum number of items in combo box
        private const int MAIL_LOG_FILE_MAX = 3;

        public Login()
        {
            InitializeComponent();
            LoadDefaultSettings();
        }

        private void LoadDefaultSettings()
        {
            // set default value of email text box
            comboBoxEmail.Text = DEFAULT_EMAIL_TEXT;
            // set the maximum number of drop down items to defined constant value
            comboBoxEmail.MaxDropDownItems = MAIL_LOG_FILE_MAX;
            // clear error message if flagged
            errorProvider.SetError(comboBoxEmail, string.Empty);

            // set default value of password text box
            textBoxPassword.Text = DEFAULT_PASSWORT_TEXT;
            // enable password visibility with null character
            textBoxPassword.PasswordChar = '\0';
            // clear error message if flagged
            errorProvider.SetError(textBoxPassword, string.Empty);

            // clear recent emails from combo text box
            comboBoxEmail.Items.Clear();

            // add last three cached email addresses to combo text box
            for (int i = 1; i <= MAIL_LOG_FILE_MAX; i++)
            {
                string line = FileWriter.GetLine(MAIL_LOG_FILE, i);

                if (line != null)
                {
                    comboBoxEmail.Items.Add(line);
                }
            }

            // dispose of current image the box is set to (prevents memory leak)
            pictureBoxPasswordVisibility.Image.Dispose();
            // set image to password visible
            pictureBoxPasswordVisibility.Image = Properties.Resources.showPassword;

            // disable tabbing to the link label saying forgot password
            linkLabelForgotPassword.TabStop = false;

            //change focus to login button
            buttonLogIn.Focus();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            // store employees email for later use
            string employeeEmail = comboBoxEmail.Text;
            // validate email and store any error messages received
            string errorMessage = LoginValidation.ValidateEmail(comboBoxEmail.Text);

            // if error message returned, turn the flag on
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                errorProvider.SetError(comboBoxEmail, errorMessage);
                return;
            }

            // check if password was not left blank before continuing
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                errorProvider.SetError(textBoxPassword, "Password must not be left blank!");
                return;
            }

            // store results of validation as boolean values (bool emailValid, bool passwordValid)
            var (emailValid, passwordValid) = LoginValidation.ValidateCredentials(employeeEmail, textBoxPassword.Text);

            // if both email and password are valid, continue to main application
            if (emailValid && passwordValid)
            {
                // add logon entry to log file
                FileWriter.WriteLog("login");

                // if email address already occurs in the log file, delete it
                FileWriter.DeleteLine(MAIL_LOG_FILE, FileWriter.ContainsLine(MAIL_LOG_FILE, employeeEmail));
                // insert email address at the beginning of the file
                FileWriter.InsertAtBeginning(MAIL_LOG_FILE, employeeEmail);

                // hide current form
                this.Hide();

                // create main form and open it
                using (Main MainApplication = new Main(employeeEmail))
                    MainApplication.ShowDialog();

                // once main application closes, add logoff entry to event file
                FileWriter.WriteLog("logout");

                // open login page again
                this.Show();
                // load default settings of the login page
                LoadDefaultSettings();
            }
            // else if email incorrect
            else if (!emailValid)
            {
                errorProvider.SetError(comboBoxEmail, "Email address incorrect!");
            }
            // else if password incorrect
            else if (!passwordValid)
            {
                errorProvider.SetError(textBoxPassword, "Password incorrect!");
            }
            // in case of any inexpected errors
            else
            {
                FileWriter.WriteLog("login validation error");
                MessageBox.Show("Please report this error to your manager.", "Unexpected Error");
            }
        }

        private void comboBoxEmail_Enter(object sender, EventArgs e)
        {
            // if text box is set to default, clear its content
            if (comboBoxEmail.Text == DEFAULT_EMAIL_TEXT)
            {
                comboBoxEmail.ResetText();
            }

            // clear error message if flagged
            errorProvider.SetError(comboBoxEmail, string.Empty);
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            // if password is set to default, clear content of text box
            if (textBoxPassword.Text == DEFAULT_PASSWORT_TEXT && textBoxPassword.PasswordChar != '*')
            {
                // clear content of text box
                textBoxPassword.Clear();
                // disable password visibility
                textBoxPassword.PasswordChar = '*';
                // dispose of current image the box is set to (prevents memory leak)
                pictureBoxPasswordVisibility.Image.Dispose();
                // set image icon to password hidden
                pictureBoxPasswordVisibility.Image = Properties.Resources.hidePassword;
            }

            // clear error message if flagged
            errorProvider.SetError(textBoxPassword, string.Empty);
        }

        private void pictureBoxPasswordVisibility_Click(object sender, EventArgs e)
        {
            // dispose of current image the box is set to (prevents memory leak)
            pictureBoxPasswordVisibility.Image.Dispose();

            // if password is hidden, set password character to null and change image icon
            if (textBoxPassword.PasswordChar == '*')
            {
                textBoxPassword.PasswordChar = '\0';
                pictureBoxPasswordVisibility.Image = Properties.Resources.showPassword;
            }
            // else censor password and change image icon
            else
            {
                textBoxPassword.PasswordChar = '*';
                pictureBoxPasswordVisibility.Image = Properties.Resources.hidePassword;
            }
        }

        private void linkLabelForgotPassword_Click(object sender, EventArgs e)
        {
            // display bow with a message when user clicks on forgot password
            MessageBox.Show("Please try again or contact your manager.", "Forgot Password");
            // load default settings of the login page
            LoadDefaultSettings();
        }
    }
}

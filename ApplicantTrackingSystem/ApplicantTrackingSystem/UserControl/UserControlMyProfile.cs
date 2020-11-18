using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicantTrackingSystem
{
    public partial class UserControlMyProfile : UserControl
    {
        public UserControlMyProfile()
        {
            InitializeComponent();
        }

        private void UserControlMyProfile_Load(object sender, EventArgs e)
        {
            // retrieve array of strings containing employee details based on their email address
            string[] record = DatabaseManagement.GetInstanceOfDatabaseConnection().GetEntireRecord(DatabaseQueries.GetRecord(DatabaseQueries.EMPLOYEE_DETAILS, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, Main.mainApplication.employeeEmail));
            
            // set strings to text boxes using the following index starting from 0 (id, first name, middle names, last name, email address, mobile number, work number)
            textBoxFirstName.Text = record[1];
            textBoxMiddleNames.Text = record[2];
            textBoxLastName.Text = record[3];
            textBoxPhoneNumber.Text = record[5];
            textBoxWorkNumber.Text = record[6];
            textBoxEmailAddress.Text = record[4];
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // store content of text boxes in an array
            string[] employeeDetails = { textBoxFirstName.Text, textBoxMiddleNames.Text, textBoxLastName.Text, textBoxEmailAddress.Text, textBoxPhoneNumber.Text, textBoxWorkNumber.Text };
            // update employee with specified email address using attributes retrieved from text fields
            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(DatabaseQueries.UpdateRecord(DatabaseQueries.UPDATE_EMPLOYEE_DETAILS, employeeDetails, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, Main.mainApplication.employeeEmail));
            // update name on main form
            Main.mainApplication.UpdateStatus();
            // update current page
            Main.mainApplication.RefreshPage();

            // display message box
            MessageBox.Show("All settings were saved successfully.", "Settings Saved");
            // go back to previous page
            Main.mainApplication.GoBackPage();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            // check if new password was not left blank
            if (string.IsNullOrWhiteSpace(textBoxNewPassword.Text))
            {
                errorProvider.SetError(textBoxNewPasswordConfirmed, "New password must not be left blank!");
            }
            // check if new password and new password confirmed match
            else if (textBoxNewPassword.Text == textBoxNewPasswordConfirmed.Text)
            {
                string errorMessage = LoginValidation.CheckPasswordStrength(textBoxNewPassword.Text);

                // check if password meets characteristics
                if (string.IsNullOrWhiteSpace(errorMessage))
                {
                    // check if current password is correct
                    if (LoginValidation.ValidateCredentials(Main.mainApplication.employeeEmail, textBoxCurrentPassword.Text).passwordValid)
                    {
                        // change password
                        DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(DatabaseQueries.UpdateRecord(DatabaseQueries.UPDATE_EMPLOYEE_PASSWORD, LoginValidation.HashPassword(textBoxNewPassword.Text), DatabaseQueries.EMPLOYEE_WHERE_EMAIL, Main.mainApplication.employeeEmail));
                        // display message box to notify user
                        MessageBox.Show("Password changed successfully.", "Password Confirmation");
                        // and go back to previous page
                        Main.mainApplication.GoBackPage();
                    }
                    else
                    {
                        errorProvider.SetError(textBoxCurrentPassword, "Password incorrect!");
                    }
                }
                else
                {
                    errorProvider.SetError(textBoxNewPassword, errorMessage);
                }
            }
            else
            {
                errorProvider.SetError(textBoxNewPasswordConfirmed, "Passwords do not match!");
            }
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            // open message box with a question
            DialogResult choice = MessageBox.Show("Are you sure you want to discard all changes?", "Discard Changes", MessageBoxButtons.YesNo);
            
            // if answer to above message box was yes
            if (choice == DialogResult.Yes)
            {
                // go back to previous page
                Main.mainApplication.GoBackPage();
            }
        }

        private void textBoxNewPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPassword.PasswordChar != '*')
            {
                textBoxNewPassword.PasswordChar = '*';
                textBoxNewPassword.Clear();
            }
            errorProvider.SetError(textBoxNewPassword, string.Empty);
        }

        private void textBoxNewPasswordConfirmed_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPasswordConfirmed.PasswordChar != '*')
            {
                textBoxNewPasswordConfirmed.PasswordChar = '*';
                textBoxNewPasswordConfirmed.Clear();
            }
            errorProvider.SetError(textBoxNewPasswordConfirmed, string.Empty);
        }

        private void textBoxCurrentPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxCurrentPassword.PasswordChar != '*')
            {
                textBoxCurrentPassword.PasswordChar = '*';
                textBoxCurrentPassword.Clear();
            }
            errorProvider.SetError(textBoxCurrentPassword, string.Empty);
        }
    }
}

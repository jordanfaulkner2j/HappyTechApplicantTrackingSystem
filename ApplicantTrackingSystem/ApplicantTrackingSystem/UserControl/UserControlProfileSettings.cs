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
    public partial class UserControlProfileSettings : UserControl
    {
        // private string for employee's email used for retrieving and updating their record
        private string employeeEmail;
        // private boolean value used for opening advanced panel for administrator
        private Boolean isAdminManaging;
        // private array of strings holding contents of text boxes
        private string[] employeeDetails;
        // private array of strings containing default titles
        private readonly string[] titles = { "None", "Mr", "Mrs", "Ms", "Miss", "Dr" };
        // private array of strings containing permission levels
        private readonly string[] adminRights = { "True", "False" };

        public UserControlProfileSettings(string selectedEmployeeEmail, Boolean openInManagingMode)
        {
            InitializeComponent();

            // store selected employee's email
            employeeEmail = selectedEmployeeEmail;

            // if admin is in state of managing accounts, open panel with additional settings
            if (openInManagingMode)
            {
                panelChangePassword.Hide();
                panelAdvancedSettings.Show();

                // clear content of combo boxes
                comboBoxAdminRights.Items.Clear();
                // add predefined list of permission levels to combo box
                comboBoxAdminRights.Items.AddRange(adminRights);
                // select default permission level
                comboBoxAdminRights.SelectedIndex = 0;
            }
            else
            {
                panelAdvancedSettings.Hide();
                panelChangePassword.Show();
            }

            // clear content of combo boxes
            comboBoxTitle.Items.Clear();
            // add predefined list of titles to combo box
            comboBoxTitle.Items.AddRange(titles);
            // select default title
            comboBoxTitle.SelectedIndex = 0;

            // if admin has selected an account, retrieve user's details
            if (!string.IsNullOrEmpty(employeeEmail))
            {
                RetrieveEmployeeDetails();
            }
            // otherwise, set default values for creating a new account
            else
            {
                buttonResetPassword.Enabled = false;
                buttonDeleteAccount.Enabled = false;
                textBoxJobTitle.Text = "HappyTech Employee";
                textBoxEmailAddress.Text = "example@happytech.com";
            }
        }

        private void RetrieveEmployeeDetails()
        {
            // retrieve array of strings containing employee details based on their email address
            employeeDetails = DatabaseManagement.GetInstanceOfDatabaseConnection().GetEntireRecord(DatabaseQueries.GetRecord(DatabaseQueries.USER_DETAILS, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, employeeEmail));

            // select title from the combo box
            foreach (string option in comboBoxTitle.Items)
            {
                // if title already exists in the list, select it
                if (option == employeeDetails[0])
                {
                    //comboBoxTitle.SelectedIndex = i;
                    comboBoxTitle.SelectedItem = option;
                }
            }
            
            // set strings to text boxes using the following index starting from 0 (title, first name, middle names, last name, mobile number, work number, email address)
            textBoxFirstName.Text = employeeDetails[1];
            textBoxMiddleNames.Text = employeeDetails[2];
            textBoxLastName.Text = employeeDetails[3];
            textBoxPhoneNumber.Text = employeeDetails[4];
            textBoxWorkNumber.Text = employeeDetails[5];
            textBoxEmailAddress.Text = employeeDetails[6];

            if (isAdminManaging)
            {
                // set employee's job title from the database
                textBoxJobTitle.Text = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GetRecord(DatabaseQueries.EMPLOYEE_JOB_POSITION, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, employeeEmail));

                // set employee's permission level based on the data from database
                if (DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GetRecord(DatabaseQueries.EMPLOYEE_IS_ADMIN, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, employeeEmail)))
                {
                    comboBoxAdminRights.SelectedIndex = 0;
                }
                else
                {
                    comboBoxAdminRights.SelectedIndex = 1;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // store content of text boxes in an array
            employeeDetails = new string[] { comboBoxTitle.SelectedItem.ToString(), textBoxFirstName.Text, textBoxMiddleNames.Text, textBoxLastName.Text, textBoxPhoneNumber.Text.ToString(), textBoxWorkNumber.Text.ToString(), textBoxEmailAddress.Text };
            // store updated email address for later use
            string newEmployeeEmail = employeeDetails[6];

            // if title was not selected, update it to null
            if (comboBoxTitle.SelectedItem.ToString() == "None")
            {
                employeeDetails[0] = null;
            }

            // loop through all employee's details except title which was already validated
            for (int i = 1; i < employeeDetails.Length; i++)
            {
                // check if required fields were not left blank
                if (string.IsNullOrEmpty(employeeDetails[i]))
                {
                    // except middle name and work phone number that are allowed to be null
                    if (i == 2 || i == 5)
                    {
                        // in case the text box contains an empty space, set value manually to null
                        employeeDetails[i] = null;
                    }
                    else
                    {
                        // else return error message
                        MessageBox.Show("Fields marked with asterisk are required.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // if job title has been left empty, display an error message
            if (string.IsNullOrEmpty(textBoxJobTitle.Text))
            {
                MessageBox.Show("Job title is a required field. Please fill in.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the email address was changed
            if (employeeEmail != newEmployeeEmail)
            {
                // check if email address matches required format, else return error message
                if (string.IsNullOrEmpty(LoginValidation.ValidateEmail(newEmployeeEmail)))
                {
                    // check if email address is not used by someone else
                    if (!string.IsNullOrEmpty(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GetRecord(DatabaseQueries.EMPLOYEE_NAME, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, newEmployeeEmail))))
                    {
                        MessageBox.Show("Email address already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Email address does not have valid format.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // convert selected permission level to string for easier manipulation when updating records
            string adminRights;
            if (comboBoxAdminRights.SelectedIndex == 0)
            {
                adminRights = "1";
            }
            else
            {
                adminRights = "0";
            }

            // if employee has not been selected, create a new account
            if (string.IsNullOrEmpty(employeeEmail))
            {
                AddNewAccount(newEmployeeEmail, adminRights);
                MessageBox.Show("New account created successfully!", "New Account Confirmation");
                Main.mainApplication.OpenPage(new UserControlEmployees());
                return;
            }
            
            // first update employee's job title and permission level
            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(DatabaseQueries.UpdateRecord(DatabaseQueries.UPDATE_EMPLOYEE_ROLE, new string[] { textBoxJobTitle.Text, adminRights }, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, employeeEmail));

            // then update the rest of employee's details with specified email address using attributes retrieved from text fields
            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(DatabaseQueries.UpdateRecord(DatabaseQueries.UPDATE_EMPLOYEE_DETAILS, employeeDetails, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, employeeEmail));

            // if email address was updated for current user, change the email address of logged in employee
            if (Main.mainApplication.employeeEmail != employeeEmail)
            {
                Main.mainApplication.employeeEmail = newEmployeeEmail;
            }

            // update name on main form
            Main.mainApplication.UpdateStatus();
            // update current page
            Main.mainApplication.RefreshPage();

            // display message box
            MessageBox.Show("All settings were saved successfully.", "Settings Saved");
            // go back to previous page
            Main.mainApplication.GoBackPage();
        }

        private void AddNewAccount(string newAccountEmail, string adminRights)
        {
            // insert employee into the table of users first
            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.INSERT_EMPLOYEE, employeeDetails));
            // insert employee into the table of employees and link it using the user id from previous query (password belongs employee's phone number)
            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.INSERT_EMPLOYEE_ROLE, new string[] { newAccountEmail, textBoxJobTitle.Text, LoginValidation.HashPassword(textBoxPhoneNumber.Text), adminRights }));
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
            InitializePasswordTextBox(sender as TextBox);
        }

        private void textBoxNewPasswordConfirmed_Enter(object sender, EventArgs e)
        {
            InitializePasswordTextBox(sender as TextBox);
        }

        private void textBoxCurrentPassword_Enter(object sender, EventArgs e)
        {
            InitializePasswordTextBox(sender as TextBox);
        }

        private void InitializePasswordTextBox(TextBox passwordTextBox)
        {
            // if password is set to visible
            if (passwordTextBox.PasswordChar != '*')
            {
                // disable password visibility
                passwordTextBox.PasswordChar = '*';
                // clear content of text box
                passwordTextBox.Clear();
            }

            // clear any flagged errors
            errorProvider.SetError(passwordTextBox, string.Empty);
        }
    }
}

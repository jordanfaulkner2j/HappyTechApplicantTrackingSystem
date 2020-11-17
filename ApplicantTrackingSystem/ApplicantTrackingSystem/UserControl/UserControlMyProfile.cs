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
            string[] record = DatabaseManagement.GetInstanceOfDatabaseConnection().GetEntireRecord(DatabaseQueries.GetRecord(DatabaseQueries.EMPLOYEE_DETAILS, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, Main.employeeEmail));
            
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
            // store text box content as an array
            string[] employeeDetails = { textBoxFirstName.Text, textBoxMiddleNames.Text, textBoxLastName.Text, textBoxEmailAddress.Text, textBoxPhoneNumber.Text, textBoxWorkNumber.Text };
            // update employee with specified email address using attributes retrieved from text fields
            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(DatabaseQueries.UpdateRecord(DatabaseQueries.UPDATE_EMPLOYEE_DETAILS, employeeDetails, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, Main.employeeEmail));
            // update name on main form
            // update current page
        }
    }
}

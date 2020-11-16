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
            string[] record = DatabaseManagement.GetInstanceOfDatabaseConnection().GetEntireRecord(DatabaseQueries.GetEmployeeUsingEmail(DatabaseQueries.EMPLOYEE_DETAILS, Main.employeeEmail));
            
            // set strings to text boxes using the following index starting from 0 (id, first name, middle names, last name, email address, mobile number, work number)
            textBoxFirstName.Text = record[1];
            textBoxLastName.Text = record[3];
            textBoxMobileNumber.Text = record[5];
            textBoxWorkNumber.Text = record[6];
            textBoxEmailAddress.Text = record[4];
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // update record
            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format("UPDATE users SET users.first_name = '{0}', users.last_name = '{1}', users.email_address = '{2}', mobile_number = '{3}', work_number = {4} WHERE users.email_address = 'admin@example.com'", textBoxFirstName.Text, textBoxLastName.Text, textBoxEmailAddress.Text, textBoxMobileNumber.Text, textBoxWorkNumber.Text));
            // update name on main form
            // update current page
        }
    }
}

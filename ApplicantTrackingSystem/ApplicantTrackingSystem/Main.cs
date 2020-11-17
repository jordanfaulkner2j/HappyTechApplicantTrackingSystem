using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicantTrackingSystem
{
    public partial class Main : Form
    {
        // private string of the employee currently logged in
        private static string loggedInEmployeeEmail;
        // private object of the current user control displayed
        private static UserControl runtimePage;

        public Main(string employeeEmail)
        {
            InitializeComponent();

            // store signed employee's email
            loggedInEmployeeEmail = employeeEmail;

            // if employee has admin privileges, show menu item for managing employees
            if (DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GetRecord(DatabaseQueries.EMPLOYEE_IS_ADMIN, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, loggedInEmployeeEmail)))
            {
                manageEmployeesToolStripMenuItem.Visible = true;
            }
            else
            {
                manageEmployeesToolStripMenuItem.Visible = false;
            }

            // display employee's name on application
            labelEmployeeName.Text = "Welcome "+ DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GetRecord(DatabaseQueries.EMPLOYEE_NAME, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, loggedInEmployeeEmail));

            // open applications page on start
            applicationsToolStripMenuItem.PerformClick();
        }

        public static string employeeEmail
        {
            get
            {
                // function which returns the content of the string if another class requests it
                return loggedInEmployeeEmail;
            }
        }

        private void openPage(UserControl page)
        {
            if (runtimePage != null)
            {
                runtimePage.Dispose();
            }
            runtimePage = page;
            panelBody.Controls.Add(runtimePage);
            runtimePage.Dock = DockStyle.Fill;
        }

        private void createNewTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with form for creating templates
            openPage(new UserControlCreateEditTemplate());
        }

        private void templatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with list of existing templates
            openPage(new UserControlTemplates());
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with list of applications
            openPage(new UserControlApplications());
        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with list of employees
            openPage(new UserControlEmployees());
        }

        private void myProfileSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display my profile settings
            openPage(new UserControlMyProfile());
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close current form
            this.Close();
        }
    }
}

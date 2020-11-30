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
        // private object holding this form
        private static Main mainPage;
        // private object of the current user control displayed
        private UserControl runtimePage;
        // private object of the previous user control accessed
        private UserControl previousPage;
        // private string of the employee currently logged in
        private string loggedInEmployeeEmail;

        public Main(string employeeEmail)
        {
            InitializeComponent();

            // store this form in a variable to be used as reference later on
            mainPage = this;

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

            // update information displayed on main page
            UpdateStatus();

            // open applications page on start
            OpenPage(new UserControlApplications());
        }

        public static Main mainApplication
        {
            get
            {
                return mainPage;
            }
        }

        public string employeeEmail
        {
            get
            {
                return loggedInEmployeeEmail;
            }
            set
            {
                loggedInEmployeeEmail = value;
            }
        }

        /// <summary>
        /// update information on banner on main form
        /// </summary>
        public void UpdateStatus()
        {
            // display employee's name on application
            labelEmployeeName.Text = "Welcome " + DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GetRecord(DatabaseQueries.EMPLOYEE_NAME, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, loggedInEmployeeEmail));
            // display number of completed applications
            labelNumberCompleted.Text = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute("SELECT COUNT(*) FROM applications WHERE applications.feedback_left = 1").ToString();
            // display number of remaining applications to be reviewed
            labelNumberRemaining.Text = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute("SELECT COUNT(*) FROM applications WHERE applications.feedback_left = 0").ToString();
        }

        /// <summary>
        /// refresh current page selected from the menu
        /// </summary>
        public void RefreshPage()
        {
            if (runtimePage != null)
            {
                runtimePage.Refresh();
            }
        }

        /// <summary>
        /// open requested page
        /// </summary>
        /// <param name="page">user control object</param>
        public void OpenPage(UserControl page)
        {
            // if current page exists
            if (runtimePage != null)
            {
                // if previous page exists
                if (previousPage != null)
                {
                    // destroy current previous page
                    previousPage.Dispose();
                }
                // store currently opened page as previous page
                previousPage = runtimePage;
            }
            // set current page to requested page
            runtimePage = page;
            // close previous page
            panelBody.Controls.Clear();
            // add requested page
            panelBody.Controls.Add(runtimePage);
            // adjust docking to fill the panel
            runtimePage.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// open previous page if exists
        /// </summary>
        public void GoBackPage()
        {
            // if previous page exists
            if (previousPage != null)
            {
                // swap positions of current and previous page
                UserControl tempPage = runtimePage;
                runtimePage = previousPage;
                previousPage = tempPage;
            }
            // close previous page
            panelBody.Controls.Clear();
            // add requested page
            panelBody.Controls.Add(runtimePage);
            // adjust docking to fill the panel
            runtimePage.Dock = DockStyle.Fill;
        }

        private void createNewTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with form for creating templates
            OpenPage(new UserControlCreateEditTemplate());
        }

        private void templatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with list of existing templates
            OpenPage(new UserControlTemplates());
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with list of applications
            OpenPage(new UserControlApplications());
        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with list of employees
            OpenPage(new UserControlEmployees());
        }

        private void myProfileSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display my profile settings
            OpenPage(new UserControlMyProfile(loggedInEmployeeEmail));
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close current form
            this.Close();
        }
    }
}

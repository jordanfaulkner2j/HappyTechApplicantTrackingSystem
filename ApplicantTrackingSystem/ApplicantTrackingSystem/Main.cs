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
        public Main(string employeeEmail)
        {
            InitializeComponent();

            // retrieve query and attribute name from class of queries
            var retrieveAdminRightsQuery = DatabaseQueries.IsEmployeeAdmin(employeeEmail);

            // if employee has admin privileges, show menu item for managing employees
            if (DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(retrieveAdminRightsQuery.sqlQuery, retrieveAdminRightsQuery.attributeName) == "1")
            {
                manageEmployeesToolStripMenuItem.Visible = true;
            }
            else
            {
                manageEmployeesToolStripMenuItem.Visible = false;
            }

            // open applications page on start
            applicationsToolStripMenuItem.PerformClick();
        }

        private void createNewTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with form for creating templates
            pageCreateEditTemplate.BringToFront();
        }

        private void templatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with list of existing templates
            pageTemplates.BringToFront();

            // update list of applications from the database
            pageTemplates.UpdateTemplatesTable();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with list of applications
            pageApplications.BringToFront();

            // update list of applications from the database
            pageApplications.UpdateApplicationsTable();
        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with list of employees
            pageEmployees.BringToFront();

            // update list of employees from the database
            pageEmployees.UpdateEmployeesTable();
        }

        private void myProfileSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display my profile's settings
            pageMyProfile.BringToFront();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close current form
            this.Close();
        }
    }
}

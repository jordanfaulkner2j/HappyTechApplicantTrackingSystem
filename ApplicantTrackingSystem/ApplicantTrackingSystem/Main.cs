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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close current form
            this.Close();
        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with list of applications
            pageApplications.BringToFront();
        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // display page with list of employees
            pageEmployees.BringToFront();

            // update list of employees from the database
            pageEmployees.UpdateFromDatabse();
        }
    }
}

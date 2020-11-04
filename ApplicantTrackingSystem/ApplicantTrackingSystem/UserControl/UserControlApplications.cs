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
    public partial class UserControlApplications : UserControl
    {
        public UserControlApplications()
        {
            InitializeComponent();
        }

        public void UpdateApplicationsTable()
        {
            // get dataset from database based on provided SQL query
            dgvApplications.DataSource = DatabaseManagement.GetInstanceOfDatabaseConnection().GetDataSet(DatabaseQueries.APPLICANTS).Tables[0];
        }
    }
}

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

        public void GetApplicationTable()
        {
            // get dataset from database based on provided SQL query
            DataSet applications = DatabaseConnection.GetInstanceOfDatabaseConnection().GetDataSet("SELECT applicant.applicant_id, user.first_name, user.last_name, user.email_address, application.date_submitted, application.interviewed, application.feedback_left, application.feedback_sent FROM ((applicant INNER JOIN user ON applicant.user_id = user.user_id) INNER JOIN application ON applicant.applicant_id = application.applicant_id);");
            // copy data from application table into data grid view
            dgvApplications.DataSource = applications.Tables[0];
        }
    }
}

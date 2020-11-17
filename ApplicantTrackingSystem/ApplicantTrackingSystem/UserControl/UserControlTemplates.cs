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
    public partial class UserControlTemplates : UserControl
    {
        public UserControlTemplates()
        {
            InitializeComponent();
        }

        private void UserControlTemplates_Load(object sender, EventArgs e)
        {
            // get dataset from database based on provided SQL query
            dgvTemplates.DataSource = DatabaseManagement.GetInstanceOfDatabaseConnection().GetDataSet(DatabaseQueries.TEMPLATES).Tables[0];
        }
    }
}

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
    public partial class UserControlEmployees : UserControl
    {
        public UserControlEmployees()
        {
            InitializeComponent();
        }
        public void UpdateEmployeesTable()
        {
            // get dataset from database based on provided SQL query
            dgvEmployees.DataSource = DatabaseManagement.GetInstanceOfDatabaseConnection().GetDataSet(DatabaseQueries.EMPLOYEES).Tables[0];
        }
    }
}

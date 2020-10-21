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
        public void UpdateFromDatabse()
        {
            // display data from employees table into DataGridView
            // get dataset from db and assign it to the DataGridView's datasource
            // dgvEmployees.DataSource = ...
            DataSet ds = DBConnection.getInstanceOfDBConnection().getDataSet("SELECT * FROM Employees");
            dgvEmployees.DataSource = ds.Tables[0];
        }
    }
}

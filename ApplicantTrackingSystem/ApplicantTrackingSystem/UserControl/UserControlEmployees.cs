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
        public void GetEmployeeTable()
        {
            // get dataset from database based on provided SQL query
            DataSet employees = DatabaseConnection.GetInstanceOfDatabaseConnection().GetDataSet("SELECT employee.employee_id, user.title, user.first_name, user.last_name, user.email_address, employee.job_title, employee.administrator FROM employee INNER JOIN user ON employee.user_id = user.user_id;");
            // copy data from employee table into data grid view
            dgvEmployees.DataSource = employees.Tables[0];
        }
    }
}

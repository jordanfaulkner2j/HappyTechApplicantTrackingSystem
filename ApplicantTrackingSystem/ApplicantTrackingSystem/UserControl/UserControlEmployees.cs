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
        private void UserControlEmployees_Load(object sender, EventArgs e)
        {
            // get dataset from database based on provided SQL query
            dgvEmployees.DataSource = DatabaseManagement.GetInstanceOfDatabaseConnection().GetDataSet(DatabaseQueries.EMPLOYEES).Tables[0];
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // disable header row selection
            if (e.RowIndex >= 0)
            {
                // when a record is selected, open page with their details
                Main.mainApplication.OpenPage(new UserControlMyProfile(dgvEmployees.Rows[e.RowIndex].Cells["Email Address"].Value.ToString()));
            }
        }
    }
}

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
        // constant values for default text box fields
        private const string DEFAULT_FIRST_NAME_TEXT = "Search by first name";
        private const string DEFAULT_LAST_NAME_TEXT = "Search by last name";

        public UserControlApplications()
        {
            InitializeComponent();
        }

        private void UserControlApplications_Load(object sender, EventArgs e)
        {
            // get dataset from database based on provided SQL query
            dgvApplications.DataSource = DatabaseManagement.GetInstanceOfDatabaseConnection().GetDataSet(DatabaseQueries.APPLICANTS).Tables[0];
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            // to check if the text box is blank 
            if (textBoxFirstName.Text == "")
            {
                // displays all the records if the text box is left empty
                dgvApplications.DataSource = DatabaseManagement.GetInstanceOfDatabaseConnection().GetDataSet(DatabaseQueries.APPLICANTS).Tables[0];
            }
            else
            {
                // Creating a new BindingSource
                BindingSource bs = new BindingSource();

                // Selecting the DataGridView as the DataSource, In this case dgvApplications is the DataSource
                bs.DataSource = dgvApplications.DataSource;

                // sqlQuery to perform the filtering using CONVERT
                bs.Filter = string.Format("CONVERT(" + dgvApplications.Columns[1].DataPropertyName + ", System.String) like '%" + textBoxFirstName.Text.Replace("'", "''") + "%'");

                // Run the filter option in the dgvApplications 
                dgvApplications.DataSource = bs;
            }
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            // if text box is set to default, clear its content
            if (textBoxFirstName.Text == DEFAULT_FIRST_NAME_TEXT)
            {
                // clears the text box 
                textBoxFirstName.Clear();
            }
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            // to check if the text box is blank 
            if (textBoxLastName.Text == "")
            {
                // displays all the records if the text box is left empty 
                dgvApplications.DataSource = DatabaseManagement.GetInstanceOfDatabaseConnection().GetDataSet(DatabaseQueries.APPLICANTS).Tables[0];
            }
            else
            {
                // Creating a new BindingSource
                BindingSource bs = new BindingSource();

                // Selecting the DataGridView as the DataSource, In this case dgvApplications is the DataSource
                bs.DataSource = dgvApplications.DataSource;

                // sqlQuery to perform the filtering using CONVERT
                bs.Filter = string.Format("CONVERT(" + dgvApplications.Columns[3].DataPropertyName + ", System.String) like '%" + textBoxLastName.Text.Replace("'", "''") + "%'");

                // Run the filter option in the dgvApplications 
                dgvApplications.DataSource = bs;

            }
        }

        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            // if text box is set to default, clear its content
            if (textBoxLastName.Text == DEFAULT_LAST_NAME_TEXT)
            {
                // clears the text box
                textBoxLastName.Clear();
            }
        }

        private void comboBoxJobPositions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // filtering data based on combo box selection
            if (comboBoxJobPositions.SelectedItem.ToString() == "All")
            {
                // displays all records if "All" option is selected
                dgvApplications.DataSource = DatabaseManagement.GetInstanceOfDatabaseConnection().GetDataSet(DatabaseQueries.APPLICANTS).Tables[0];
            }
            else
            {
                // Row filter that displays the record that the user selects in the combo box
                (dgvApplications.DataSource as DataTable).DefaultView.RowFilter = string.Format("title= '{0}'", comboBoxJobPositions.SelectedItem.ToString());
            }
        }

        private void dgvApplications_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // disable header row selection
            if (e.RowIndex >= 0)
            {
                // try converting string value of applicant ID to integer
                if (Int32.TryParse(dgvApplications.Rows[e.RowIndex].Cells[0].Value.ToString(), out int applicantID))
                {
                    // when application selected for review, open new page with all necessary details
                    Main.mainApplication.OpenPage(new UserControlGenerateFeedback2(applicantID));
                }
                else
                {
                    // else display error message
                    MessageBox.Show("Invalid application selected.", "Error Message");
                }
            }
        }

    }
}

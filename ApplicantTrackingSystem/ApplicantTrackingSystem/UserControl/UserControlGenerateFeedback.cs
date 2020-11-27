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
    public partial class UserControlGenerateFeedback2 : UserControl
    {
        public UserControlGenerateFeedback2()
        {
            InitializeComponent();
        }
        // private integer for applicant's ID for which the feedback is given
        private int applicantID;

        public UserControlGenerateFeedback2(int selectedApplicantID)
        {
            InitializeComponent();

            // store applicant's ID for use later on
            applicantID = selectedApplicantID;
        }

        private void UserControlGenerateFeedback2_Load(object sender, EventArgs e)
        {
            // empty combo box
            comboBoxTemplates.Items.Clear();

            // for number of records in table of templates
            for (int i = 1; i <= DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.COUNT_TEMPLATES); i++)
            {
                // add template title to combo box
                comboBoxTemplates.Items.Add(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_TITLE, i)));
            }
        }
        private void comboBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update text fields based on data from selected template
            textBoxHeader.Text = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_HEADER, comboBoxTemplates.SelectedItem.ToString()));

            textBoxFooter.Text = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_FOOTER, comboBoxTemplates.SelectedItem.ToString()));
        }

        private void buttonGenerateFeedback_Click(object sender, EventArgs e)
        {
            // save feedback to file
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            // open message box with a question
            DialogResult choice = MessageBox.Show("Are you sure you want to continue without saving changes? Progress will be lost!", "Discard Changes", MessageBoxButtons.YesNo);

            // if answer to above message box was yes
            if (choice == DialogResult.Yes)
            {
                // go back to previous page
                Main.mainApplication.GoBackPage();
            }
        }

       
    }
}

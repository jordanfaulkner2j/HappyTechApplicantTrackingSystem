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
    public partial class UserControlFeedback : UserControl
    {
        // private integer for applicant's ID for which the feedback is given
        private int applicantID;

        public UserControlFeedback(int selectedApplicantID)
        {
            InitializeComponent();

            // store applicant's ID for use later on
            applicantID = selectedApplicantID;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update text fields based on data from selected template
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // save feedback to file
        }

        private void button1_Click(object sender, EventArgs e)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace ApplicantTrackingSystem
{
    public partial class UserControlGenerateFeedback : UserControl
    {
        // private integer for applicant's ID for which the feedback is given
        private readonly int applicantID;
        public string defaultAddCommentstext = "Additional Comments";
        string templateName;
        public UserControlGenerateFeedback(int selectedApplicantID)
        {
            InitializeComponent();
            Comments();

            // store applicant's ID for use later on
            applicantID = selectedApplicantID;
        }

        private void UserControlGenerateFeedback_Load(object sender, EventArgs e)
        {
            // empty combo box
            comboBoxTemplates.Items.Clear();

            // for number of records in table of templates
            for (int i = 1; i <= DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.COUNT_TEMPLATES); i++)
            {
                // add template title to combo box
                comboBoxTemplates.Items.Add(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_TITLE, "template_id", i)));

                templateName = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_TITLE, "template_id", i));
            }
         
           
        }
        private void comboBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update text fields based on data from selected template
            textBoxHeader.Text = string.Format(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_HEADER, comboBoxTemplates.SelectedItem.ToString())), DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GetRecord(DatabaseQueries.APPLICANT_NAME, DatabaseQueries.APPLICANT_WHERE_ID, applicantID.ToString())), DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GetRecord(DatabaseQueries.APPLICANT_JOB_POSITION, DatabaseQueries.APPLICANT_WHERE_ID, applicantID.ToString())));

            textBoxFooter.Text = string.Format(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_FOOTER, comboBoxTemplates.SelectedItem.ToString())), DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GetRecord(DatabaseQueries.EMPLOYEE_NAME, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, Main.mainApplication.employeeEmail)), DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GetRecord(DatabaseQueries.EMPLOYEE_JOB_POSITION, DatabaseQueries.EMPLOYEE_WHERE_EMAIL, Main.mainApplication.employeeEmail)));

            // Displays pre-defined comments for a template
            CheckedComments(templateName);
        }

        private void buttonGenerateFeedback_Click(object sender, EventArgs e)
        {
            // check if template was selected, otherwise, display an error message because there is no feedback available to be saved
            if (comboBoxTemplates.SelectedItem != null) 
            {
                // create a separate directory for PDF files containing feedback for applicants
                if (!Directory.Exists("Feedback\\"))
                {
                    Directory.CreateDirectory("Feedback\\");
                }

                // create dynamic array for writing feedback letter
                List<string> letter = new List<string>();

                // header
                letter.Add(textBoxHeader.Text);

                // list of comments
                letter.Add("Please view a short summary for your feedback below.");

                // for each selected comment, add it to the letter

                // additional comments if any
                if (!string.IsNullOrEmpty(textBoxAddComments.Text))
                {
                    letter.Add(textBoxAddComments.Text);
                }

                //footer
                letter.Add(textBoxFooter.Text);

                // save to PDF file
                FileWriter.GeneratePDF("Feedback\\" + applicantID.ToString(), letter.ToArray());

                // display confirmation message
                MessageBox.Show("Feedback successfully saved.", "Feedback Saved");
                // go back to previous page
                Main.mainApplication.GoBackPage();
            }
            else
            {
                // display error message
                MessageBox.Show("Template not selected. No feedback available to be saved.", "Missing Template");
            }
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            // open message box with a question
            DialogResult choice = MessageBox.Show("Are you sure you want to continue without saving changes?\nProgress will be lost!", "Discard Changes", MessageBoxButtons.YesNo);

            // if answer to above message box was yes
            if (choice == DialogResult.Yes)
            {
                // go back to previous page
                Main.mainApplication.GoBackPage();
            }
        }


        private void Comments()
        {
            string Understanding = "Understanding of HappyTech";
            string Impression = "Impression of Applicant";
            string Questions = "Applicant Questions";
            int highCommentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.MAX_COMMENT_ID);
            int i;
            int commentID = 1;
            for (i = 0; i < highCommentID; i++)
            {
                int sectionID = 1;
                string getSectionID = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_SECTION_ID_COMMENT, "comment_id", commentID)));
                bool recordExists = int.TryParse(getSectionID, out sectionID);
                if (recordExists == true)
                {
                    string secTitle = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_SECTION, getSectionID));
                    if (secTitle == Understanding)
                    {
                        string code = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_CODE, "comment_id", commentID));
                        string comment = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT, "comment_id", commentID));
                        clbUnderstandingComments.Items.Add(code + " - " + comment);
                    }
                    else if (secTitle == Impression)
                    {
                        string code = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_CODE, "comment_id", commentID));
                        string comment = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT, "comment_id", commentID));
                        clbImpressionComments.Items.Add(code + " - " + comment);
                    }
                    else if (secTitle == Questions)
                    {
                        string code = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_CODE, "comment_id", commentID));
                        string comment = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT, "comment_id", commentID));
                        clbQuestionsComments.Items.Add(code + " - " + comment);
                    }
                    commentID++;
                }
                else
                {
                    commentID++;
                }
            }
        }

        private void CheckedComments(string title)
        {
            int templateID;
            int commentID;
            int commentIDFromList;
            string itemCode;
            int i;
            for (i = 0; i < clbUnderstandingComments.Items.Count; i++)
            {
                clbUnderstandingComments.SetItemChecked(i, false);
                templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                itemCode = clbUnderstandingComments.Items[i].ToString();
                itemCode = itemCode.Substring(0, 3);
                itemCode = itemCode.Trim();
                commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                string getCommentIDFromList = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                bool commentSelected = int.TryParse(getCommentIDFromList, out commentIDFromList);
                if (commentSelected == true)
                {
                    clbUnderstandingComments.SetItemChecked(i, true);
                }
            }
            for (i = 0; i < clbImpressionComments.Items.Count; i++)
            {
                clbImpressionComments.SetItemChecked(i, false);
                templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                itemCode = clbImpressionComments.Items[i].ToString();
                itemCode = itemCode.Substring(0, 3);
                itemCode = itemCode.Trim();
                commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                string getCommentIDFromList = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                bool commentSelected = int.TryParse(getCommentIDFromList, out commentIDFromList);
                if (commentSelected == true)
                {
                    clbImpressionComments.SetItemChecked(i, true);
                }
            }
            for (i = 0; i < clbQuestionsComments.Items.Count; i++)
            {
                clbQuestionsComments.SetItemChecked(i, false);
                templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                itemCode = clbQuestionsComments.Items[i].ToString();
                itemCode = itemCode.Substring(0, 3);
                itemCode = itemCode.Trim();
                commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                string getCommentIDFromList = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                bool commentSelected = int.TryParse(getCommentIDFromList, out commentIDFromList);
                if (commentSelected == true)
                {
                    clbQuestionsComments.SetItemChecked(i, true);
                }
            }
        }

        private void btnAddUnderstanding_Click(object sender, EventArgs e)
        {
            CodeManagement addCode = new CodeManagement();
            addCode.ShowDialog();
        }

        private void btnAddImpression_Click(object sender, EventArgs e)
        {
            CodeManagement addCode = new CodeManagement();
            addCode.ShowDialog();
        }

        private void btnAddQuestions_Click(object sender, EventArgs e)
        {

            CodeManagement addCode = new CodeManagement();
            addCode.ShowDialog();
        }

        private void textBoxAddComments_Enter(object sender, EventArgs e)
        {
            if (textBoxAddComments.Text == defaultAddCommentstext)
            {
                textBoxAddComments.Text = "";
            }
        }
        private void textBoxAddComments_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxAddComments.Text == "")
            {
                textBoxAddComments.Text = defaultAddCommentstext;
            }
        }
    }
}

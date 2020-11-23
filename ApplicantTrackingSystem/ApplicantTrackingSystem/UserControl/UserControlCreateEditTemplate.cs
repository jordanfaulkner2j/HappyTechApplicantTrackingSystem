using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ApplicantTrackingSystem
{
    public partial class UserControlCreateEditTemplate : UserControl
    {
        public string defaultTemplateNameText = "Enter a name for this template...";
        public string defaultHeaderText = "Dear [ApplicantName], Thank you for applying for a position at HappyTech. I am emailing you to inform you that your [application type] has been further reviewed and your application was [application success]. The feedback from this is as follows:";
        public string templateType = "[application type]";
        public string applicationResult = "[successful/unsuccessful]";
        public string selectedCode = "";
        public UserControlCreateEditTemplate()
        {
            InitializeComponent();
            tbxHeader.Text = defaultHeaderText;
        }
        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            // check to see if a name for the template has been given by the employee
            // save contents of template name text box as a string called 'templateName'
            // if 'templateName' is blank or contains the default text, display a prompt telling them to enter a name into the text box
            // if a 'templateName' has been given, proceed with saving the template to the database
            // call method SaveTemplate with templateName, tbxHeader.Text and tbxFooter.Text as parameters
            // display a pop up message box to inform the user it has been saved successfully
            string templateName = tbxTemplateName.Text;
            templateName = templateName.Trim();
            if (templateName == "" || templateName == defaultTemplateNameText)
            {
                string title = "No Template Name";
                string message = "Please enter a name for this template before saving.";
                MessageBox.Show(message, title);
            }
            else
            {
                SaveTemplate(templateName, tbxHeader.Text, tbxFooter.Text);
                string title = "Template Saved";
                string message = "Template has been saved as '" + templateName + "' successfully.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
            }
        }
        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            // ask the employee if they want to discard their changes
            // use a messagebox with yes and no buttons to confirm their choice
            // if they click yes, take them back to the previous page
            // if they click no, do nothing
            string title = "Discard Changes";
            string message = "Are you sure you want to discard all changes made?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                // go back to previous page
                Main.mainApplication.GoBackPage();
            }
        }
        // clear the template name text box when the employee clicks on it so they can name the template
        // should only clear if the text box has the default text
        private void tbxTemplateName_Click(object sender, EventArgs e)
        {
            if (tbxTemplateName.Text == defaultTemplateNameText)
            {
                tbxTemplateName.Text = "";
            }
        }
        // set the text in the template name text box to the default text if the employee left it blank
        // this is done once their mouse leaves the text box
        private void tbxTemplateName_MouseLeave(object sender, EventArgs e)
        {
            if (tbxTemplateName.Text == "")
            {
                tbxTemplateName.Text = defaultTemplateNameText;
            }
        }
        // if an option has been selected, prevent another from being selected at the same time using a for loop
        // set templateType depending on the option selected (e.g. if the checkbox next to 'CV' is selected, set templateType to CV)
        // update the header preview text by calling the UpdateHeaderText method with templateType and applicationResult as parameters
        private void clbTemplateTypeItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i;
            for (i = 0; i < clbTemplateType.Items.Count; i++)
            {
                if (i != e.Index) clbTemplateType.SetItemChecked(i, false);
                if (clbTemplateType.GetSelected(0) == true)
                {
                    templateType = "CV";
                }
                else if (clbTemplateType.GetSelected(1) == true)
                {
                    templateType = "Interview";
                }
                else if (clbTemplateType.GetSelected(2) == true)
                {
                    templateType = "Technical Interview";
                }
                UpdateHeaderText(templateType, applicationResult);
            }
        }
        // if an option has been selected, prevent another from being selected at the same time using a for loop
        // set applicationResult to either 'successful' or 'unsuccessful' depending on which checkbox is selected
        // update the header preview text by calling the UpdateHeaderText method with templateType and applicationResult as parameters
        private void clbApplicationResult_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i;
            for (i = 0; i < clbApplicationResult.Items.Count; i++)
            {
                if (i != e.Index) clbApplicationResult.SetItemChecked(i, false);
                if (clbApplicationResult.GetSelected(0) == true)
                {
                    applicationResult = "successful";
                }
                else if (clbApplicationResult.GetSelected(1) == true)
                {
                    applicationResult = "unsuccessful";
                }
            }
            UpdateHeaderText(templateType, applicationResult);
        }
        // catch the parameters and store them as abbreviations (using string so the type is the same)
        // update the header preview text using these parameters
        private void UpdateHeaderText(string applicationType, string applicationResult)
        {
            string apt = applicationType;
            string apr = applicationResult;
            tbxHeader.Text = "Dear [ApplicantName], Thank you for applying for a position at HappyTech. I am emailing you to inform you that your " + apt + " has been further reviewed and your application was " + apr + ". The feedback from this is as follows:";
        }
        // store all codes as string, holding a value of the comment that forms the pair
        // if an option has been selected, prevent another from being selected at the same time using a for loop
        // set selectedCode to the code that had the checkbox selected
        // update the text in the understanding section of the preview to the comment that the code contains by calling the UpdateUnderstandingText method with selectedCode as a parameter
        private void clbUnderstanding_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i;
            string U01 = "When looking at our company values, in addition to the answers you provided to the questions we asked you, we found that you showed little understanding of HappyTech's values.";
            string U02 = "When looking at our company values, in addition to the answers you provided to the questions we asked you, we found that you showed some understanding of HappyTech's values.";
            string U03 = "When looking at our company values, in addition to the answers you provided to the questions we asked you, we found that you showed a great understanding of HappyTech's values.";
            for (i = 0; i < clbUnderstanding.Items.Count; i++)
            {
                if (i != e.Index) clbUnderstanding.SetItemChecked(i, false);
                if (clbUnderstanding.GetSelected(0) == true)
                {
                    selectedCode = U01;
                }
                else if (clbUnderstanding.GetSelected(1) == true)
                {
                    selectedCode = U02;
                }
                else if (clbUnderstanding.GetSelected(2) == true)
                {
                    selectedCode = U03;
                }
                UpdateUnderstandingText(selectedCode);
            }
        }
        // store all codes as string, holding a value of the comment that forms the pair
        // if an option has been selected, prevent another from being selected at the same time using a for loop
        // set selectedCode to the code that had the checkbox selected
        // update the text in the applicant impression section of the preview to the comment that the code contains by calling the UpdateImpressionText method with selectedCode as a parameter
        private void clbImpression_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i;
            string I01 = "When reviewing the interview, we found that you seemed to be very unprepared, with little eye contact and poor non-verbal communication.";
            string I02 = "When reviewing the interview, we found that you seemed to be somewhat prepared, with good posture and appearance but with little eye contact.";
            string I03 = "When reviewing the interview, we found that you seemed to be very well-prepared, with execellent posture, eye contact and non-verbal communication.";
            for (i = 0; i < clbImpression.Items.Count; i++)
            {
                if (i != e.Index) clbImpression.SetItemChecked(i, false);
                if (clbImpression.GetSelected(0) == true)
                {
                    selectedCode = I01;
                }
                else if (clbImpression.GetSelected(1) == true)
                {
                    selectedCode = I02;
                }
                else if (clbImpression.GetSelected(2) == true)
                {
                    selectedCode = I03;
                }
                UpdateImpressionText(selectedCode);
            }
        }
        // store all codes as string, holding a value of the comment that forms the pair
        // if an option has been selected, prevent another from being selected at the same time using a for loop
        // set selectedCode to the code that had the checkbox selected
        // update the text in the applicant questions section of the preview to the comment that the code contains by calling the UpdateQuestionsText method with selectedCode as a parameter
        private void clbQuestions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i;
            string Q01 = "When reviewing the interview, we found that you seemed to be unable to answer most questions we put to you, and the responses you gave were not very in-depth.";
            string Q02 = "When reviewing the interview, we found that you seemed to be able to answer most questions, with some having poor or incorrect responses.";
            string Q03 = "When reviewing the interview, we found that you seemed to be able to answer all questions very well, with solid responses and clarification.";
            for (i = 0; i < clbQuestions.Items.Count; i++)
            {
                if (i != e.Index) clbQuestions.SetItemChecked(i, false);
                if (clbQuestions.GetSelected(0) == true)
                {
                    selectedCode = Q01;
                }
                else if (clbQuestions.GetSelected(1) == true)
                {
                    selectedCode = Q02;
                }
                else if (clbQuestions.GetSelected(2) == true)
                {
                    selectedCode = Q03;
                }
                UpdateQuestionsText(selectedCode);
            }
        }
        // store all codes as string, holding a value of the comment that forms the pair
        // if an option has been selected, prevent another from being selected at the same time using a for loop
        // set selectedCode to the code that had the checkbox selected
        // update the text in the footer section of the preview to the comment that the code contains by calling the UpdateFooterText method with selectedCode as a parameter
        private void clbFooter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i;
            string F01 = "Best wishes for the future.";
            string F02 = "Kind regards.";
            for (i = 0; i < clbFooter.Items.Count; i++)
            {
                if (i != e.Index) clbFooter.SetItemChecked(i, false);
                if (clbFooter.GetSelected(0) == true)
                {
                    selectedCode = F01;
                }
                else if (clbFooter.GetSelected(1) == true)
                {
                    selectedCode = F02;
                }
                UpdateFooterText(selectedCode);
            }
        }
        // catch the selected code as a parameter called 'code'
        // set the textbox text to the comment that is stored as 'code'
        private void UpdateUnderstandingText(string code)
        {
            tbxUnderstanding.Text = code;
        }
        // catch the selected code as a parameter called 'code'
        // set the textbox text to the comment that is stored as 'code'
        private void UpdateImpressionText(string code)
        {
            tbxImpression.Text = code;
        }
        // catch the selected code as a parameter called 'code'
        // set the textbox text to the comment that is stored as 'code'
        private void UpdateQuestionsText(string code)
        {
            tbxQuestions.Text = code;
        }
        // catch the selected code as a parameter called 'code'
        // set the textbox text to the comment that is stored as 'code'
        private void UpdateFooterText(string code)
        {
            tbxFooter.Text = code;
        }
        // catch parameters as title, header and footer
        // store these in the correct sql format as a string called data
        // connect to the database and call the UpdateRecord method in the DatabaseManagement class
        // use the INSERT_TEMPLATE query from the DatabaseQueries class with the data string as a parameter
        private void SaveTemplate(string title, string header, string footer)
        {
            string data = "'" + title + "', '" + header + "', '" + footer + "')";
            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(DatabaseQueries.INSERT_TEMPLATE + data);
        }
    }
}

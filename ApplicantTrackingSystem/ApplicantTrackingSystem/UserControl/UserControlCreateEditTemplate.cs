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
        public string defaultHeaderText = "Dear [ApplicantName], Thank you for applying for a position at HappyTech. I am emailing you to inform you that your [application type] has been further reviewed and your application was [applicationSuccess]. The feedback from this is as follows:";
        public string applicationType;
        public string applicationResult;
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
                // save template to database using name and selected sections
            }
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            // ask the employee if they want to discard their changes
            // use a messagebox with yes and no buttons to confirm their choice
            // if they click yes, take them to the templates page
            // if they click no, do nothing
            string title = "Discard Changes";
            string message = "Are you sure you want to discard all changes made?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                // bring the templates page to the front
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

        private void tbxApplicantName_Click(object sender, EventArgs e)
        {
            tbxApplicantName.Text = "";
        }
        // if an option has been selected, prevent another from being selected as well using a for loop
        private void clbTemplateTypeItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i;
            for (i = 0; i < clbTemplateType.Items.Count; i++)
            if (i != e.Index) clbTemplateType.SetItemChecked(i, false);
            if (clbTemplateType.GetItemCheckState(0) == CheckState.Unchecked)
            {
                applicationType = "CV";
                UpdateHeaderText(applicationType, applicationResult);
            }
            else if (clbTemplateType.GetItemCheckState(0) == CheckState.Checked)
            {
                applicationType = "[application type]";
                UpdateHeaderText(applicationType, applicationResult);
            }
            else if (clbTemplateType.GetItemCheckState(1) == CheckState.Unchecked)
            {
                applicationType = "Interview";
                UpdateHeaderText(applicationType, applicationResult);
            }
            else if (clbTemplateType.GetItemCheckState(1) == CheckState.Checked)
            {
                applicationType = "[application type]";
                UpdateHeaderText(applicationType, applicationResult);
            }
            else if (clbTemplateType.GetItemCheckState(2) == CheckState.Unchecked)
            {
                applicationType = "Technical Interview";
                UpdateHeaderText(applicationType, applicationResult);
            }
            else if (clbTemplateType.GetItemCheckState(2) == CheckState.Checked)
            {
                applicationType = "[application type]";
                UpdateHeaderText(applicationType, applicationResult);
            }
        }

        private void clbApplicationResult_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i;
            for (i = 0; i < clbApplicationResult.Items.Count; i++)
                if (i != e.Index) clbApplicationResult.SetItemChecked(i, false);
            if (clbTemplateType.GetItemCheckState(0) == CheckState.Unchecked)
            {
                applicationResult = "successful";
                UpdateHeaderText(applicationType, applicationResult);
            }
            else if (clbTemplateType.GetItemCheckState(0) == CheckState.Checked)
            {
                applicationResult = "[successful/unsuccessful]";
                UpdateHeaderText(applicationType, applicationResult);
            }
            else if (clbTemplateType.GetItemCheckState(1) == CheckState.Unchecked)
            {
                applicationResult = "unsuccessful";
                UpdateHeaderText(applicationType, applicationResult);
            }
            else if (clbTemplateType.GetItemCheckState(1) == CheckState.Checked)
            {
                applicationResult = "[successful/unsuccessful]";
                UpdateHeaderText(applicationType, applicationResult);
            }
        }
        private void UpdateHeadeText(string applicationType, string applicationResult)
        {
            string apt = applicationType;
            string apr = applicationResult;
            tbxHeader.Text = "Dear [ApplicantName], Thank you for applying for a position at HappyTech. I am emailing you to inform you that your " + apt + " has been further reviewed and your application was " + apr + ". The feedback from this is as follows:";
        }

    }
}

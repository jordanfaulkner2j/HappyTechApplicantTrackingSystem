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
    public partial class UserControlCreateTemplate : UserControl
    {
        public string defaultTemplateNameText = "Enter a name for this template...";
        public string sectionDisabledText = "THIS SECTION HAS NOT BEEN ENABLED";
        public string sectionEnabledText = "THIS SECTION HAS BEEN ENABLED";
        bool enableHeaderSection = false;
        bool enableServiceSection = false;
        bool enableWorkPrideSection = false;
        bool enableCooperation_TeamworkSection = false;
        bool enableAdaptabilitySection = false;
        bool enableSelfExpectationsSection = false;
        bool enableOrganisationSection = false;
        bool enableFooterSection = false;
        public UserControlCreateTemplate()
        {
            InitializeComponent();
            tbxHeader.Text = sectionDisabledText;
            tbxService.Text = sectionDisabledText;
            tbxWorkPride.Text = sectionDisabledText;
            tbxCooperation_Teamwork.Text = sectionDisabledText;
            tbxAdaptability.Text = sectionDisabledText;
            tbxSelfExpectations.Text = sectionDisabledText;
            tbxOrganisation.Text = sectionDisabledText;
            tbxAdditionalComments.Text = "THIS SECTION IS ENABLED BY DEFAULT AND CANNOT BE DISABLED.";
            tbxFooter.Text = sectionDisabledText;
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
        // check if employee has selected the header section checkbox
        // if they have, mark the section as enabled and show it in the preview
        private void clbHeader_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbHeader.GetItemChecked(0) == false)
                {
                    enableHeaderSection = true;
                tbxHeader.Text = sectionEnabledText;
            }
            else if (clbHeader.GetItemChecked(0) == true)
            {
                enableHeaderSection = false;
                tbxHeader.Text = sectionDisabledText;
            }
        }
        // check if employee has selected the service section checkbox
        // if they have, mark the section as enabled and show it in the preview
        private void clbService_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbService.GetItemChecked(0) == false)
            {
                enableServiceSection = true;
                tbxService.Text = sectionEnabledText;
            }
            else if (clbService.GetItemChecked(0) == true)
            {
                enableServiceSection = false;
                tbxService.Text = sectionDisabledText;
            }
        }
        // check if employee has selected the work pride section checkbox
        // if they have, mark the section as enabled and show it in the preview
        private void clbWorkPride_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbWorkPride.GetItemChecked(0) == false)
            {
                enableWorkPrideSection = true;
                tbxWorkPride.Text = sectionEnabledText;
            }
            else if (clbWorkPride.GetItemChecked(0) == true)
            {
                enableWorkPrideSection = false;
                tbxWorkPride.Text = sectionDisabledText;
            }
        }
        // check if employee has selected the co-operation and teamwork section checkbox
        // if they have, mark the section as enabled and show it in the preview
        private void clbCooperation_Teamwork_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbCooperation_Teamwork.GetItemChecked(0) == false)
            {
                enableCooperation_TeamworkSection = true;
                tbxCooperation_Teamwork.Text = sectionEnabledText;
            }
            else if (clbCooperation_Teamwork.GetItemChecked(0) == true)
            {
                enableCooperation_TeamworkSection = false;
                tbxCooperation_Teamwork.Text = sectionDisabledText;
            }
        }
        // check if employee has selected the adaptability towards change section checkbox
        // if they have, mark the section as enabled and show it in the preview
        private void clbAdaptability_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbAdaptability.GetItemChecked(0) == false)
            {
                enableAdaptabilitySection = true;
                tbxAdaptability.Text = sectionEnabledText;
            }
            else if (clbAdaptability.GetItemChecked(0) == true)
            {
                enableAdaptabilitySection = false;
                tbxAdaptability.Text = sectionDisabledText;
            }
        }
        // check if employee has selected the self expectations section checkbox
        // if they have, mark the section as enabled and show it in the preview
        private void clbSelfExpectations_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbSelfExpectations.GetItemChecked(0) == false)
            {
                enableSelfExpectationsSection = true;
                tbxSelfExpectations.Text = sectionEnabledText;
            }
            else if (clbSelfExpectations.GetItemChecked(0) == true)
            {
                enableSelfExpectationsSection = false;
                tbxSelfExpectations.Text = sectionDisabledText;
            }
        }
        // check if employee has selected the organisation section checkbox
        // if they have, mark the section as enabled and show it in the preview
        private void clbOrganisation_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbOrganisation.GetItemChecked(0) == false)
            {
                enableOrganisationSection = true;
                tbxOrganisation.Text = sectionEnabledText;
            }
            else if (clbOrganisation.GetItemChecked(0) == true)
            {
                enableOrganisationSection = false;
                tbxOrganisation.Text = sectionDisabledText;
            }
        }
        // check if employee has selected the footer section checkbox
        // if they have, mark the section as enabled and show it in the preview
        private void clbFooter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbFooter.GetItemChecked(0) == false)
            {
                enableFooterSection = true;
                tbxFooter.Text = sectionEnabledText;
            }
            else if (clbFooter.GetItemChecked(0) == true)
            {
                enableFooterSection = false;
                tbxFooter.Text = sectionDisabledText;
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
    }
}

﻿using System;
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
        public string defaultHeaderText = "Select an option for the template type and application success from the 'Template Settings' section or type your own header text here...";
        public string defaultFooterText = "Select an option from the 'Footer' section or type your own footer text here...";
        public static string headerText;
        public static string footerText;
        public static string templateName;
        public static bool editingTemplate;
        public string templateType = "[application type]";
        public string applicationResult = "[successful/unsuccessful]";
        public string selectedCode = "";
        public UserControlCreateEditTemplate()
        {
            InitializeComponent();
            if (editingTemplate == true)
            {
                tbxHeader.Text = headerText;
                tbxFooter.Text = footerText;
                tbxTemplateName.Text = templateName;
                btnSaveTemplate.Text = "UPDATE TEMPLATE";
                InitialiseComments();
                InitialiseEditingState(templateName);
            }
            else
            {
                tbxHeader.Text = defaultHeaderText;
                tbxFooter.Text = defaultFooterText;
                InitialiseComments();
            }
        }

        public CodeManagement CodeManagement
        {
            get => default;
            set
            {
            }
        }

        // get the highest value of the comment_id primary key from the 'comment' table
        // create a for loop that iterates for as long as the highest value (so that all records are included in each iteration)
        // get the section ID of the comment by using its comment ID
        // if the comment ID is missing (e.g. if record containing comment has been deleted), increment by 1 and check to see if the section id of the next comment ID value can be retrieved (iterates until the highest value is reached)
        // TryParse is used so that the program will not crash if the record does not exist
        // once the section ID is retrieved, get the section's title by using its section ID as a parameter for the SELECT WHERE query
        // if the section title equals the name of a label, get the code and comment values using its comment ID
        // add each comment that was found into the checkbox list that matches the section the comment is from
        private void InitialiseComments()
        {
            int highestCommentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.MAX_COMMENT_ID);
            int i;
            int commentID = 1;
            for (i = 0; i < highestCommentID; i++)
            {
                int sectionID = 1;
                string getSectionID = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_SECTION_ID_COMMENT, "comment_id", commentID)));
                bool recordExists = int.TryParse(getSectionID, out sectionID);
                if (recordExists == true)
                {
                    string sectionTitle = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_SECTION, getSectionID));
                    if (sectionTitle == lblUnderstanding.Text)
                    {
                        string code = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_CODE, "comment_id", commentID));
                        string comment = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT, "comment_id", commentID));
                        clbUnderstanding.Items.Add(code + " - " + comment);
                    }
                    else if (sectionTitle == lblImpression.Text)
                    {
                        string code = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_CODE, "comment_id", commentID));
                        string comment = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT, "comment_id", commentID));
                        clbImpression.Items.Add(code + " - " + comment);
                    }
                    else if (sectionTitle == lblQuestions.Text)
                    {
                        string code = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_CODE, "comment_id", commentID));
                        string comment = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT, "comment_id", commentID));
                        clbQuestions.Items.Add(code + " - " + comment);
                    }
                    commentID++;
                }
                else
                {
                    commentID++;
                }
            }
        }
        // run a for loop that iterates for as long as the items in each section's checklist box
        // set each item's checked state to false
        // get the comment ID using each item's code
        // see if the comment already exists in the list_of_comments table (TryParse is used so that the program will not crash)
        // if the comment does exist, set the item's checked state to true
        private void InitialiseEditingState(string title)
        {
            int templateID;
            int commentID;
            int commentIDFromList;
            string itemCode;
            int i;
            for (i = 0; i < clbUnderstanding.Items.Count; i++)
            {
                clbUnderstanding.SetItemChecked(i, false);
                templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                itemCode = clbUnderstanding.Items[i].ToString();
                itemCode = itemCode.Substring(0, 3);
                itemCode = itemCode.Trim();
                commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                string getCommentIDFromList = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                bool commentSelected = int.TryParse(getCommentIDFromList, out commentIDFromList);
                if (commentSelected == true)
                {
                    clbUnderstanding.SetItemChecked(i, true);
                }
            }
            for (i = 0; i < clbImpression.Items.Count; i++)
            {
                clbImpression.SetItemChecked(i, false);
                templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                itemCode = clbImpression.Items[i].ToString();
                itemCode = itemCode.Substring(0, 3);
                itemCode = itemCode.Trim();
                commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                string getCommentIDFromList = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                bool commentSelected = int.TryParse(getCommentIDFromList, out commentIDFromList);
                if (commentSelected == true)
                {
                    clbImpression.SetItemChecked(i, true);
                }
            }
            for (i = 0; i < clbQuestions.Items.Count; i++)
            {
                clbQuestions.SetItemChecked(i, false);
                templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                itemCode = clbQuestions.Items[i].ToString();
                itemCode = itemCode.Substring(0, 3);
                itemCode = itemCode.Trim();
                commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                string getCommentIDFromList = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                bool commentSelected = int.TryParse(getCommentIDFromList, out commentIDFromList);
                if (commentSelected == true)
                {
                    clbQuestions.SetItemChecked(i, true);
                }
            }
        }
        // if the boolean value for editing the template is equal to true
        // run the EditTemplate method with the templateName, preview Header text and preview Footer text as parameters
        // display a message box stating that the template has been updated successfully
        // set the boolean value for editing the template back to false (so that it won't keep editing the same template each time the page is loaded)
        // if the boolean value for editing the template is already equal to false
        // take the employee to the templates page
        // if the boolean value for editing the template is equal to false
        // save contents of template name text box as a string called 'templateName'
        // save contents of header text box as a string called 'header'
        // save contents of footer name text box as a string called 'footer'
        // check to see if a header for the template has been given by the employee
        // check to see if a footer for the template has been given by the employee
        // if 'header' contains the default header text, display a prompt telling them to enter a header for the template
        // if 'footer' contains the default footer text, display a prompt telling them to enter a footer for the template
        // if 'templateName' is blank or contains the default text, display a prompt telling them to enter a name into the text box
        // if 'templateName' has the same name as an existing template, display a prompt stating that a template with the same name already exists
        // if all cgecks pass, proceed with saving the template to the database
        // call method SaveTemplate with templateName, tbxHeader.Text and tbxFooter.Text as parameters
        // display a pop up message box to inform the user it has been saved successfully
        // take the employee to the 'Templates' page
        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            if (editingTemplate == true)
            {
                EditTemplate(templateName, tbxHeader.Text, tbxFooter.Text);
                string title = "Template Updated";
                string message = "Template '" + templateName + "' has been updated successfully.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
                editingTemplate = false;
                Main.mainApplication.OpenPage(new UserControlTemplates());
            }
            else
            {
                string templateName = tbxTemplateName.Text;
                string footer = tbxFooter.Text;
                string header = tbxHeader.Text;
                templateName = templateName.Trim();
                if (templateName == "" || templateName == defaultTemplateNameText)
                {
                    string title = "No Template Name";
                    string message = "Please enter a name for this template before saving.";
                    MessageBox.Show(message, title);
                }
                else if (templateName == DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_TITLE, "title", templateName)))
                {
                    string title = "Template Already Exists";
                    string message = "A template with this name already exists.";
                    MessageBox.Show(message, title);
                }
                else if (header == defaultHeaderText)
                {
                    string title = "No Template Header";
                    string message = "Please enter a header for this template.";
                    MessageBox.Show(message, title);
                }
                else if (footer == defaultFooterText)
                {
                    string title = "No Template Footer";
                    string message = "Please enter a footer for this template.";
                    MessageBox.Show(message, title);
                }
                else
                {
                    SaveTemplate(templateName, tbxHeader.Text, tbxFooter.Text);
                    string title = "Template Saved";
                    string message = "Template has been saved as '" + templateName + "' successfully.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons);
                    Main.mainApplication.OpenPage(new UserControlTemplates());
                }
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
        // ask the employee if they want to discard their changes
        // use a messagebox with yes and no buttons to confirm their choice
        // if they click yes, take them to the templates page
        // set the editingTemplate boolean value to false
        // if they click no, do nothing
        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            string title = "Discard Changes";
            string message = "Are you sure you want to discard all changes made?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                // go back to templates page
                Main.mainApplication.OpenPage(new UserControlTemplates());
                editingTemplate = false;
            }
        }
        // if an option has been checked, prevent another from being checked at the same time using a for loop
        // set templateType depending on the checked option (e.g. if the checkbox next to 'CV' is checked, set templateType to CV)
        // update the header preview text by calling the UpdateHeaderText method with templateType and applicationResult as parameters
        private void clbTemplateTypeItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i;
            for (i = 0; i < clbTemplateType.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    clbTemplateType.SetItemChecked(i, false);
                }

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
                if (i != e.Index)
                {
                    clbApplicationResult.SetItemChecked(i, false);
                }
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
            tbxHeader.Text = "Dear {0},\r\n\r\nThank you for applying as {1} at HappyTech. I am emailing you to inform you that your " + apt + " has been further reviewed and your application was " + apr + ".";
        }
        // store all codes as string, holding a value of the comment that forms the pair
        // if an option has been selected, prevent another from being selected at the same time using a for loop
        // set selectedCode to the code that had the checkbox selected
        // update the text in the footer section of the preview to the comment that the code contains by calling the UpdateFooterText method with selectedCode as a parameter
        private void clbFooter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i;
            string F01 = "Best wishes for the future,\r\n{0}\r\n{1}";
            string F02 = "Kind regards,\r\n{0}\r\n{1}";
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
        private void UpdateFooterText(string code)
        {
            tbxFooter.Text = code;
        }
        // catch parameters as title, header and footer
        // connect to the database and call the UpdateRecord method in the DatabaseManagement class
        // use the INSERT_TEMPLATE query from the DatabaseQueries class with the title, header and footer as parameters
        // get the newly-inserted template's id
        // create a for loop for each checkbox list that runs for as long as the items in each list (items.count)
        // get the code of the checked comment
        // get the comment_id of the comment by using a SELECT WHERE query with the code as the parameter
        // insert each comment's id along with the template's id as a record in the 'list_of_comments' table
        private void SaveTemplate(string title, string header, string footer)
        {
            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.INSERT_TEMPLATE, title, header, footer));
            // inserting into list of comments
            int templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
            int i;
            string itemCode;
            int commentID;
            for (i = 0; i < clbUnderstanding.Items.Count; i++)
            {
                if (clbUnderstanding.GetItemCheckState(i) == CheckState.Checked)
                {
                    itemCode = clbUnderstanding.Items[i].ToString();
                    itemCode = itemCode.Substring(0, 3);
                    itemCode = itemCode.Trim();
                    commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                    DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.INSERT_LIST_OF_COMMENTS, commentID, templateID));
                }
            }
            for (i = 0; i < clbImpression.Items.Count; i++)
            {
                if (clbImpression.GetItemCheckState(i) == CheckState.Checked)
                {
                    itemCode = clbImpression.Items[i].ToString();
                    itemCode = itemCode.Substring(0, 3);
                    itemCode = itemCode.Trim();
                    commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                    DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.INSERT_LIST_OF_COMMENTS, commentID, templateID));
                }
                for (i = 0; i < clbQuestions.Items.Count; i++)
                {
                    if (clbQuestions.GetItemCheckState(i) == CheckState.Checked)
                    {
                        itemCode = clbQuestions.Items[i].ToString();
                        itemCode = itemCode.Substring(0, 3);
                        itemCode = itemCode.Trim();
                        commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                        DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.INSERT_LIST_OF_COMMENTS, commentID, templateID));
                    }
                }
            }
        }
        // catch parameters as title, header and footer
        // get the template_id attribute using the title and store this as an integer
        // connect to the database and call the UpdateRecord method in the DatabaseManagement class
        // use the UPDATE_TEMPLATE query from the DatabaseQueries class with the template title, header and footer variables as parameters, and a WHERE clause with the template_id as a parameter
        // run a for loop for each checkbox list that iterates for as long as the number of items (using clb.Count to get this value)
        // get the comment ID for each checked comment
        // check to see if the comment has already been inserted into the list_of_comments table
        // TryParse is used so that the program won't crash
        // if it hasn't, insert it into the table with the comment_id and template_id as parameters
        // run a for loop for each checkbox list that iterates for as long as the number of items (using clb.Count to get this value)
        // get the comment ID for each unchecked comment
        // check to see if the comment has already been inserted into the list_of_comments table
        // if it has, remove it from the list_of_comments table using a DELETE FROM query with the comment_id and template_id as parameters
        private void EditTemplate(string title, string header, string footer)
        {
            int templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
            title = tbxTemplateName.Text;
            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.UPDATE_TEMPLATE, title, header, footer, templateID));
            // inserting or deleting records in list_of_comments table
            int i;
            string itemCode;
            int commentID;
            for (i = 0; i < clbUnderstanding.Items.Count; i++)
            {
                if (clbUnderstanding.GetItemCheckState(i) == CheckState.Checked)
                {
                    itemCode = clbUnderstanding.Items[i].ToString();
                    itemCode = itemCode.Substring(0, 3);
                    itemCode = itemCode.Trim();
                    commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                    templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                    int existingCommentID;
                    string getCommentID = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                    bool commentExists = int.TryParse(getCommentID, out existingCommentID);
                    if (commentExists == false)
                    {
                        DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.INSERT_LIST_OF_COMMENTS, commentID, templateID));
                    }
                }
                else if (clbUnderstanding.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    itemCode = clbUnderstanding.Items[i].ToString();
                    itemCode = itemCode.Substring(0, 3);
                    itemCode = itemCode.Trim();
                    commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                    templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                    int existingCommentID;
                    string getCommentID = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                    bool commentExists = int.TryParse(getCommentID, out existingCommentID);
                    if (commentExists == true)
                    {
                        DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.DELETE_LIST_OF_COMMENTS, "comment_id", commentID, "template_id", templateID));
                    }
                }
            }
            for (i = 0; i < clbImpression.Items.Count; i++)
            {
                if (clbImpression.GetItemCheckState(i) == CheckState.Checked)
                {
                    itemCode = clbImpression.Items[i].ToString();
                    itemCode = itemCode.Substring(0, 3);
                    itemCode = itemCode.Trim();
                    commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                    templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                    int existingCommentID;
                    string getCommentID = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                    bool commentExists = int.TryParse(getCommentID, out existingCommentID);
                    if (commentExists == false)
                    {
                        DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.INSERT_LIST_OF_COMMENTS, commentID, templateID));
                    }
                }
                else if (clbImpression.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    itemCode = clbImpression.Items[i].ToString();
                    itemCode = itemCode.Substring(0, 3);
                    itemCode = itemCode.Trim();
                    commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                    templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                    int existingCommentID;
                    string getCommentID = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                    bool commentExists = int.TryParse(getCommentID, out existingCommentID);
                    if (commentExists == true)
                    {
                        DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.DELETE_LIST_OF_COMMENTS, "comment_id", commentID, "template_id", templateID));
                    }
                }
                for (i = 0; i < clbQuestions.Items.Count; i++)
                {
                    if (clbQuestions.GetItemCheckState(i) == CheckState.Checked)
                    {
                        itemCode = clbQuestions.Items[i].ToString();
                        itemCode = itemCode.Substring(0, 3);
                        itemCode = itemCode.Trim();
                        commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                        templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                        int existingCommentID;
                        string getCommentID = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                        bool commentExists = int.TryParse(getCommentID, out existingCommentID);
                        if (commentExists == true)
                        {
                            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.INSERT_LIST_OF_COMMENTS, commentID, templateID));
                        }
                    }
                    else if (clbQuestions.GetItemCheckState(i) == CheckState.Unchecked)
                    {
                        itemCode = clbQuestions.Items[i].ToString();
                        itemCode = itemCode.Substring(0, 3);
                        itemCode = itemCode.Trim();
                        commentID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID, "code", itemCode));
                        templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_TEMPLATE_ID, title));
                        int existingCommentID;
                        string getCommentID = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(string.Format(DatabaseQueries.GET_COMMENT_ID_LIST, "comment_id", commentID, "template_id", templateID)));
                        bool commentExists = int.TryParse(getCommentID, out existingCommentID);
                        if (commentExists == true)
                        {
                            DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(string.Format(DatabaseQueries.DELETE_LIST_OF_COMMENTS, "comment_id", commentID, "template_id", templateID));
                        }
                    }
                }
            }
        }
        // if the button to add a new code within the Understanding of HappyTech's Values section is clicked
        // show the CodeManagement form
        private void btnAddUnderstandingCode_Click(object sender, EventArgs e)
        {
            CodeManagement addCode = new CodeManagement();
            addCode.Show();
        }
        // if the button to add a new code within the Impression of Applicant section is clicked
        // show the CodeManagement form
        private void btnAddImpressionCode_Click(object sender, EventArgs e)
        {
            CodeManagement addCode = new CodeManagement();
            addCode.ShowDialog();
        }
        // if the button to add a new code within the Applicant Questions section is clicked
        // show the CodeManagement form
        private void btnAddQuestionsCode_Click(object sender, EventArgs e)
        {
            CodeManagement addCode = new CodeManagement();
            addCode.ShowDialog();
        }
    }
}

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
    public partial class UserControlTemplates : UserControl
    {
        public UserControlTemplates()
        {
            InitializeComponent();
        }

        private void UserControlTemplates_Load(object sender, EventArgs e)
        {
            // get dataset from database based on provided SQL query
            dgvTemplates.DataSource = DatabaseManagement.GetInstanceOfDatabaseConnection().GetDataSet(DatabaseQueries.TEMPLATES).Tables[0];
            this.templateTableAdapter.Fill(this.templateDataSet.template);
        }
        // when the edit button is clicked
        // store the template title as string - this is taken from the text value of the combo box that is used to select the template
        // set the public header text string variable in the CreateEditTemplate UserControl as the header value of the existing template
        // set the public footer text string variable in the CreateEditTemplate UserControl as the footer value of the existing template
        // set the public editing template boolean variable in the CreateEditTemplate UserControl to true
        // take the employee to the CreateEditTemplate page
        private void btnEditTemplate_Click(object sender, EventArgs e)
        {
            string templateName = cmbSelectedTemplateTitle.Text;
            UserControlCreateEditTemplate.templateName = templateName;
            UserControlCreateEditTemplate.headerText = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_TEMPLATE_HEADER + " title = '" + templateName + "'");
            UserControlCreateEditTemplate.footerText = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_TEMPLATE_FOOTER + " title = '" + templateName + "'");
            UserControlCreateEditTemplate.editingTemplate = true;
            Main.mainApplication.OpenPage(new UserControlCreateEditTemplate());
        }
        // display a message box asking the employee to confirm their choice of action
        // if they click the 'Yes' button, get the template's ID and delete the template from the database that matches the ID
        // make another message box pop up confirming that the template has been deleted
        // if they click the 'No' button, do nothing
        private void btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            string templateTitle = cmbSelectedTemplateTitle.Text;
            string message = "Are you sure you want to delete the following template? \n \nTemplate: " + templateTitle;
            string title = "Delete Template";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int templateID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_TEMPLATE_ID + " title = '" + templateTitle + "'");
                DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(DatabaseQueries.DELETE_TEMPLATE + " template_id = '" + templateID + "'");
                message = "Template was deleted successfully.";
                title = "Delete Template";
                MessageBox.Show(message, title);
                UpdateTable();
            }
        }
        // refreshes the template table inside of the data grid
        private void UpdateTable()
        {
            this.templateTableAdapter.Fill(this.templateDataSet.template);
        }
    }
}

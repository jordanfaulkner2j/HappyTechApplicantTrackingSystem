using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicantTrackingSystem
{
    public partial class CodeManagement : Form
    {
        string code;
        string comment;
        int sectionID;
        public CodeManagement()
        {
            InitializeComponent();
        }
        private void AddCode_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.section' table. You can move, or remove it, as needed.
            this.sectionTableAdapter.Fill(this.databaseDataSet.section);
            // TODO: This line of code loads data into the 'databaseCommentDataSet.comment' table. You can move, or remove it, as needed.
            this.commentTableAdapter.Fill(this.databaseCommentDataSet.comment);
        }
        // when the add code button is clicked
        // catch the values in the text boxes and store them as string
        // check to see if any text boxes have no value; if so, display a message box asking the user to make sure every text box is entered
        // check to see that the code entered does not already exist; if so, display a message box stating that the code already exists
        // if both checks pass, add the record to the table and display a message box stating that the code and comment have been entered successfully
        private void btnAddCode_Click(object sender, EventArgs e)
        {
            code = tbxCode.Text;
            code = code.Trim();
            comment = tbxComment.Text;
            comment = comment.Trim();
            string sectionTitle = cmbSectionTitle.Text;
            int sectionID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_SECTION_ID_SECTION + " title = '" + sectionTitle + "'");
            if (sectionID == 0 || code == "" || comment == "")
            {
                string title = "Missing Data";
                string message = "Comment could not be saved. Please make sure all fields have been entered.";
                MessageBox.Show(message, title);
            }
            else if (code == DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_CODE + " code = '" + code + "'"))
            {
                string title = "Code Already Exists";
                string message = "A comment with this code already exists.";
                MessageBox.Show(message, title);
            }
            else
            {
                string data = "'" + sectionID + "', '" + code + "', '" + comment + "')";
                DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(DatabaseQueries.INSERT_COMMENT + data);
                string title = "Code Added Successfully";
                string message = "The code has been added successfully.";
                MessageBox.Show(message, title);
                UpdateTables();
                cmbSectionTitle.Text = "";
                tbxCode.Clear();
                tbxComment.Clear();
            }
        }
        // when the delete code button is clicked
        // check to see if the code text box has been left empty; if so, display a message box asking for a code to be entered into the text box
        // once a code is entered, get the comment_id with the WHERE condition as code = 'code'
        // get the comment with the WHERE condition as code = 'code'
        // get the section_id with the WHERE condition as code = 'code'
        // display a message box asking the employee if they are sure about deleting the comment that matches the code they entered
        // the section_id, code and comment are part of the message so that it is easier for the employee to double-check that they entered the right code
        // if they clicked 'Yes', then delete the code and make a message box pop up informing them that the comment has been deleted and refresh the data grid view; if they clicked 'No', do nothing
        private void btnDeleteCode_Click(object sender, EventArgs e)
        {
            code = tbxCode.Text;
            code = code.Trim();
            string title;
            string message;
            if (code == "")
            {
                title = "No Code Entered";
                message = "Please enter the code of the comment you want to remove in the code textbox.";
                MessageBox.Show(message, title);
            }
            else
            {
                string commentID = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_COMMENT_ID + " code = '" + code + "'"));
                comment = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_COMMENT + " code = '" + code + "'");
                sectionID = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_SECTION_ID_COMMENT + " code = '" + code + "'");
                string section = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_SECTION + " section_ID = '" + sectionID + "'");
                title = "Delete Comment";
                message = "Are you sure you want to delete the following comment?" + '\n' + '\n' + "Section: " + section + '\n' + "ID: " + commentID + ", Code: " + code + ", Comment: " + comment;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(DatabaseQueries.DELETE_COMMENT + " comment_id = '" + commentID + "'");
                    title = "Delete Comment";
                    message = "Comment successfully deleted from table.";
                    MessageBox.Show(message, title);
                    UpdateTables();
                }
            }
        }
        private void UpdateTables()
        {
            this.sectionTableAdapter.Fill(this.databaseDataSet.section);
            this.commentTableAdapter.Fill(this.databaseCommentDataSet.comment);
        }
    }
}

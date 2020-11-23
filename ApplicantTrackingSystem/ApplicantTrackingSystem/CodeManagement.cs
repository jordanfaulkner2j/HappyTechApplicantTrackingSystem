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
        public static string sectionID;
        string code;
        string comment;
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
            tbxSectionID.Text = sectionID.Trim();
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
            if (sectionID == "" || code == "" || comment == "")
            {
                string title = "Missing Data";
                string message = "Comment could not be saved. Please make sure all fields have been entered.";
                MessageBox.Show(message, title);
            }
            else if (code == DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_CODE + code + "'"))
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
                tbxSectionID.Clear();
                tbxCode.Clear();
                tbxComment.Clear();
            }
        }
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
                string commentID = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_COMMENT_ID + code + "'"));
                comment = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_COMMENT + code + "'");
                sectionID = Convert.ToString(DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_SECTION_ID_COMMENT + code + "'"));
                string section = DatabaseManagement.GetInstanceOfDatabaseConnection().GetSingleAttribute(DatabaseQueries.GET_SECTION + sectionID + "'");
                title = "Delete Comment";
                message = "Are you sure you want to delete the following comment?" + '\n' + '\n' + "Section: " + section + '\n' + "ID: " + commentID + ", Code: " + code + ", Comment: " + comment;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    DatabaseManagement.GetInstanceOfDatabaseConnection().UpdateRecord(DatabaseQueries.DELETE_COMMENT + commentID + "'");
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

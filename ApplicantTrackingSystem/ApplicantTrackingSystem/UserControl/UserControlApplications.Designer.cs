namespace ApplicantTrackingSystem
{
    partial class UserControlApplications
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.comboBoxJobPositions = new System.Windows.Forms.ComboBox();
            this.comboBoxViewOnly = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToOrderColumns = true;
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvApplications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvApplications.Location = new System.Drawing.Point(0, 51);
            this.dgvApplications.Margin = new System.Windows.Forms.Padding(2);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.RowHeadersWidth = 100;
            this.dgvApplications.RowTemplate.Height = 33;
            this.dgvApplications.Size = new System.Drawing.Size(968, 333);
            this.dgvApplications.TabIndex = 5;
            this.dgvApplications.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplications_CellDoubleClick);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(11, 11);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(217, 34);
            this.textBoxFirstName.TabIndex = 6;
            this.textBoxFirstName.Text = "Search by first name";
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(234, 11);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(207, 34);
            this.textBoxLastName.TabIndex = 7;
            this.textBoxLastName.Text = "Search by last name";
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            this.textBoxLastName.Enter += new System.EventHandler(this.textBoxLastName_Enter);
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "No Sort",
            "Sort by Date",
            "Sort by Job Position",
            "Sort by First Name",
            "Sort by Last Name"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(629, 11);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(141, 36);
            this.comboBoxSortBy.TabIndex = 8;
            this.comboBoxSortBy.Text = "Select Sort Option";
            this.comboBoxSortBy.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSortBy_SelectionChangeCommitted);
            // 
            // comboBoxJobPositions
            // 
            this.comboBoxJobPositions.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxJobPositions.FormattingEnabled = true;
            this.comboBoxJobPositions.Items.AddRange(new object[] {
            "All",
            "Software Engineer",
            "Marketing Manager"});
            this.comboBoxJobPositions.Location = new System.Drawing.Point(447, 11);
            this.comboBoxJobPositions.Name = "comboBoxJobPositions";
            this.comboBoxJobPositions.Size = new System.Drawing.Size(176, 36);
            this.comboBoxJobPositions.TabIndex = 9;
            this.comboBoxJobPositions.Text = "Select job position";
            this.comboBoxJobPositions.SelectionChangeCommitted += new System.EventHandler(this.comboBoxJobPositions_SelectionChangeCommitted);
            // 
            // comboBoxViewOnly
            // 
            this.comboBoxViewOnly.FormattingEnabled = true;
            this.comboBoxViewOnly.Items.AddRange(new object[] {
            "View all",
            "View only interviewed",
            "View only completed"});
            this.comboBoxViewOnly.Location = new System.Drawing.Point(776, 11);
            this.comboBoxViewOnly.Name = "comboBoxViewOnly";
            this.comboBoxViewOnly.Size = new System.Drawing.Size(179, 36);
            this.comboBoxViewOnly.TabIndex = 10;
            this.comboBoxViewOnly.Text = "View only interviewed";
            this.comboBoxViewOnly.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewOnly_SelectedIndexChanged);
            // 
            // UserControlApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxViewOnly);
            this.Controls.Add(this.comboBoxJobPositions);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.dgvApplications);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlApplications";
            this.Size = new System.Drawing.Size(968, 384);
            this.Load += new System.EventHandler(this.UserControlApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.ComboBox comboBoxJobPositions;
        private System.Windows.Forms.ComboBox comboBoxViewOnly;
    }
}

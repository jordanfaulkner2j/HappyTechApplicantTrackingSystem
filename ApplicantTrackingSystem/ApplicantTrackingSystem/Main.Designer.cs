namespace ApplicantTrackingSystem
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.createNewTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBody = new System.Windows.Forms.Panel();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelApplicationsRemaining = new System.Windows.Forms.Label();
            this.labelApplicationsCompleted = new System.Windows.Forms.Label();
            this.labelNumberRemaining = new System.Windows.Forms.Label();
            this.labelNumberCompleted = new System.Windows.Forms.Label();
            this.pageMyProfile = new ApplicantTrackingSystem.UserControlMyProfile();
            this.pageEmployees = new ApplicantTrackingSystem.UserControlEmployees();
            this.pageApplications = new ApplicantTrackingSystem.UserControlApplications();
            this.pageTemplates = new ApplicantTrackingSystem.UserControlTemplates();
            this.pageCreateEditTemplate = new ApplicantTrackingSystem.UserControlCreateTemplate();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.menuBar.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.labelNumberCompleted);
            this.panelWelcome.Controls.Add(this.labelNumberRemaining);
            this.panelWelcome.Controls.Add(this.labelApplicationsCompleted);
            this.panelWelcome.Controls.Add(this.labelApplicationsRemaining);
            this.panelWelcome.Controls.Add(this.labelEmployeeName);
            this.panelWelcome.Controls.Add(this.pictureBoxLogo);
            this.panelWelcome.Controls.Add(this.menuBar);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(968, 138);
            this.panelWelcome.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ApplicantTrackingSystem.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(25, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 81);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewTemplateToolStripMenuItem,
            this.templatesToolStripMenuItem,
            this.applicationsToolStripMenuItem,
            this.manageEmployeesToolStripMenuItem,
            this.myProfileSettingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 108);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(968, 30);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // createNewTemplateToolStripMenuItem
            // 
            this.createNewTemplateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.createNewTemplateToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.createNewTemplateToolStripMenuItem.Name = "createNewTemplateToolStripMenuItem";
            this.createNewTemplateToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.createNewTemplateToolStripMenuItem.Text = "Create New Template";
            this.createNewTemplateToolStripMenuItem.Click += new System.EventHandler(this.createNewTemplateToolStripMenuItem_Click);
            // 
            // templatesToolStripMenuItem
            // 
            this.templatesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            this.templatesToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.templatesToolStripMenuItem.Text = "Templates";
            this.templatesToolStripMenuItem.Click += new System.EventHandler(this.templatesToolStripMenuItem_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.applicationsToolStripMenuItem.Text = "Applications";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.manageEmployeesToolStripMenuItem.Text = "Manage Employee Accounts";
            this.manageEmployeesToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeesToolStripMenuItem_Click);
            // 
            // myProfileSettingsToolStripMenuItem
            // 
            this.myProfileSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.myProfileSettingsToolStripMenuItem.Name = "myProfileSettingsToolStripMenuItem";
            this.myProfileSettingsToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.myProfileSettingsToolStripMenuItem.Text = "My Profile Settings";
            this.myProfileSettingsToolStripMenuItem.Click += new System.EventHandler(this.myProfileSettingsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.pageMyProfile);
            this.panelBody.Controls.Add(this.pageEmployees);
            this.panelBody.Controls.Add(this.pageApplications);
            this.panelBody.Controls.Add(this.pageTemplates);
            this.panelBody.Controls.Add(this.pageCreateEditTemplate);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(968, 522);
            this.panelBody.TabIndex = 2;
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.Location = new System.Drawing.Point(181, 9);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(281, 40);
            this.labelEmployeeName.TabIndex = 4;
            this.labelEmployeeName.Text = "Welcome Full Name";
            // 
            // labelApplicationsRemaining
            // 
            this.labelApplicationsRemaining.AutoSize = true;
            this.labelApplicationsRemaining.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationsRemaining.Location = new System.Drawing.Point(184, 52);
            this.labelApplicationsRemaining.Name = "labelApplicationsRemaining";
            this.labelApplicationsRemaining.Size = new System.Drawing.Size(325, 20);
            this.labelApplicationsRemaining.TabIndex = 5;
            this.labelApplicationsRemaining.Text = "Number of applications waiting to be reviewed:";
            // 
            // labelApplicationsCompleted
            // 
            this.labelApplicationsCompleted.AutoSize = true;
            this.labelApplicationsCompleted.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationsCompleted.Location = new System.Drawing.Point(184, 73);
            this.labelApplicationsCompleted.Name = "labelApplicationsCompleted";
            this.labelApplicationsCompleted.Size = new System.Drawing.Size(279, 20);
            this.labelApplicationsCompleted.TabIndex = 6;
            this.labelApplicationsCompleted.Text = "Total number of applications completed:";
            // 
            // labelNumberRemaining
            // 
            this.labelNumberRemaining.AutoSize = true;
            this.labelNumberRemaining.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberRemaining.Location = new System.Drawing.Point(507, 52);
            this.labelNumberRemaining.Name = "labelNumberRemaining";
            this.labelNumberRemaining.Size = new System.Drawing.Size(17, 20);
            this.labelNumberRemaining.TabIndex = 7;
            this.labelNumberRemaining.Text = "9";
            // 
            // labelNumberCompleted
            // 
            this.labelNumberCompleted.AutoSize = true;
            this.labelNumberCompleted.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberCompleted.Location = new System.Drawing.Point(461, 73);
            this.labelNumberCompleted.Name = "labelNumberCompleted";
            this.labelNumberCompleted.Size = new System.Drawing.Size(17, 20);
            this.labelNumberCompleted.TabIndex = 8;
            this.labelNumberCompleted.Text = "2";
            // 
            // pageMyProfile
            // 
            this.pageMyProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageMyProfile.Location = new System.Drawing.Point(0, 138);
            this.pageMyProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageMyProfile.Name = "pageMyProfile";
            this.pageMyProfile.Size = new System.Drawing.Size(968, 384);
            this.pageMyProfile.TabIndex = 4;
            // 
            // pageEmployees
            // 
            this.pageEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageEmployees.Location = new System.Drawing.Point(0, 138);
            this.pageEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageEmployees.Name = "pageEmployees";
            this.pageEmployees.Size = new System.Drawing.Size(968, 384);
            this.pageEmployees.TabIndex = 3;
            // 
            // pageApplications
            // 
            this.pageApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageApplications.Location = new System.Drawing.Point(0, 138);
            this.pageApplications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageApplications.Name = "pageApplications";
            this.pageApplications.Size = new System.Drawing.Size(968, 384);
            this.pageApplications.TabIndex = 2;
            // 
            // pageTemplates
            // 
            this.pageTemplates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTemplates.Location = new System.Drawing.Point(0, 138);
            this.pageTemplates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageTemplates.Name = "pageTemplates";
            this.pageTemplates.Size = new System.Drawing.Size(968, 384);
            this.pageTemplates.TabIndex = 1;
            // 
            // pageCreateEditTemplate
            // 
            this.pageCreateEditTemplate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pageCreateEditTemplate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageCreateEditTemplate.Location = new System.Drawing.Point(0, 138);
            this.pageCreateEditTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageCreateEditTemplate.Name = "pageCreateEditTemplate";
            this.pageCreateEditTemplate.Size = new System.Drawing.Size(968, 384);
            this.pageCreateEditTemplate.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(968, 522);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panelBody);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(980, 550);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant Tracking System";
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ToolStripMenuItem createNewTemplateToolStripMenuItem;
        private UserControlMyProfile pageMyProfile;
        private UserControlEmployees pageEmployees;
        private UserControlApplications pageApplications;
        private UserControlCreateTemplate pageCreateEditTemplate;
        private UserControlTemplates pageTemplates;
        private System.Windows.Forms.Label labelApplicationsCompleted;
        private System.Windows.Forms.Label labelApplicationsRemaining;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label labelNumberCompleted;
        private System.Windows.Forms.Label labelNumberRemaining;
    }
}
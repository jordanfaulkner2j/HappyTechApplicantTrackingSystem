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
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.createNewTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageCreateEditTemplate = new ApplicantTrackingSystem.UserControlCreateTemplate();
            this.pageApplications = new ApplicantTrackingSystem.UserControlApplications();
            this.pageMyProfile = new ApplicantTrackingSystem.UserControlMyProfile();
            this.pageEmployees = new ApplicantTrackingSystem.UserControlEmployees();
            this.pageTemplates = new ApplicantTrackingSystem.UserControlTemplates();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.menuBar.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.pictureBoxLogo);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1974, 80);
            this.panelWelcome.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ApplicantTrackingSystem.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(25, 4);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 72);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // templatesToolStripMenuItem
            // 
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            this.templatesToolStripMenuItem.Size = new System.Drawing.Size(177, 52);
            this.templatesToolStripMenuItem.Text = "Templates";
            this.templatesToolStripMenuItem.Click += new System.EventHandler(this.templatesToolStripMenuItem_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(204, 52);
            this.applicationsToolStripMenuItem.Text = "Applications";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // myProfileSettingsToolStripMenuItem
            // 
            this.myProfileSettingsToolStripMenuItem.Name = "myProfileSettingsToolStripMenuItem";
            this.myProfileSettingsToolStripMenuItem.Size = new System.Drawing.Size(299, 52);
            this.myProfileSettingsToolStripMenuItem.Text = "My Profile Settings";
            this.myProfileSettingsToolStripMenuItem.Click += new System.EventHandler(this.myProfileSettingsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(148, 52);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.Dock = System.Windows.Forms.DockStyle.None;
            this.menuBar.Font = new System.Drawing.Font("Arial", 12F);
            this.menuBar.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewTemplateToolStripMenuItem,
            this.templatesToolStripMenuItem,
            this.applicationsToolStripMenuItem,
            this.manageEmployeesToolStripMenuItem,
            this.myProfileSettingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 82);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuBar.Size = new System.Drawing.Size(1974, 58);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // createNewTemplateToolStripMenuItem
            // 
            this.createNewTemplateToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.createNewTemplateToolStripMenuItem.Name = "createNewTemplateToolStripMenuItem";
            this.createNewTemplateToolStripMenuItem.Size = new System.Drawing.Size(335, 52);
            this.createNewTemplateToolStripMenuItem.Text = "Create New Template";
            this.createNewTemplateToolStripMenuItem.Click += new System.EventHandler(this.createNewTemplateToolStripMenuItem_Click);
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(433, 52);
            this.manageEmployeesToolStripMenuItem.Text = "Manage Employee Accounts";
            this.manageEmployeesToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeesToolStripMenuItem_Click);
            // 
            // pageCreateEditTemplate
            // 
            this.pageCreateEditTemplate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageCreateEditTemplate.Location = new System.Drawing.Point(0, 144);
            this.pageCreateEditTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pageCreateEditTemplate.Name = "pageCreateEditTemplate";
            this.pageCreateEditTemplate.Size = new System.Drawing.Size(1975, 785);
            this.pageCreateEditTemplate.TabIndex = 0;
            // 
            // pageApplications
            // 
            this.pageApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageApplications.Location = new System.Drawing.Point(0, 0);
            this.pageApplications.Margin = new System.Windows.Forms.Padding(4);
            this.pageApplications.Name = "pageApplications";
            this.pageApplications.Size = new System.Drawing.Size(1975, 785);
            this.pageApplications.TabIndex = 2;
            // 
            // pageMyProfile
            // 
            this.pageMyProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageMyProfile.Location = new System.Drawing.Point(0, 0);
            this.pageMyProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pageMyProfile.Name = "pageMyProfile";
            this.pageMyProfile.Size = new System.Drawing.Size(1975, 785);
            this.pageMyProfile.TabIndex = 4;
            // 
            // pageEmployees
            // 
            this.pageEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageEmployees.Location = new System.Drawing.Point(0, 0);
            this.pageEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.pageEmployees.Name = "pageEmployees";
            this.pageEmployees.Size = new System.Drawing.Size(1975, 785);
            this.pageEmployees.TabIndex = 3;
            // 
            // pageTemplates
            // 
            this.pageTemplates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTemplates.Location = new System.Drawing.Point(0, 0);
            this.pageTemplates.Margin = new System.Windows.Forms.Padding(4);
            this.pageTemplates.Name = "pageTemplates";
            this.pageTemplates.Size = new System.Drawing.Size(1975, 785);
            this.pageTemplates.TabIndex = 1;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.pageTemplates);
            this.panelBody.Controls.Add(this.pageEmployees);
            this.panelBody.Controls.Add(this.pageMyProfile);
            this.panelBody.Controls.Add(this.pageApplications);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBody.Location = new System.Drawing.Point(0, 144);
            this.panelBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1974, 785);
            this.panelBody.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 929);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.pageCreateEditTemplate);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant Tracking System";
            this.panelWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ToolStripMenuItem createNewTemplateToolStripMenuItem;
        private UserControlCreateTemplate pageCreateEditTemplate;
        private UserControlApplications pageApplications;
        private UserControlMyProfile pageMyProfile;
        private UserControlEmployees pageEmployees;
        private UserControlTemplates pageTemplates;
        private System.Windows.Forms.Panel panelBody;
    }
}
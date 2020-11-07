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
            this.panelBody = new System.Windows.Forms.Panel();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.createNewTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageCreateEditTemplate = new ApplicantTrackingSystem.UserControlCreateTemplate();
            this.pageMyProfile = new ApplicantTrackingSystem.UserControlMyProfile();
            this.pageEmployees = new ApplicantTrackingSystem.UserControlEmployees();
            this.pageApplications = new ApplicantTrackingSystem.UserControlApplications();
            this.pageTemplates = new ApplicantTrackingSystem.UserControlTemplates();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelBody.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.pictureBoxLogo);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1974, 100);
            this.panelWelcome.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ApplicantTrackingSystem.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(25, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 90);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.pageEmployees);
            this.panelBody.Controls.Add(this.pageApplications);
            this.panelBody.Controls.Add(this.pageTemplates);
            this.panelBody.Controls.Add(this.pageMyProfile);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBody.Location = new System.Drawing.Point(0, 504);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1974, 425);
            this.panelBody.TabIndex = 2;
            // 
            // templatesToolStripMenuItem
            // 
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            this.templatesToolStripMenuItem.Size = new System.Drawing.Size(177, 68);
            this.templatesToolStripMenuItem.Text = "Templates";
            this.templatesToolStripMenuItem.Click += new System.EventHandler(this.templatesToolStripMenuItem_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(204, 68);
            this.applicationsToolStripMenuItem.Text = "Applications";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // myProfileSettingsToolStripMenuItem
            // 
            this.myProfileSettingsToolStripMenuItem.Name = "myProfileSettingsToolStripMenuItem";
            this.myProfileSettingsToolStripMenuItem.Size = new System.Drawing.Size(299, 68);
            this.myProfileSettingsToolStripMenuItem.Text = "My Profile Settings";
            this.myProfileSettingsToolStripMenuItem.Click += new System.EventHandler(this.myProfileSettingsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(148, 68);
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
            this.menuBar.Location = new System.Drawing.Point(0, 103);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1974, 72);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // createNewTemplateToolStripMenuItem
            // 
            this.createNewTemplateToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.createNewTemplateToolStripMenuItem.Name = "createNewTemplateToolStripMenuItem";
            this.createNewTemplateToolStripMenuItem.Size = new System.Drawing.Size(335, 68);
            this.createNewTemplateToolStripMenuItem.Text = "Create New Template";
            this.createNewTemplateToolStripMenuItem.Click += new System.EventHandler(this.createNewTemplateToolStripMenuItem_Click);
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(433, 68);
            this.manageEmployeesToolStripMenuItem.Text = "Manage Employee Accounts";
            this.manageEmployeesToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeesToolStripMenuItem_Click);
            // 
            // pageCreateEditTemplate
            // 
            this.pageCreateEditTemplate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageCreateEditTemplate.Location = new System.Drawing.Point(1, 174);
            this.pageCreateEditTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageCreateEditTemplate.Name = "pageCreateEditTemplate";
            this.pageCreateEditTemplate.Size = new System.Drawing.Size(1974, 755);
            this.pageCreateEditTemplate.TabIndex = 0;
            // 
            // pageMyProfile
            // 
            this.pageMyProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageMyProfile.Location = new System.Drawing.Point(0, -330);
            this.pageMyProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageMyProfile.Name = "pageMyProfile";
            this.pageMyProfile.Size = new System.Drawing.Size(1975, 750);
            this.pageMyProfile.TabIndex = 4;
            // 
            // pageEmployees
            // 
            this.pageEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageEmployees.Location = new System.Drawing.Point(0, -330);
            this.pageEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageEmployees.Name = "pageEmployees";
            this.pageEmployees.Size = new System.Drawing.Size(1975, 755);
            this.pageEmployees.TabIndex = 3;
            // 
            // pageApplications
            // 
            this.pageApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageApplications.Location = new System.Drawing.Point(0, -330);
            this.pageApplications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageApplications.Name = "pageApplications";
            this.pageApplications.Size = new System.Drawing.Size(1975, 755);
            this.pageApplications.TabIndex = 2;
            // 
            // pageTemplates
            // 
            this.pageTemplates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTemplates.Location = new System.Drawing.Point(0, -330);
            this.pageTemplates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageTemplates.Name = "pageTemplates";
            this.pageTemplates.Size = new System.Drawing.Size(1975, 755);
            this.pageTemplates.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(1, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1974, 755);
            this.panel1.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 929);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.pageCreateEditTemplate);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant Tracking System";
            this.panelWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
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
        private UserControlTemplates pageTemplates;
        private UserControlCreateTemplate pageCreateEditTemplate;
        private System.Windows.Forms.Panel panel1;
    }
}
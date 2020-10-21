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
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.createNewTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageApplications = new ApplicantTrackingSystem.UserControlApplications();
            this.pageEmployees = new ApplicantTrackingSystem.UserControlEmployees();
            this.panelBody.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(984, 100);
            this.panelWelcome.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.pageApplications);
            this.panelBody.Controls.Add(this.pageEmployees);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBody.Location = new System.Drawing.Point(0, 136);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(984, 425);
            this.panelBody.TabIndex = 2;
            // 
            // createNewTemplateToolStripMenuItem
            // 
            this.createNewTemplateToolStripMenuItem.Name = "createNewTemplateToolStripMenuItem";
            this.createNewTemplateToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.createNewTemplateToolStripMenuItem.Text = "Create New Template";
            // 
            // templatesToolStripMenuItem
            // 
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            this.templatesToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.templatesToolStripMenuItem.Text = "Templates";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.applicationsToolStripMenuItem.Text = "Applications";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // myProfileSettingsToolStripMenuItem
            // 
            this.myProfileSettingsToolStripMenuItem.Name = "myProfileSettingsToolStripMenuItem";
            this.myProfileSettingsToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.myProfileSettingsToolStripMenuItem.Text = "My Profile Settings";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // menuBar
            // 
            this.menuBar.AutoSize = false;
            this.menuBar.Dock = System.Windows.Forms.DockStyle.None;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewTemplateToolStripMenuItem,
            this.templatesToolStripMenuItem,
            this.applicationsToolStripMenuItem,
            this.myProfileSettingsToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.manageEmployeesToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 103);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(984, 30);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.manageEmployeesToolStripMenuItem.Text = "Manage Employee Accounts";
            this.manageEmployeesToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeesToolStripMenuItem_Click);
            // 
            // pageApplications
            // 
            this.pageApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageApplications.Location = new System.Drawing.Point(0, 0);
            this.pageApplications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageApplications.Name = "pageApplications";
            this.pageApplications.Size = new System.Drawing.Size(984, 425);
            this.pageApplications.TabIndex = 0;
            // 
            // pageEmployees
            // 
            this.pageEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageEmployees.Location = new System.Drawing.Point(0, 0);
            this.pageEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageEmployees.Name = "pageEmployees";
            this.pageEmployees.Size = new System.Drawing.Size(984, 425);
            this.pageEmployees.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HappyTech Applicant Tracking System";
            this.panelBody.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.ToolStripMenuItem createNewTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private UserControlEmployees pageEmployees;
        private UserControlApplications pageApplications;
    }
}
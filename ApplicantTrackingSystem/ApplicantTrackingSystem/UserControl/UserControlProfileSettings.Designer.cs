namespace ApplicantTrackingSystem
{
    partial class UserControlProfileSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlProfileSettings));
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxWorkNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNewPasswordConfirmed = new System.Windows.Forms.TextBox();
            this.textBoxCurrentPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.textBoxMiddleNames = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelMiddleNames = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMobileNumber = new System.Windows.Forms.Label();
            this.labelWorkNumber = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.labelAdminRights = new System.Windows.Forms.Label();
            this.comboBoxAdminRights = new System.Windows.Forms.ComboBox();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.panelAdvancedSettings = new System.Windows.Forms.Panel();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelAdvancedSettings.SuspendLayout();
            this.panelChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(669, 52);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(258, 29);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(669, 120);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(258, 29);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(391, 188);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(258, 29);
            this.textBoxPhoneNumber.TabIndex = 4;
            // 
            // textBoxWorkNumber
            // 
            this.textBoxWorkNumber.Location = new System.Drawing.Point(669, 188);
            this.textBoxWorkNumber.Name = "textBoxWorkNumber";
            this.textBoxWorkNumber.Size = new System.Drawing.Size(258, 29);
            this.textBoxWorkNumber.TabIndex = 5;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Location = new System.Drawing.Point(391, 256);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(536, 29);
            this.textBoxEmailAddress.TabIndex = 6;
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.Location = new System.Drawing.Point(391, 314);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(258, 29);
            this.buttonDiscard.TabIndex = 7;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = true;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(669, 314);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(258, 29);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxNewPasswordConfirmed
            // 
            this.errorProvider.SetIconPadding(this.textBoxNewPasswordConfirmed, -20);
            this.textBoxNewPasswordConfirmed.Location = new System.Drawing.Point(31, 205);
            this.textBoxNewPasswordConfirmed.Name = "textBoxNewPasswordConfirmed";
            this.textBoxNewPasswordConfirmed.Size = new System.Drawing.Size(258, 29);
            this.textBoxNewPasswordConfirmed.TabIndex = 10;
            this.textBoxNewPasswordConfirmed.Text = "New Password Confirmed";
            this.textBoxNewPasswordConfirmed.Enter += new System.EventHandler(this.textBoxNewPasswordConfirmed_Enter);
            // 
            // textBoxCurrentPassword
            // 
            this.errorProvider.SetIconPadding(this.textBoxCurrentPassword, -20);
            this.textBoxCurrentPassword.Location = new System.Drawing.Point(31, 110);
            this.textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            this.textBoxCurrentPassword.Size = new System.Drawing.Size(258, 29);
            this.textBoxCurrentPassword.TabIndex = 11;
            this.textBoxCurrentPassword.Text = "Current Password";
            this.textBoxCurrentPassword.Enter += new System.EventHandler(this.textBoxCurrentPassword_Enter);
            // 
            // textBoxNewPassword
            // 
            this.errorProvider.SetIconPadding(this.textBoxNewPassword, -20);
            this.textBoxNewPassword.Location = new System.Drawing.Point(31, 169);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(258, 29);
            this.textBoxNewPassword.TabIndex = 9;
            this.textBoxNewPassword.Text = "New Password";
            this.textBoxNewPassword.Enter += new System.EventHandler(this.textBoxNewPassword_Enter);
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Location = new System.Drawing.Point(528, 52);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(121, 29);
            this.comboBoxTitle.TabIndex = 0;
            // 
            // textBoxMiddleNames
            // 
            this.textBoxMiddleNames.Location = new System.Drawing.Point(391, 120);
            this.textBoxMiddleNames.Name = "textBoxMiddleNames";
            this.textBoxMiddleNames.Size = new System.Drawing.Size(258, 29);
            this.textBoxMiddleNames.TabIndex = 2;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(524, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(42, 21);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Title";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(665, 28);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(95, 21);
            this.labelFirstName.TabIndex = 15;
            this.labelFirstName.Text = "First Name*";
            // 
            // labelMiddleNames
            // 
            this.labelMiddleNames.AutoSize = true;
            this.labelMiddleNames.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiddleNames.Location = new System.Drawing.Point(387, 96);
            this.labelMiddleNames.Name = "labelMiddleNames";
            this.labelMiddleNames.Size = new System.Drawing.Size(116, 21);
            this.labelMiddleNames.TabIndex = 16;
            this.labelMiddleNames.Text = "Middle Names";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(665, 96);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(93, 21);
            this.labelLastName.TabIndex = 17;
            this.labelLastName.Text = "Last Name*";
            // 
            // labelMobileNumber
            // 
            this.labelMobileNumber.AutoSize = true;
            this.labelMobileNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobileNumber.Location = new System.Drawing.Point(387, 164);
            this.labelMobileNumber.Name = "labelMobileNumber";
            this.labelMobileNumber.Size = new System.Drawing.Size(133, 21);
            this.labelMobileNumber.TabIndex = 18;
            this.labelMobileNumber.Text = "Mobile Number*";
            // 
            // labelWorkNumber
            // 
            this.labelWorkNumber.AutoSize = true;
            this.labelWorkNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkNumber.Location = new System.Drawing.Point(663, 164);
            this.labelWorkNumber.Name = "labelWorkNumber";
            this.labelWorkNumber.Size = new System.Drawing.Size(113, 21);
            this.labelWorkNumber.TabIndex = 19;
            this.labelWorkNumber.Text = "Work Number";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailAddress.Location = new System.Drawing.Point(387, 232);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(119, 21);
            this.labelEmailAddress.TabIndex = 20;
            this.labelEmailAddress.Text = "Email Address*";
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJobTitle.Location = new System.Drawing.Point(27, 45);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(79, 21);
            this.labelJobTitle.TabIndex = 18;
            this.labelJobTitle.Text = "Job Title*";
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(31, 69);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(258, 29);
            this.textBoxJobTitle.TabIndex = 17;
            // 
            // labelAdminRights
            // 
            this.labelAdminRights.AutoSize = true;
            this.labelAdminRights.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminRights.Location = new System.Drawing.Point(27, 113);
            this.labelAdminRights.Name = "labelAdminRights";
            this.labelAdminRights.Size = new System.Drawing.Size(161, 21);
            this.labelAdminRights.TabIndex = 15;
            this.labelAdminRights.Text = "Administrator Rights";
            // 
            // comboBoxAdminRights
            // 
            this.comboBoxAdminRights.FormattingEnabled = true;
            this.comboBoxAdminRights.Location = new System.Drawing.Point(31, 137);
            this.comboBoxAdminRights.Name = "comboBoxAdminRights";
            this.comboBoxAdminRights.Size = new System.Drawing.Size(258, 29);
            this.comboBoxAdminRights.TabIndex = 10;
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.Location = new System.Drawing.Point(31, 263);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(258, 29);
            this.buttonDeleteAccount.TabIndex = 9;
            this.buttonDeleteAccount.Text = "Delete Account";
            this.buttonDeleteAccount.UseVisualStyleBackColor = true;
            this.buttonDeleteAccount.Click += new System.EventHandler(this.buttonDeleteAccount_Click);
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.Location = new System.Drawing.Point(31, 204);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(258, 29);
            this.buttonResetPassword.TabIndex = 8;
            this.buttonResetPassword.Text = "Reset Password";
            this.buttonResetPassword.UseVisualStyleBackColor = true;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // panelAdvancedSettings
            // 
            this.panelAdvancedSettings.Controls.Add(this.labelJobTitle);
            this.panelAdvancedSettings.Controls.Add(this.buttonResetPassword);
            this.panelAdvancedSettings.Controls.Add(this.textBoxJobTitle);
            this.panelAdvancedSettings.Controls.Add(this.buttonDeleteAccount);
            this.panelAdvancedSettings.Controls.Add(this.comboBoxAdminRights);
            this.panelAdvancedSettings.Controls.Add(this.labelAdminRights);
            this.panelAdvancedSettings.Location = new System.Drawing.Point(45, 51);
            this.panelAdvancedSettings.Name = "panelAdvancedSettings";
            this.panelAdvancedSettings.Size = new System.Drawing.Size(316, 292);
            this.panelAdvancedSettings.TabIndex = 22;
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.Controls.Add(this.buttonChangePassword);
            this.panelChangePassword.Controls.Add(this.textBoxNewPasswordConfirmed);
            this.panelChangePassword.Controls.Add(this.textBoxNewPassword);
            this.panelChangePassword.Controls.Add(this.textBoxCurrentPassword);
            this.panelChangePassword.Location = new System.Drawing.Point(45, 51);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(316, 292);
            this.panelChangePassword.TabIndex = 23;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(31, 263);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(258, 29);
            this.buttonChangePassword.TabIndex = 12;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // UserControlProfileSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.labelWorkNumber);
            this.Controls.Add(this.labelMobileNumber);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleNames);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxMiddleNames);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDiscard);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.textBoxWorkNumber);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.panelAdvancedSettings);
            this.Controls.Add(this.panelChangePassword);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlProfileSettings";
            this.Size = new System.Drawing.Size(968, 384);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelAdvancedSettings.ResumeLayout(false);
            this.panelAdvancedSettings.PerformLayout();
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxWorkNumber;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxNewPasswordConfirmed;
        private System.Windows.Forms.TextBox textBoxCurrentPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.TextBox textBoxMiddleNames;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelWorkNumber;
        private System.Windows.Forms.Label labelMobileNumber;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMiddleNames;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.Label labelAdminRights;
        private System.Windows.Forms.ComboBox comboBoxAdminRights;
        private System.Windows.Forms.Button buttonDeleteAccount;
        private System.Windows.Forms.Button buttonResetPassword;
        private System.Windows.Forms.Panel panelChangePassword;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Panel panelAdvancedSettings;
    }
}

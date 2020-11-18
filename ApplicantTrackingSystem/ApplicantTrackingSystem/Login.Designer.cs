namespace ApplicantTrackingSystem
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.pictureBoxPasswordVisibility = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconPadding(this.textBoxPassword, -20);
            this.textBoxPassword.Location = new System.Drawing.Point(31, 215);
            this.textBoxPassword.MaxLength = 100;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(222, 30);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(87, 285);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(111, 30);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmail.FormattingEnabled = true;
            this.errorProvider.SetIconPadding(this.comboBoxEmail, -20);
            this.comboBoxEmail.Location = new System.Drawing.Point(31, 178);
            this.comboBoxEmail.MaxDropDownItems = 3;
            this.comboBoxEmail.MaxLength = 100;
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(222, 31);
            this.comboBoxEmail.TabIndex = 1;
            this.comboBoxEmail.Text = "Employee Email";
            this.comboBoxEmail.Enter += new System.EventHandler(this.comboBoxEmail_Enter);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(28, 245);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(113, 17);
            this.linkLabelForgotPassword.TabIndex = 3;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Forgot Password?";
            this.linkLabelForgotPassword.Click += new System.EventHandler(this.linkLabelForgotPassword_Click);
            // 
            // pictureBoxPasswordVisibility
            // 
            this.pictureBoxPasswordVisibility.Image = global::ApplicantTrackingSystem.Properties.Resources.showPassword;
            this.pictureBoxPasswordVisibility.Location = new System.Drawing.Point(231, 220);
            this.pictureBoxPasswordVisibility.Name = "pictureBoxPasswordVisibility";
            this.pictureBoxPasswordVisibility.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxPasswordVisibility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPasswordVisibility.TabIndex = 4;
            this.pictureBoxPasswordVisibility.TabStop = false;
            this.pictureBoxPasswordVisibility.Click += new System.EventHandler(this.pictureBoxPasswordVisibility_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ApplicantTrackingSystem.Properties.Resources.Logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(42, 45);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // Login
            // 
            this.AcceptButton = this.buttonLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.pictureBoxPasswordVisibility);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.linkLabelForgotPassword);
            this.Controls.Add(this.pictureBoxLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPasswordVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.PictureBox pictureBoxPasswordVisibility;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
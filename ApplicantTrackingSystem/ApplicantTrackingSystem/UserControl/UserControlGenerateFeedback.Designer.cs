namespace ApplicantTrackingSystem
{
    partial class UserControlGenerateFeedback2
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
            this.comboBoxTemplates = new System.Windows.Forms.ComboBox();
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.textBoxFooter = new System.Windows.Forms.TextBox();
            this.textBoxAddComments = new System.Windows.Forms.TextBox();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.buttonGenerateFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTemplates
            // 
            this.comboBoxTemplates.FormattingEnabled = true;
            this.comboBoxTemplates.ItemHeight = 16;
            this.comboBoxTemplates.Location = new System.Drawing.Point(41, 22);
            this.comboBoxTemplates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTemplates.Name = "comboBoxTemplates";
            this.comboBoxTemplates.Size = new System.Drawing.Size(320, 24);
            this.comboBoxTemplates.TabIndex = 1;
            this.comboBoxTemplates.Text = "Select Template";
            this.comboBoxTemplates.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplates_SelectedIndexChanged);
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxHeader.Location = new System.Drawing.Point(41, 59);
            this.textBoxHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHeader.Multiline = true;
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(320, 101);
            this.textBoxHeader.TabIndex = 6;
            // 
            // textBoxFooter
            // 
            this.textBoxFooter.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxFooter.Location = new System.Drawing.Point(41, 173);
            this.textBoxFooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFooter.Multiline = true;
            this.textBoxFooter.Name = "textBoxFooter";
            this.textBoxFooter.Size = new System.Drawing.Size(320, 101);
            this.textBoxFooter.TabIndex = 7;
            // 
            // textBoxAddComments
            // 
            this.textBoxAddComments.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxAddComments.Location = new System.Drawing.Point(458, 59);
            this.textBoxAddComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddComments.Multiline = true;
            this.textBoxAddComments.Name = "textBoxAddComments";
            this.textBoxAddComments.Size = new System.Drawing.Size(309, 159);
            this.textBoxAddComments.TabIndex = 9;
            this.textBoxAddComments.Text = "Additonal Comments";
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiscard.ForeColor = System.Drawing.Color.White;
            this.buttonDiscard.Location = new System.Drawing.Point(458, 241);
            this.buttonDiscard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(136, 33);
            this.buttonDiscard.TabIndex = 11;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = false;
            this.buttonDiscard.Click += new System.EventHandler(this.buttonDiscard_Click);
            // 
            // buttonGenerateFeedback
            // 
            this.buttonGenerateFeedback.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonGenerateFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateFeedback.ForeColor = System.Drawing.Color.White;
            this.buttonGenerateFeedback.Location = new System.Drawing.Point(600, 241);
            this.buttonGenerateFeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenerateFeedback.Name = "buttonGenerateFeedback";
            this.buttonGenerateFeedback.Size = new System.Drawing.Size(167, 33);
            this.buttonGenerateFeedback.TabIndex = 12;
            this.buttonGenerateFeedback.Text = "Generate Feedback";
            this.buttonGenerateFeedback.UseVisualStyleBackColor = false;
            this.buttonGenerateFeedback.Click += new System.EventHandler(this.buttonGenerateFeedback_Click);
            // 
            // UserControlGenerateFeedback2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGenerateFeedback);
            this.Controls.Add(this.buttonDiscard);
            this.Controls.Add(this.textBoxAddComments);
            this.Controls.Add(this.textBoxFooter);
            this.Controls.Add(this.textBoxHeader);
            this.Controls.Add(this.comboBoxTemplates);
            this.Name = "UserControlGenerateFeedback2";
            this.Size = new System.Drawing.Size(794, 309);
            this.Load += new System.EventHandler(this.UserControlGenerateFeedback2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTemplates;
        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.TextBox textBoxFooter;
        private System.Windows.Forms.TextBox textBoxAddComments;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.Button buttonGenerateFeedback;
    }
}

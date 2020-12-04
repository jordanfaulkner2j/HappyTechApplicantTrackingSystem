namespace ApplicantTrackingSystem
{
    partial class UserControlGenerateFeedback
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
            this.clbUnderstandingComments = new System.Windows.Forms.CheckedListBox();
            this.btnAddUnderstanding = new System.Windows.Forms.Button();
            this.panelUnderstanding = new System.Windows.Forms.Panel();
            this.panelComments = new System.Windows.Forms.Panel();
            this.panelQuestions = new System.Windows.Forms.Panel();
            this.clbQuestionsComments = new System.Windows.Forms.CheckedListBox();
            this.btnAddQuestions = new System.Windows.Forms.Button();
            this.panelImpression = new System.Windows.Forms.Panel();
            this.clbImpressionComments = new System.Windows.Forms.CheckedListBox();
            this.btnAddImpression = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUnderstanding.SuspendLayout();
            this.panelComments.SuspendLayout();
            this.panelQuestions.SuspendLayout();
            this.panelImpression.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTemplates
            // 
            this.comboBoxTemplates.FormattingEnabled = true;
            this.comboBoxTemplates.ItemHeight = 16;
            this.comboBoxTemplates.Location = new System.Drawing.Point(39, 27);
            this.comboBoxTemplates.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBoxTemplates.Name = "comboBoxTemplates";
            this.comboBoxTemplates.Size = new System.Drawing.Size(336, 24);
            this.comboBoxTemplates.TabIndex = 1;
            this.comboBoxTemplates.Text = "Select Template";
            this.comboBoxTemplates.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplates_SelectedIndexChanged);
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxHeader.Location = new System.Drawing.Point(39, 65);
            this.textBoxHeader.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxHeader.Multiline = true;
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(336, 86);
            this.textBoxHeader.TabIndex = 6;
            // 
            // textBoxFooter
            // 
            this.textBoxFooter.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxFooter.Location = new System.Drawing.Point(39, 171);
            this.textBoxFooter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxFooter.Multiline = true;
            this.textBoxFooter.Name = "textBoxFooter";
            this.textBoxFooter.Size = new System.Drawing.Size(336, 100);
            this.textBoxFooter.TabIndex = 7;
            // 
            // textBoxAddComments
            // 
            this.textBoxAddComments.Font = new System.Drawing.Font("Arial", 10F);
            this.textBoxAddComments.Location = new System.Drawing.Point(399, 178);
            this.textBoxAddComments.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxAddComments.Multiline = true;
            this.textBoxAddComments.Name = "textBoxAddComments";
            this.textBoxAddComments.Size = new System.Drawing.Size(403, 58);
            this.textBoxAddComments.TabIndex = 9;
            this.textBoxAddComments.Text = "Additional Comments";
            this.textBoxAddComments.Enter += new System.EventHandler(this.textBoxAddComments_Enter);
            this.textBoxAddComments.MouseLeave += new System.EventHandler(this.textBoxAddComments_MouseLeave);
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.BackColor = System.Drawing.Color.DarkRed;
            this.buttonDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiscard.ForeColor = System.Drawing.Color.White;
            this.buttonDiscard.Location = new System.Drawing.Point(399, 240);
            this.buttonDiscard.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.buttonGenerateFeedback.Location = new System.Drawing.Point(635, 240);
            this.buttonGenerateFeedback.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonGenerateFeedback.Name = "buttonGenerateFeedback";
            this.buttonGenerateFeedback.Size = new System.Drawing.Size(167, 33);
            this.buttonGenerateFeedback.TabIndex = 12;
            this.buttonGenerateFeedback.Text = "Generate Feedback";
            this.buttonGenerateFeedback.UseVisualStyleBackColor = false;
            this.buttonGenerateFeedback.Click += new System.EventHandler(this.buttonGenerateFeedback_Click);
            // 
            // clbUnderstandingComments
            // 
            this.clbUnderstandingComments.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clbUnderstandingComments.FormattingEnabled = true;
            this.clbUnderstandingComments.Location = new System.Drawing.Point(4, 9);
            this.clbUnderstandingComments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbUnderstandingComments.Name = "clbUnderstandingComments";
            this.clbUnderstandingComments.ScrollAlwaysVisible = true;
            this.clbUnderstandingComments.Size = new System.Drawing.Size(328, 72);
            this.clbUnderstandingComments.TabIndex = 2;
            // 
            // btnAddUnderstanding
            // 
            this.btnAddUnderstanding.Location = new System.Drawing.Point(340, 9);
            this.btnAddUnderstanding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddUnderstanding.Name = "btnAddUnderstanding";
            this.btnAddUnderstanding.Size = new System.Drawing.Size(37, 37);
            this.btnAddUnderstanding.TabIndex = 1;
            this.btnAddUnderstanding.Text = "+";
            this.btnAddUnderstanding.UseVisualStyleBackColor = true;
            this.btnAddUnderstanding.Click += new System.EventHandler(this.btnAddUnderstanding_Click);
            // 
            // panelUnderstanding
            // 
            this.panelUnderstanding.Controls.Add(this.clbUnderstandingComments);
            this.panelUnderstanding.Controls.Add(this.btnAddUnderstanding);
            this.panelUnderstanding.Location = new System.Drawing.Point(4, 20);
            this.panelUnderstanding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelUnderstanding.Name = "panelUnderstanding";
            this.panelUnderstanding.Size = new System.Drawing.Size(501, 107);
            this.panelUnderstanding.TabIndex = 0;
            // 
            // panelComments
            // 
            this.panelComments.AutoScroll = true;
            this.panelComments.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelComments.Controls.Add(this.panelQuestions);
            this.panelComments.Controls.Add(this.panelImpression);
            this.panelComments.Controls.Add(this.label1);
            this.panelComments.Controls.Add(this.panelUnderstanding);
            this.panelComments.Location = new System.Drawing.Point(399, 24);
            this.panelComments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelComments.Name = "panelComments";
            this.panelComments.Size = new System.Drawing.Size(403, 144);
            this.panelComments.TabIndex = 14;
            // 
            // panelQuestions
            // 
            this.panelQuestions.Controls.Add(this.clbQuestionsComments);
            this.panelQuestions.Controls.Add(this.btnAddQuestions);
            this.panelQuestions.Location = new System.Drawing.Point(4, 183);
            this.panelQuestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelQuestions.Name = "panelQuestions";
            this.panelQuestions.Size = new System.Drawing.Size(501, 103);
            this.panelQuestions.TabIndex = 15;
            // 
            // clbQuestionsComments
            // 
            this.clbQuestionsComments.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clbQuestionsComments.FormattingEnabled = true;
            this.clbQuestionsComments.Location = new System.Drawing.Point(4, 9);
            this.clbQuestionsComments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbQuestionsComments.Name = "clbQuestionsComments";
            this.clbQuestionsComments.ScrollAlwaysVisible = true;
            this.clbQuestionsComments.Size = new System.Drawing.Size(328, 72);
            this.clbQuestionsComments.TabIndex = 2;
            // 
            // btnAddQuestions
            // 
            this.btnAddQuestions.Location = new System.Drawing.Point(340, 9);
            this.btnAddQuestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddQuestions.Name = "btnAddQuestions";
            this.btnAddQuestions.Size = new System.Drawing.Size(37, 37);
            this.btnAddQuestions.TabIndex = 1;
            this.btnAddQuestions.Text = "+";
            this.btnAddQuestions.UseVisualStyleBackColor = true;
            this.btnAddQuestions.Click += new System.EventHandler(this.btnAddQuestions_Click);
            // 
            // panelImpression
            // 
            this.panelImpression.Controls.Add(this.clbImpressionComments);
            this.panelImpression.Controls.Add(this.btnAddImpression);
            this.panelImpression.Location = new System.Drawing.Point(4, 102);
            this.panelImpression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelImpression.Name = "panelImpression";
            this.panelImpression.Size = new System.Drawing.Size(501, 107);
            this.panelImpression.TabIndex = 3;
            // 
            // clbImpressionComments
            // 
            this.clbImpressionComments.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clbImpressionComments.FormattingEnabled = true;
            this.clbImpressionComments.Location = new System.Drawing.Point(4, 9);
            this.clbImpressionComments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbImpressionComments.Name = "clbImpressionComments";
            this.clbImpressionComments.ScrollAlwaysVisible = true;
            this.clbImpressionComments.Size = new System.Drawing.Size(328, 72);
            this.clbImpressionComments.TabIndex = 2;
            // 
            // btnAddImpression
            // 
            this.btnAddImpression.Location = new System.Drawing.Point(340, 9);
            this.btnAddImpression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddImpression.Name = "btnAddImpression";
            this.btnAddImpression.Size = new System.Drawing.Size(37, 37);
            this.btnAddImpression.TabIndex = 1;
            this.btnAddImpression.Text = "+";
            this.btnAddImpression.UseVisualStyleBackColor = true;
            this.btnAddImpression.Click += new System.EventHandler(this.btnAddImpression_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comments Used";
            // 
            // UserControlGenerateFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelComments);
            this.Controls.Add(this.buttonGenerateFeedback);
            this.Controls.Add(this.buttonDiscard);
            this.Controls.Add(this.textBoxAddComments);
            this.Controls.Add(this.textBoxFooter);
            this.Controls.Add(this.textBoxHeader);
            this.Controls.Add(this.comboBoxTemplates);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlGenerateFeedback";
            this.Size = new System.Drawing.Size(827, 293);
            this.Load += new System.EventHandler(this.UserControlGenerateFeedback_Load);
            this.panelUnderstanding.ResumeLayout(false);
            this.panelComments.ResumeLayout(false);
            this.panelComments.PerformLayout();
            this.panelQuestions.ResumeLayout(false);
            this.panelImpression.ResumeLayout(false);
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
        private System.Windows.Forms.CheckedListBox clbUnderstandingComments;
        private System.Windows.Forms.Button btnAddUnderstanding;
        private System.Windows.Forms.Panel panelUnderstanding;
        private System.Windows.Forms.Panel panelComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelQuestions;
        private System.Windows.Forms.CheckedListBox clbQuestionsComments;
        private System.Windows.Forms.Button btnAddQuestions;
        private System.Windows.Forms.Panel panelImpression;
        private System.Windows.Forms.CheckedListBox clbImpressionComments;
        private System.Windows.Forms.Button btnAddImpression;
    }
}

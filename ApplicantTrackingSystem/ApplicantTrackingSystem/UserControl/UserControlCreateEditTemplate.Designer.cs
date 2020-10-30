namespace ApplicantTrackingSystem
{
    partial class UserControlCreateTemplate
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
            this.labelToBeDeleted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelToBeDeleted
            // 
            this.labelToBeDeleted.AutoSize = true;
            this.labelToBeDeleted.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToBeDeleted.Location = new System.Drawing.Point(137, 190);
            this.labelToBeDeleted.Name = "labelToBeDeleted";
            this.labelToBeDeleted.Size = new System.Drawing.Size(711, 45);
            this.labelToBeDeleted.TabIndex = 0;
            this.labelToBeDeleted.Text = "Page with form for creating or editing template";
            // 
            // UserControlCreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelToBeDeleted);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlCreateTemplate";
            this.Size = new System.Drawing.Size(984, 425);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelToBeDeleted;
    }
}

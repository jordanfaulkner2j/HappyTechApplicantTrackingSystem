using System.Runtime.Remoting.Channels;
using ApplicantTrackingSystem.Properties;

namespace ApplicantTrackingSystem
{
    partial class UserControlFeedback
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Header = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(153, 78);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(327, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Select Template";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Header
            // 
            this.Header.Font = new System.Drawing.Font("Arial", 10F);
            this.Header.Location = new System.Drawing.Point(153, 119);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Multiline = true;
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(327, 83);
            this.Header.TabIndex = 5;
            this.Header.Text = "Header: Dear[ApplicantName], My name is [EmployeeName] and I am contacting you re" +
    "garding your application for [JobPostion] at our company HappyTech";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox1.Location = new System.Drawing.Point(153, 224);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 83);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Footer: Kind Regards,";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 13;
            this.comboBox2.Location = new System.Drawing.Point(541, 78);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(274, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 10F);
            this.textBox2.Location = new System.Drawing.Point(541, 119);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 130);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Additonal Comments";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Discard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 279);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 27);
            this.button2.TabIndex = 10;
            this.button2.Text = "Generate Feedback";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserControlFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlFeedback";
            this.Size = new System.Drawing.Size(968, 384);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

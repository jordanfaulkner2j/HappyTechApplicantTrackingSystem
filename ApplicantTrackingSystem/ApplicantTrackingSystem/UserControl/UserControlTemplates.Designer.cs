namespace ApplicantTrackingSystem
{
    partial class UserControlTemplates
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTemplates = new System.Windows.Forms.DataGridView();
            this.lblSelectTemplate = new System.Windows.Forms.Label();
            this.cmbSelectedTemplateTitle = new System.Windows.Forms.ComboBox();
            this.btnEditTemplate = new System.Windows.Forms.Button();
            this.btnDeleteTemplate = new System.Windows.Forms.Button();
            this.templateDataSet = new ApplicantTrackingSystem.TemplateDataSet();
            this.templateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.templateTableAdapter = new ApplicantTrackingSystem.TemplateDataSetTableAdapters.templateTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteTemplate);
            this.panel1.Controls.Add(this.btnEditTemplate);
            this.panel1.Controls.Add(this.cmbSelectedTemplateTitle);
            this.panel1.Controls.Add(this.lblSelectTemplate);
            this.panel1.Controls.Add(this.dgvTemplates);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 384);
            this.panel1.TabIndex = 7;
            // 
            // dgvTemplates
            // 
            this.dgvTemplates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTemplates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemplates.Location = new System.Drawing.Point(0, 0);
            this.dgvTemplates.Name = "dgvTemplates";
            this.dgvTemplates.Size = new System.Drawing.Size(965, 284);
            this.dgvTemplates.TabIndex = 0;
            // 
            // lblSelectTemplate
            // 
            this.lblSelectTemplate.AutoSize = true;
            this.lblSelectTemplate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectTemplate.Location = new System.Drawing.Point(33, 305);
            this.lblSelectTemplate.Name = "lblSelectTemplate";
            this.lblSelectTemplate.Size = new System.Drawing.Size(135, 16);
            this.lblSelectTemplate.TabIndex = 1;
            this.lblSelectTemplate.Text = "Select a Template:";
            // 
            // cmbSelectedTemplateTitle
            // 
            this.cmbSelectedTemplateTitle.DataSource = this.templateBindingSource;
            this.cmbSelectedTemplateTitle.DisplayMember = "title";
            this.cmbSelectedTemplateTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.cmbSelectedTemplateTitle.FormattingEnabled = true;
            this.cmbSelectedTemplateTitle.Location = new System.Drawing.Point(36, 333);
            this.cmbSelectedTemplateTitle.Name = "cmbSelectedTemplateTitle";
            this.cmbSelectedTemplateTitle.Size = new System.Drawing.Size(699, 24);
            this.cmbSelectedTemplateTitle.TabIndex = 2;
            this.cmbSelectedTemplateTitle.ValueMember = "title";
            // 
            // btnEditTemplate
            // 
            this.btnEditTemplate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditTemplate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTemplate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditTemplate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditTemplate.Location = new System.Drawing.Point(765, 333);
            this.btnEditTemplate.Name = "btnEditTemplate";
            this.btnEditTemplate.Size = new System.Drawing.Size(77, 29);
            this.btnEditTemplate.TabIndex = 3;
            this.btnEditTemplate.Text = "EDIT";
            this.btnEditTemplate.UseVisualStyleBackColor = false;
            this.btnEditTemplate.Click += new System.EventHandler(this.btnEditTemplate_Click);
            // 
            // btnDeleteTemplate
            // 
            this.btnDeleteTemplate.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteTemplate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTemplate.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTemplate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteTemplate.Location = new System.Drawing.Point(860, 333);
            this.btnDeleteTemplate.Name = "btnDeleteTemplate";
            this.btnDeleteTemplate.Size = new System.Drawing.Size(77, 29);
            this.btnDeleteTemplate.TabIndex = 4;
            this.btnDeleteTemplate.Text = "DELETE";
            this.btnDeleteTemplate.UseVisualStyleBackColor = false;
            this.btnDeleteTemplate.Click += new System.EventHandler(this.btnDeleteTemplate_Click);
            // 
            // templateDataSet
            // 
            this.templateDataSet.DataSetName = "TemplateDataSet";
            this.templateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // templateBindingSource
            // 
            this.templateBindingSource.DataMember = "template";
            this.templateBindingSource.DataSource = this.templateDataSet;
            // 
            // templateTableAdapter
            // 
            this.templateTableAdapter.ClearBeforeFill = true;
            // 
            // UserControlTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlTemplates";
            this.Size = new System.Drawing.Size(968, 384);
            this.Load += new System.EventHandler(this.UserControlTemplates_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteTemplate;
        private System.Windows.Forms.Button btnEditTemplate;
        private System.Windows.Forms.ComboBox cmbSelectedTemplateTitle;
        private System.Windows.Forms.Label lblSelectTemplate;
        private System.Windows.Forms.DataGridView dgvTemplates;
        private System.Windows.Forms.BindingSource templateBindingSource;
        private TemplateDataSet templateDataSet;
        private TemplateDataSetTableAdapters.templateTableAdapter templateTableAdapter;
    }
}

namespace ApplicantTrackingSystem
{
    partial class CodeManagement
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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.dgvSection = new System.Windows.Forms.DataGridView();
            this.sectionidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new ApplicantTrackingSystem.DatabaseDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteCode = new System.Windows.Forms.Button();
            this.btnAddCode = new System.Windows.Forms.Button();
            this.lblAddCode = new System.Windows.Forms.Label();
            this.dgvComment = new System.Windows.Forms.DataGridView();
            this.commentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseCommentDataSet = new ApplicantTrackingSystem.DatabaseCommentDataSet();
            this.tbxComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.lblEnterCode = new System.Windows.Forms.Label();
            this.tbxSectionID = new System.Windows.Forms.TextBox();
            this.lblEnterSectionID = new System.Windows.Forms.Label();
            this.commentTableAdapter = new ApplicantTrackingSystem.DatabaseCommentDataSetTableAdapters.commentTableAdapter();
            this.sectionTableAdapter = new ApplicantTrackingSystem.DatabaseDataSetTableAdapters.sectionTableAdapter();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCommentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBackground.Controls.Add(this.dgvSection);
            this.pnlBackground.Controls.Add(this.panel2);
            this.pnlBackground.Location = new System.Drawing.Point(1, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(800, 452);
            this.pnlBackground.TabIndex = 0;
            // 
            // dgvSection
            // 
            this.dgvSection.AutoGenerateColumns = false;
            this.dgvSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sectionidDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn});
            this.dgvSection.DataSource = this.sectionBindingSource;
            this.dgvSection.Location = new System.Drawing.Point(9, 309);
            this.dgvSection.Name = "dgvSection";
            this.dgvSection.Size = new System.Drawing.Size(776, 127);
            this.dgvSection.TabIndex = 0;
            // 
            // sectionidDataGridViewTextBoxColumn1
            // 
            this.sectionidDataGridViewTextBoxColumn1.DataPropertyName = "section_id";
            this.sectionidDataGridViewTextBoxColumn1.HeaderText = "section_id";
            this.sectionidDataGridViewTextBoxColumn1.Name = "sectionidDataGridViewTextBoxColumn1";
            this.sectionidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "section";
            this.sectionBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteCode);
            this.panel2.Controls.Add(this.btnAddCode);
            this.panel2.Controls.Add(this.lblAddCode);
            this.panel2.Controls.Add(this.dgvComment);
            this.panel2.Controls.Add(this.tbxComment);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbxCode);
            this.panel2.Controls.Add(this.lblEnterCode);
            this.panel2.Controls.Add(this.tbxSectionID);
            this.panel2.Controls.Add(this.lblEnterSectionID);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 260);
            this.panel2.TabIndex = 1;
            // 
            // btnDeleteCode
            // 
            this.btnDeleteCode.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteCode.Location = new System.Drawing.Point(722, 56);
            this.btnDeleteCode.Name = "btnDeleteCode";
            this.btnDeleteCode.Size = new System.Drawing.Size(44, 28);
            this.btnDeleteCode.TabIndex = 8;
            this.btnDeleteCode.Text = "-";
            this.btnDeleteCode.UseVisualStyleBackColor = false;
            this.btnDeleteCode.Click += new System.EventHandler(this.btnDeleteCode_Click);
            // 
            // btnAddCode
            // 
            this.btnAddCode.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCode.Location = new System.Drawing.Point(672, 56);
            this.btnAddCode.Name = "btnAddCode";
            this.btnAddCode.Size = new System.Drawing.Size(44, 28);
            this.btnAddCode.TabIndex = 7;
            this.btnAddCode.Text = "+";
            this.btnAddCode.UseVisualStyleBackColor = false;
            this.btnAddCode.Click += new System.EventHandler(this.btnAddCode_Click);
            // 
            // lblAddCode
            // 
            this.lblAddCode.AutoSize = true;
            this.lblAddCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddCode.Location = new System.Drawing.Point(18, 13);
            this.lblAddCode.Name = "lblAddCode";
            this.lblAddCode.Size = new System.Drawing.Size(157, 16);
            this.lblAddCode.TabIndex = 6;
            this.lblAddCode.Text = "Add or Remove Code";
            // 
            // dgvComment
            // 
            this.dgvComment.AutoGenerateColumns = false;
            this.dgvComment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvComment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentidDataGridViewTextBoxColumn,
            this.sectionidDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgvComment.DataSource = this.commentBindingSource;
            this.dgvComment.Location = new System.Drawing.Point(0, 93);
            this.dgvComment.Name = "dgvComment";
            this.dgvComment.Size = new System.Drawing.Size(776, 167);
            this.dgvComment.TabIndex = 0;
            // 
            // commentidDataGridViewTextBoxColumn
            // 
            this.commentidDataGridViewTextBoxColumn.DataPropertyName = "comment_id";
            this.commentidDataGridViewTextBoxColumn.HeaderText = "comment_id";
            this.commentidDataGridViewTextBoxColumn.Name = "commentidDataGridViewTextBoxColumn";
            this.commentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionidDataGridViewTextBoxColumn
            // 
            this.sectionidDataGridViewTextBoxColumn.DataPropertyName = "section_id";
            this.sectionidDataGridViewTextBoxColumn.HeaderText = "section_id";
            this.sectionidDataGridViewTextBoxColumn.Name = "sectionidDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.DataMember = "comment";
            this.commentBindingSource.DataSource = this.databaseCommentDataSet;
            // 
            // databaseCommentDataSet
            // 
            this.databaseCommentDataSet.DataSetName = "DatabaseCommentDataSet";
            this.databaseCommentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbxComment
            // 
            this.tbxComment.Font = new System.Drawing.Font("Arial", 8F);
            this.tbxComment.Location = new System.Drawing.Point(283, 60);
            this.tbxComment.Name = "tbxComment";
            this.tbxComment.Size = new System.Drawing.Size(369, 20);
            this.tbxComment.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.Location = new System.Drawing.Point(280, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Comment:";
            // 
            // tbxCode
            // 
            this.tbxCode.Font = new System.Drawing.Font("Arial", 8F);
            this.tbxCode.Location = new System.Drawing.Point(166, 60);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(60, 20);
            this.tbxCode.TabIndex = 3;
            // 
            // lblEnterCode
            // 
            this.lblEnterCode.AutoSize = true;
            this.lblEnterCode.Font = new System.Drawing.Font("Arial", 9F);
            this.lblEnterCode.Location = new System.Drawing.Point(163, 43);
            this.lblEnterCode.Name = "lblEnterCode";
            this.lblEnterCode.Size = new System.Drawing.Size(72, 15);
            this.lblEnterCode.TabIndex = 2;
            this.lblEnterCode.Text = "Enter Code:";
            // 
            // tbxSectionID
            // 
            this.tbxSectionID.Font = new System.Drawing.Font("Arial", 8F);
            this.tbxSectionID.Location = new System.Drawing.Point(18, 60);
            this.tbxSectionID.Name = "tbxSectionID";
            this.tbxSectionID.Size = new System.Drawing.Size(85, 20);
            this.tbxSectionID.TabIndex = 1;
            // 
            // lblEnterSectionID
            // 
            this.lblEnterSectionID.AutoSize = true;
            this.lblEnterSectionID.Font = new System.Drawing.Font("Arial", 9F);
            this.lblEnterSectionID.Location = new System.Drawing.Point(15, 43);
            this.lblEnterSectionID.Name = "lblEnterSectionID";
            this.lblEnterSectionID.Size = new System.Drawing.Size(98, 15);
            this.lblEnterSectionID.TabIndex = 0;
            this.lblEnterSectionID.Text = "Enter Section ID:";
            // 
            // commentTableAdapter
            // 
            this.commentTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // CodeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBackground);
            this.Name = "CodeManagement";
            this.Text = "Code Management";
            this.Load += new System.EventHandler(this.AddCode_Load);
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseCommentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.Label lblEnterCode;
        private System.Windows.Forms.TextBox tbxSectionID;
        private System.Windows.Forms.Label lblEnterSectionID;
        private System.Windows.Forms.DataGridView dgvComment;
        private DatabaseCommentDataSet databaseCommentDataSet;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private DatabaseCommentDataSetTableAdapters.commentTableAdapter commentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvSection;
        private System.Windows.Forms.TextBox tbxComment;
        private System.Windows.Forms.Label label1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private DatabaseDataSetTableAdapters.sectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddCode;
        private System.Windows.Forms.Label lblAddCode;
        private System.Windows.Forms.Button btnDeleteCode;
    }
}
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
            this.lblListOfComments = new System.Windows.Forms.Label();
            this.dgvListOfComments = new System.Windows.Forms.DataGridView();
            this.commentidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.templateidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listofcommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listOfCommentsDataSet = new ApplicantTrackingSystem.ListOfCommentsDataSet();
            this.lblSections = new System.Windows.Forms.Label();
            this.dgvSection = new System.Windows.Forms.DataGridView();
            this.sectionidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new ApplicantTrackingSystem.DatabaseDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSectionTitle = new System.Windows.Forms.ComboBox();
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
            this.lblSelectSection = new System.Windows.Forms.Label();
            this.commentTableAdapter = new ApplicantTrackingSystem.DatabaseCommentDataSetTableAdapters.commentTableAdapter();
            this.sectionTableAdapter = new ApplicantTrackingSystem.DatabaseDataSetTableAdapters.sectionTableAdapter();
            this.list_of_commentsTableAdapter = new ApplicantTrackingSystem.ListOfCommentsDataSetTableAdapters.list_of_commentsTableAdapter();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listofcommentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCommentsDataSet)).BeginInit();
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
            this.pnlBackground.AutoScroll = true;
            this.pnlBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBackground.Controls.Add(this.lblListOfComments);
            this.pnlBackground.Controls.Add(this.dgvListOfComments);
            this.pnlBackground.Controls.Add(this.lblSections);
            this.pnlBackground.Controls.Add(this.dgvSection);
            this.pnlBackground.Controls.Add(this.panel2);
            this.pnlBackground.Location = new System.Drawing.Point(1, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(814, 499);
            this.pnlBackground.TabIndex = 0;
            // 
            // lblListOfComments
            // 
            this.lblListOfComments.AutoSize = true;
            this.lblListOfComments.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblListOfComments.Location = new System.Drawing.Point(27, 451);
            this.lblListOfComments.Name = "lblListOfComments";
            this.lblListOfComments.Size = new System.Drawing.Size(129, 16);
            this.lblListOfComments.TabIndex = 12;
            this.lblListOfComments.Text = "List of Comments";
            // 
            // dgvListOfComments
            // 
            this.dgvListOfComments.AutoGenerateColumns = false;
            this.dgvListOfComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListOfComments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListOfComments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListOfComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentidDataGridViewTextBoxColumn1,
            this.templateidDataGridViewTextBoxColumn});
            this.dgvListOfComments.DataSource = this.listofcommentsBindingSource;
            this.dgvListOfComments.Location = new System.Drawing.Point(9, 480);
            this.dgvListOfComments.Name = "dgvListOfComments";
            this.dgvListOfComments.Size = new System.Drawing.Size(776, 116);
            this.dgvListOfComments.TabIndex = 11;
            // 
            // commentidDataGridViewTextBoxColumn1
            // 
            this.commentidDataGridViewTextBoxColumn1.DataPropertyName = "comment_id";
            this.commentidDataGridViewTextBoxColumn1.HeaderText = "comment_id";
            this.commentidDataGridViewTextBoxColumn1.Name = "commentidDataGridViewTextBoxColumn1";
            // 
            // templateidDataGridViewTextBoxColumn
            // 
            this.templateidDataGridViewTextBoxColumn.DataPropertyName = "template_id";
            this.templateidDataGridViewTextBoxColumn.HeaderText = "template_id";
            this.templateidDataGridViewTextBoxColumn.Name = "templateidDataGridViewTextBoxColumn";
            // 
            // listofcommentsBindingSource
            // 
            this.listofcommentsBindingSource.DataMember = "list_of_comments";
            this.listofcommentsBindingSource.DataSource = this.listOfCommentsDataSet;
            // 
            // listOfCommentsDataSet
            // 
            this.listOfCommentsDataSet.DataSetName = "ListOfCommentsDataSet";
            this.listOfCommentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSections
            // 
            this.lblSections.AutoSize = true;
            this.lblSections.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblSections.Location = new System.Drawing.Point(27, 282);
            this.lblSections.Name = "lblSections";
            this.lblSections.Size = new System.Drawing.Size(69, 16);
            this.lblSections.TabIndex = 10;
            this.lblSections.Text = "Sections";
            // 
            // dgvSection
            // 
            this.dgvSection.AutoGenerateColumns = false;
            this.dgvSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sectionidDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn});
            this.dgvSection.DataSource = this.sectionBindingSource;
            this.dgvSection.Location = new System.Drawing.Point(9, 309);
            this.dgvSection.Name = "dgvSection";
            this.dgvSection.RowHeadersWidth = 82;
            this.dgvSection.Size = new System.Drawing.Size(776, 127);
            this.dgvSection.TabIndex = 0;
            // 
            // sectionidDataGridViewTextBoxColumn1
            // 
            this.sectionidDataGridViewTextBoxColumn1.DataPropertyName = "section_id";
            this.sectionidDataGridViewTextBoxColumn1.HeaderText = "section_id";
            this.sectionidDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.sectionidDataGridViewTextBoxColumn1.Name = "sectionidDataGridViewTextBoxColumn1";
            this.sectionidDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 10;
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
            this.panel2.Controls.Add(this.cmbSectionTitle);
            this.panel2.Controls.Add(this.btnDeleteCode);
            this.panel2.Controls.Add(this.btnAddCode);
            this.panel2.Controls.Add(this.lblAddCode);
            this.panel2.Controls.Add(this.dgvComment);
            this.panel2.Controls.Add(this.tbxComment);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbxCode);
            this.panel2.Controls.Add(this.lblEnterCode);
            this.panel2.Controls.Add(this.lblSelectSection);
            this.panel2.Location = new System.Drawing.Point(9, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 260);
            this.panel2.TabIndex = 1;
            // 
            // cmbSectionTitle
            // 
            this.cmbSectionTitle.DataSource = this.sectionBindingSource;
            this.cmbSectionTitle.DisplayMember = "title";
            this.cmbSectionTitle.Font = new System.Drawing.Font("Arial", 8F);
            this.cmbSectionTitle.FormattingEnabled = true;
            this.cmbSectionTitle.Location = new System.Drawing.Point(18, 60);
            this.cmbSectionTitle.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSectionTitle.Name = "cmbSectionTitle";
            this.cmbSectionTitle.Size = new System.Drawing.Size(157, 22);
            this.cmbSectionTitle.TabIndex = 9;
            this.cmbSectionTitle.ValueMember = "title";
            // 
            // btnDeleteCode
            // 
            this.btnDeleteCode.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCode.Font = new System.Drawing.Font("Wingdings 2", 14F, System.Drawing.FontStyle.Bold);
            this.btnDeleteCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteCode.Location = new System.Drawing.Point(722, 56);
            this.btnDeleteCode.Name = "btnDeleteCode";
            this.btnDeleteCode.Size = new System.Drawing.Size(44, 28);
            this.btnDeleteCode.TabIndex = 8;
            this.btnDeleteCode.Text = "V";
            this.btnDeleteCode.UseVisualStyleBackColor = false;
            this.btnDeleteCode.Click += new System.EventHandler(this.btnDeleteCode_Click);
            // 
            // btnAddCode
            // 
            this.btnAddCode.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCode.Font = new System.Drawing.Font("Wingdings", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCode.Location = new System.Drawing.Point(672, 56);
            this.btnAddCode.Name = "btnAddCode";
            this.btnAddCode.Size = new System.Drawing.Size(44, 28);
            this.btnAddCode.TabIndex = 7;
            this.btnAddCode.Text = "<";
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
            this.dgvComment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dgvComment.RowHeadersWidth = 82;
            this.dgvComment.Size = new System.Drawing.Size(776, 167);
            this.dgvComment.TabIndex = 0;
            // 
            // commentidDataGridViewTextBoxColumn
            // 
            this.commentidDataGridViewTextBoxColumn.DataPropertyName = "comment_id";
            this.commentidDataGridViewTextBoxColumn.HeaderText = "comment_id";
            this.commentidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.commentidDataGridViewTextBoxColumn.Name = "commentidDataGridViewTextBoxColumn";
            this.commentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionidDataGridViewTextBoxColumn
            // 
            this.sectionidDataGridViewTextBoxColumn.DataPropertyName = "section_id";
            this.sectionidDataGridViewTextBoxColumn.HeaderText = "section_id";
            this.sectionidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.sectionidDataGridViewTextBoxColumn.Name = "sectionidDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 10;
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
            this.tbxCode.Location = new System.Drawing.Point(199, 60);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(60, 20);
            this.tbxCode.TabIndex = 3;
            // 
            // lblEnterCode
            // 
            this.lblEnterCode.AutoSize = true;
            this.lblEnterCode.Font = new System.Drawing.Font("Arial", 9F);
            this.lblEnterCode.Location = new System.Drawing.Point(196, 43);
            this.lblEnterCode.Name = "lblEnterCode";
            this.lblEnterCode.Size = new System.Drawing.Size(72, 15);
            this.lblEnterCode.TabIndex = 2;
            this.lblEnterCode.Text = "Enter Code:";
            // 
            // lblSelectSection
            // 
            this.lblSelectSection.AutoSize = true;
            this.lblSelectSection.Font = new System.Drawing.Font("Arial", 9F);
            this.lblSelectSection.Location = new System.Drawing.Point(15, 43);
            this.lblSelectSection.Name = "lblSelectSection";
            this.lblSelectSection.Size = new System.Drawing.Size(88, 15);
            this.lblSelectSection.TabIndex = 0;
            this.lblSelectSection.Text = "Select Section:";
            // 
            // commentTableAdapter
            // 
            this.commentTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // list_of_commentsTableAdapter
            // 
            this.list_of_commentsTableAdapter.ClearBeforeFill = true;
            // 
            // CodeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 497);
            this.Controls.Add(this.pnlBackground);
            this.Name = "CodeManagement";
            this.Text = "Code Management";
            this.Load += new System.EventHandler(this.AddCode_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listofcommentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfCommentsDataSet)).EndInit();
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
        private System.Windows.Forms.Label lblSelectSection;
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
        private System.Windows.Forms.ComboBox cmbSectionTitle;
        private System.Windows.Forms.Label lblListOfComments;
        private System.Windows.Forms.DataGridView dgvListOfComments;
        private System.Windows.Forms.Label lblSections;
        private ListOfCommentsDataSet listOfCommentsDataSet;
        private System.Windows.Forms.BindingSource listofcommentsBindingSource;
        private ListOfCommentsDataSetTableAdapters.list_of_commentsTableAdapter list_of_commentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn templateidDataGridViewTextBoxColumn;
    }
}
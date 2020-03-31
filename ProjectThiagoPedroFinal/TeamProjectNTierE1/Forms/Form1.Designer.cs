namespace Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtvStudentInfo = new System.Windows.Forms.DataGridView();
            this.lstSearchResult = new System.Windows.Forms.CheckedListBox();
            this.txtStudentSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtStudentSearchId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgStudentLoanInfo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtReourceIdSearch = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearResource = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResourceRetrieve = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnConfirmSelection = new System.Windows.Forms.Button();
            this.lstItemsToLoan = new System.Windows.Forms.ListBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.dtgResourceInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvStudentInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentLoanInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResourceInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvStudentInfo
            // 
            this.dtvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvStudentInfo.Location = new System.Drawing.Point(158, 21);
            this.dtvStudentInfo.Name = "dtvStudentInfo";
            this.dtvStudentInfo.RowTemplate.Height = 24;
            this.dtvStudentInfo.Size = new System.Drawing.Size(404, 208);
            this.dtvStudentInfo.TabIndex = 7;
            // 
            // lstSearchResult
            // 
            this.lstSearchResult.FormattingEnabled = true;
            this.lstSearchResult.Location = new System.Drawing.Point(6, 21);
            this.lstSearchResult.Name = "lstSearchResult";
            this.lstSearchResult.Size = new System.Drawing.Size(146, 208);
            this.lstSearchResult.TabIndex = 6;
            this.lstSearchResult.SelectedIndexChanged += new System.EventHandler(this.lstSearchResult_SelectedIndexChanged);
            // 
            // txtStudentSearchName
            // 
            this.txtStudentSearchName.Location = new System.Drawing.Point(130, 61);
            this.txtStudentSearchName.Name = "txtStudentSearchName";
            this.txtStudentSearchName.Size = new System.Drawing.Size(183, 22);
            this.txtStudentSearchName.TabIndex = 5;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(531, 60);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 4;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtStudentSearchId
            // 
            this.txtStudentSearchId.Location = new System.Drawing.Point(332, 61);
            this.txtStudentSearchId.Name = "txtStudentSearchId";
            this.txtStudentSearchId.Size = new System.Drawing.Size(183, 22);
            this.txtStudentSearchId.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearStudent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 83);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Student by Id or Name";
            // 
            // btnClearStudent
            // 
            this.btnClearStudent.Location = new System.Drawing.Point(553, 37);
            this.btnClearStudent.Name = "btnClearStudent";
            this.btnClearStudent.Size = new System.Drawing.Size(75, 23);
            this.btnClearStudent.TabIndex = 2;
            this.btnClearStudent.Text = "Clear";
            this.btnClearStudent.UseVisualStyleBackColor = true;
            this.btnClearStudent.Click += new System.EventHandler(this.btnClearStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dtgStudentLoanInfo
            // 
            this.dtgStudentLoanInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentLoanInfo.Location = new System.Drawing.Point(568, 21);
            this.dtgStudentLoanInfo.Name = "dtgStudentLoanInfo";
            this.dtgStudentLoanInfo.RowTemplate.Height = 24;
            this.dtgStudentLoanInfo.Size = new System.Drawing.Size(404, 208);
            this.dtgStudentLoanInfo.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstSearchResult);
            this.groupBox2.Controls.Add(this.dtgStudentLoanInfo);
            this.groupBox2.Controls.Add(this.dtvStudentInfo);
            this.groupBox2.Location = new System.Drawing.Point(59, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 242);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "StudentInformation";
            // 
            // txtReourceIdSearch
            // 
            this.txtReourceIdSearch.Location = new System.Drawing.Point(130, 398);
            this.txtReourceIdSearch.Name = "txtReourceIdSearch";
            this.txtReourceIdSearch.Size = new System.Drawing.Size(293, 22);
            this.txtReourceIdSearch.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClearResource);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(59, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 83);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Resource Id";
            // 
            // btnClearResource
            // 
            this.btnClearResource.Location = new System.Drawing.Point(553, 37);
            this.btnClearResource.Name = "btnClearResource";
            this.btnClearResource.Size = new System.Drawing.Size(75, 23);
            this.btnClearResource.TabIndex = 3;
            this.btnClearResource.Text = "Clear";
            this.btnClearResource.UseVisualStyleBackColor = true;
            this.btnClearResource.Click += new System.EventHandler(this.btnClearResource_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // btnResourceRetrieve
            // 
            this.btnResourceRetrieve.Location = new System.Drawing.Point(531, 397);
            this.btnResourceRetrieve.Name = "btnResourceRetrieve";
            this.btnResourceRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnResourceRetrieve.TabIndex = 10;
            this.btnResourceRetrieve.Text = "Search";
            this.btnResourceRetrieve.UseVisualStyleBackColor = true;
            this.btnResourceRetrieve.Click += new System.EventHandler(this.btnResourceRetrieve_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnConfirmSelection);
            this.groupBox4.Controls.Add(this.lstItemsToLoan);
            this.groupBox4.Controls.Add(this.btnAddToList);
            this.groupBox4.Controls.Add(this.dtgResourceInfo);
            this.groupBox4.Location = new System.Drawing.Point(65, 471);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(966, 261);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resource Information";
            // 
            // btnConfirmSelection
            // 
            this.btnConfirmSelection.Location = new System.Drawing.Point(798, 216);
            this.btnConfirmSelection.Name = "btnConfirmSelection";
            this.btnConfirmSelection.Size = new System.Drawing.Size(80, 23);
            this.btnConfirmSelection.TabIndex = 15;
            this.btnConfirmSelection.Text = "Confirm";
            this.btnConfirmSelection.UseVisualStyleBackColor = true;
            this.btnConfirmSelection.Click += new System.EventHandler(this.btnConfirmSelection_Click);
            // 
            // lstItemsToLoan
            // 
            this.lstItemsToLoan.FormattingEnabled = true;
            this.lstItemsToLoan.ItemHeight = 16;
            this.lstItemsToLoan.Location = new System.Drawing.Point(455, 46);
            this.lstItemsToLoan.Name = "lstItemsToLoan";
            this.lstItemsToLoan.Size = new System.Drawing.Size(452, 164);
            this.lstItemsToLoan.TabIndex = 14;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(516, 216);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(86, 23);
            this.btnAddToList.TabIndex = 14;
            this.btnAddToList.Text = "Add";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // dtgResourceInfo
            // 
            this.dtgResourceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResourceInfo.Location = new System.Drawing.Point(23, 46);
            this.dtgResourceInfo.Name = "dtgResourceInfo";
            this.dtgResourceInfo.RowTemplate.Height = 24;
            this.dtgResourceInfo.Size = new System.Drawing.Size(396, 164);
            this.dtgResourceInfo.TabIndex = 14;
            this.dtgResourceInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgResourceInfo_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 774);
            this.Controls.Add(this.txtReourceIdSearch);
            this.Controls.Add(this.btnResourceRetrieve);
            this.Controls.Add(this.txtStudentSearchId);
            this.Controls.Add(this.txtStudentSearchName);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Automotive";
            ((System.ComponentModel.ISupportInitialize)(this.dtvStudentInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentLoanInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgResourceInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvStudentInfo;
        private System.Windows.Forms.CheckedListBox lstSearchResult;
        private System.Windows.Forms.TextBox txtStudentSearchName;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtStudentSearchId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgStudentLoanInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReourceIdSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResourceRetrieve;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnConfirmSelection;
        private System.Windows.Forms.ListBox lstItemsToLoan;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.DataGridView dtgResourceInfo;
        private System.Windows.Forms.Button btnClearStudent;
        private System.Windows.Forms.Button btnClearResource;
    }
}


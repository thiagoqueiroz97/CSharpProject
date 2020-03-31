namespace Forms
{
    partial class Form3
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
            this.btnResouceSearch = new System.Windows.Forms.Button();
            this.txtResourceID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvResourceInfo = new System.Windows.Forms.DataGridView();
            this.txtStudentSearchId = new System.Windows.Forms.TextBox();
            this.txtStudentSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSearchResult = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
            this.btnReserve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResourceInfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResouceSearch
            // 
            this.btnResouceSearch.Location = new System.Drawing.Point(462, 36);
            this.btnResouceSearch.Name = "btnResouceSearch";
            this.btnResouceSearch.Size = new System.Drawing.Size(75, 23);
            this.btnResouceSearch.TabIndex = 1;
            this.btnResouceSearch.Text = "search";
            this.btnResouceSearch.UseVisualStyleBackColor = true;
            this.btnResouceSearch.Click += new System.EventHandler(this.btnResouceSearch_Click);
            // 
            // txtResourceID
            // 
            this.txtResourceID.Location = new System.Drawing.Point(132, 37);
            this.txtResourceID.Name = "txtResourceID";
            this.txtResourceID.Size = new System.Drawing.Size(284, 22);
            this.txtResourceID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResouceSearch);
            this.groupBox1.Controls.Add(this.txtResourceID);
            this.groupBox1.Location = new System.Drawing.Point(92, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search resource by ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvResourceInfo);
            this.groupBox2.Location = new System.Drawing.Point(92, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 246);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resource Information";
            // 
            // dgvResourceInfo
            // 
            this.dgvResourceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResourceInfo.Location = new System.Drawing.Point(31, 45);
            this.dgvResourceInfo.Name = "dgvResourceInfo";
            this.dgvResourceInfo.RowTemplate.Height = 24;
            this.dgvResourceInfo.Size = new System.Drawing.Size(542, 161);
            this.dgvResourceInfo.TabIndex = 0;
            // 
            // txtStudentSearchId
            // 
            this.txtStudentSearchId.Location = new System.Drawing.Point(337, 409);
            this.txtStudentSearchId.Name = "txtStudentSearchId";
            this.txtStudentSearchId.Size = new System.Drawing.Size(183, 22);
            this.txtStudentSearchId.TabIndex = 12;
            // 
            // txtStudentSearchName
            // 
            this.txtStudentSearchName.Location = new System.Drawing.Point(135, 409);
            this.txtStudentSearchName.Name = "txtStudentSearchName";
            this.txtStudentSearchName.Size = new System.Drawing.Size(183, 22);
            this.txtStudentSearchName.TabIndex = 11;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(536, 408);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 10;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(64, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 83);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Student by Id or Name";
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
            // lstSearchResult
            // 
            this.lstSearchResult.FormattingEnabled = true;
            this.lstSearchResult.Location = new System.Drawing.Point(16, 35);
            this.lstSearchResult.Name = "lstSearchResult";
            this.lstSearchResult.Size = new System.Drawing.Size(146, 208);
            this.lstSearchResult.TabIndex = 14;
            this.lstSearchResult.SelectedIndexChanged += new System.EventHandler(this.lstSearchResult_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReserve);
            this.groupBox4.Controls.Add(this.dgvStudentInfo);
            this.groupBox4.Controls.Add(this.lstSearchResult);
            this.groupBox4.Location = new System.Drawing.Point(64, 461);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(648, 306);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Information";
            // 
            // dgvStudentInfo
            // 
            this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfo.Location = new System.Drawing.Point(171, 35);
            this.dgvStudentInfo.Name = "dgvStudentInfo";
            this.dgvStudentInfo.RowTemplate.Height = 24;
            this.dgvStudentInfo.Size = new System.Drawing.Size(457, 208);
            this.dgvStudentInfo.TabIndex = 15;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(285, 262);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(75, 23);
            this.btnReserve.TabIndex = 16;
            this.btnReserve.Text = "Confirm";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 808);
            this.Controls.Add(this.txtStudentSearchId);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtStudentSearchName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResourceInfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResouceSearch;
        private System.Windows.Forms.TextBox txtResourceID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvResourceInfo;
        private System.Windows.Forms.TextBox txtStudentSearchId;
        private System.Windows.Forms.TextBox txtStudentSearchName;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lstSearchResult;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.DataGridView dgvStudentInfo;
    }
}
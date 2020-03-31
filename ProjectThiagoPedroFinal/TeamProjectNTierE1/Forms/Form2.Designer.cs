namespace Forms
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResouceSearch = new System.Windows.Forms.Button();
            this.txtResourceID = new System.Windows.Forms.TextBox();
            this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
            this.dgvLoanInfo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnConfirmReturn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResouceSearch);
            this.groupBox1.Controls.Add(this.txtResourceID);
            this.groupBox1.Location = new System.Drawing.Point(41, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search resource by ID";
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
            // dgvStudentInfo
            // 
            this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfo.Location = new System.Drawing.Point(50, 149);
            this.dgvStudentInfo.Name = "dgvStudentInfo";
            this.dgvStudentInfo.RowTemplate.Height = 24;
            this.dgvStudentInfo.Size = new System.Drawing.Size(329, 84);
            this.dgvStudentInfo.TabIndex = 1;
            // 
            // dgvLoanInfo
            // 
            this.dgvLoanInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanInfo.Location = new System.Drawing.Point(462, 23);
            this.dgvLoanInfo.Name = "dgvLoanInfo";
            this.dgvLoanInfo.RowTemplate.Height = 24;
            this.dgvLoanInfo.Size = new System.Drawing.Size(339, 151);
            this.dgvLoanInfo.TabIndex = 2;
            this.dgvLoanInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoanInfo_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.dgvLoanInfo);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.btnConfirmReturn);
            this.groupBox2.Location = new System.Drawing.Point(41, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 316);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student and Loan information";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(698, 180);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Missing";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(481, 180);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Damaged";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnConfirmReturn
            // 
            this.btnConfirmReturn.Location = new System.Drawing.Point(386, 274);
            this.btnConfirmReturn.Name = "btnConfirmReturn";
            this.btnConfirmReturn.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmReturn.TabIndex = 0;
            this.btnConfirmReturn.Text = "Confirm";
            this.btnConfirmReturn.UseVisualStyleBackColor = true;
            this.btnConfirmReturn.Click += new System.EventHandler(this.btnConfirmReturn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(9, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 164);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items to return";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 483);
            this.Controls.Add(this.dgvStudentInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResouceSearch;
        private System.Windows.Forms.TextBox txtResourceID;
        private System.Windows.Forms.DataGridView dgvStudentInfo;
        private System.Windows.Forms.DataGridView dgvLoanInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConfirmReturn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
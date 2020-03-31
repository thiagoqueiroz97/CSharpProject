namespace Forms
{
    partial class Form4
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
            this.txtStudentSearchId = new System.Windows.Forms.TextBox();
            this.txtStudentSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
            this.lstSearchResult = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAmmountToPay = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStudentSearchId
            // 
            this.txtStudentSearchId.Location = new System.Drawing.Point(351, 60);
            this.txtStudentSearchId.Name = "txtStudentSearchId";
            this.txtStudentSearchId.Size = new System.Drawing.Size(183, 22);
            this.txtStudentSearchId.TabIndex = 16;
            // 
            // txtStudentSearchName
            // 
            this.txtStudentSearchName.Location = new System.Drawing.Point(149, 60);
            this.txtStudentSearchName.Name = "txtStudentSearchName";
            this.txtStudentSearchName.Size = new System.Drawing.Size(183, 22);
            this.txtStudentSearchName.TabIndex = 15;
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(550, 59);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudent.TabIndex = 14;
            this.btnSearchStudent.Text = "Search";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(78, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 83);
            this.groupBox3.TabIndex = 17;
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
            // dgvStudentInfo
            // 
            this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfo.Location = new System.Drawing.Point(171, 35);
            this.dgvStudentInfo.Name = "dgvStudentInfo";
            this.dgvStudentInfo.RowTemplate.Height = 24;
            this.dgvStudentInfo.Size = new System.Drawing.Size(457, 208);
            this.dgvStudentInfo.TabIndex = 15;
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
            this.groupBox4.Controls.Add(this.dgvStudentInfo);
            this.groupBox4.Controls.Add(this.lstSearchResult);
            this.groupBox4.Location = new System.Drawing.Point(78, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(648, 306);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Information";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(421, 42);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 16;
            this.btnPay.Text = "Confirm";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPay);
            this.groupBox1.Controls.Add(this.txtAmmountToPay);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(78, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 85);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtAmmountToPay
            // 
            this.txtAmmountToPay.Location = new System.Drawing.Point(99, 43);
            this.txtAmmountToPay.Name = "txtAmmountToPay";
            this.txtAmmountToPay.Size = new System.Drawing.Size(289, 22);
            this.txtAmmountToPay.TabIndex = 17;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtStudentSearchId);
            this.Controls.Add(this.txtStudentSearchName);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form4";
            this.Text = "Form4";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentSearchId;
        private System.Windows.Forms.TextBox txtStudentSearchName;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudentInfo;
        private System.Windows.Forms.CheckedListBox lstSearchResult;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmmountToPay;
        private System.Windows.Forms.Button button1;
    }
}
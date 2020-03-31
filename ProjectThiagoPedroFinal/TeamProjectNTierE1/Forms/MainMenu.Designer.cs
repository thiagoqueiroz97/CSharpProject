namespace Forms
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resourceToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resourceToolStripMenuItem
            // 
            this.resourceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkOutToolStripMenuItem,
            this.checkInToolStripMenuItem,
            this.reserveToolStripMenuItem});
            this.resourceToolStripMenuItem.Name = "resourceToolStripMenuItem";
            this.resourceToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.resourceToolStripMenuItem.Text = "Resource";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.checkOutToolStripMenuItem.Text = "Check out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.checkInToolStripMenuItem.Text = "Check in";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // reserveToolStripMenuItem
            // 
            this.reserveToolStripMenuItem.Name = "reserveToolStripMenuItem";
            this.reserveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.reserveToolStripMenuItem.Text = "Reserve";
            this.reserveToolStripMenuItem.Click += new System.EventHandler(this.reserveToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makePaymentToolStripMenuItem,
            this.createStudentToolStripMenuItem,
            this.manageStudentToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // makePaymentToolStripMenuItem
            // 
            this.makePaymentToolStripMenuItem.Name = "makePaymentToolStripMenuItem";
            this.makePaymentToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.makePaymentToolStripMenuItem.Text = "Make Payment";
            this.makePaymentToolStripMenuItem.Click += new System.EventHandler(this.makePaymentToolStripMenuItem_Click);
            // 
            // createStudentToolStripMenuItem
            // 
            this.createStudentToolStripMenuItem.Name = "createStudentToolStripMenuItem";
            this.createStudentToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.createStudentToolStripMenuItem.Text = "Create student";
            this.createStudentToolStripMenuItem.Click += new System.EventHandler(this.createStudentToolStripMenuItem_Click);
            // 
            // manageStudentToolStripMenuItem
            // 
            this.manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            this.manageStudentToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.manageStudentToolStripMenuItem.Text = "Manage Student";
            this.manageStudentToolStripMenuItem.Click += new System.EventHandler(this.manageStudentToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentToolStripMenuItem;
    }
}
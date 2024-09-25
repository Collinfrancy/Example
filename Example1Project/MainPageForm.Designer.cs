namespace Example1Project
{
    partial class MainPageForm
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSumCalcu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSquareCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContact = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContactList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewContact = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.mnuSalary,
            this.mnuContact});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(770, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSumCalcu,
            this.toolStripSeparator2,
            this.mnuSquareCalc});
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.calculatorToolStripMenuItem.Text = "&Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // mnuSumCalcu
            // 
            this.mnuSumCalcu.Name = "mnuSumCalcu";
            this.mnuSumCalcu.Size = new System.Drawing.Size(224, 26);
            this.mnuSumCalcu.Text = "&Sum Calculator";
            this.mnuSumCalcu.Click += new System.EventHandler(this.mnuSumCalcu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuSquareCalc
            // 
            this.mnuSquareCalc.Name = "mnuSquareCalc";
            this.mnuSquareCalc.Size = new System.Drawing.Size(224, 26);
            this.mnuSquareCalc.Text = "S&quare Calculator";
            this.mnuSquareCalc.Click += new System.EventHandler(this.mnuSquareCalc_Click);
            // 
            // mnuSalary
            // 
            this.mnuSalary.Name = "mnuSalary";
            this.mnuSalary.Size = new System.Drawing.Size(63, 24);
            this.mnuSalary.Text = "&Salary";
            this.mnuSalary.Click += new System.EventHandler(this.mnuSalary_Click);
            // 
            // mnuContact
            // 
            this.mnuContact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContactList,
            this.mnuNewContact});
            this.mnuContact.Name = "mnuContact";
            this.mnuContact.Size = new System.Drawing.Size(74, 24);
            this.mnuContact.Text = "C&ontact";
            this.mnuContact.Click += new System.EventHandler(this.mnuContact_Click);
            // 
            // mnuContactList
            // 
            this.mnuContactList.Name = "mnuContactList";
            this.mnuContactList.Size = new System.Drawing.Size(224, 26);
            this.mnuContactList.Text = "&Contact List";
            this.mnuContactList.Click += new System.EventHandler(this.mnuContactList_Click);
            // 
            // mnuNewContact
            // 
            this.mnuNewContact.Name = "mnuNewContact";
            this.mnuNewContact.Size = new System.Drawing.Size(224, 26);
            this.mnuNewContact.Text = "&New Contact";
            this.mnuNewContact.Click += new System.EventHandler(this.mnuNewContact_Click);
            // 
            // MainPageForm
            // 
            this.ClientSize = new System.Drawing.Size(770, 484);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MainPageForm";
            this.Text = "example 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCalc;
        private System.Windows.Forms.ToolStripMenuItem mnuSumCalc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem squareCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newContactToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSumCalcu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuSquareCalc;
        private System.Windows.Forms.ToolStripMenuItem mnuSalary;
        private System.Windows.Forms.ToolStripMenuItem mnuContact;
        private System.Windows.Forms.ToolStripMenuItem mnuContactList;
        private System.Windows.Forms.ToolStripMenuItem mnuNewContact;
    }
}


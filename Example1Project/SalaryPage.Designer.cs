namespace Example1Project
{
    partial class SalaryPage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTitleNewSalary = new System.Windows.Forms.Label();
            this.lblTitleEditSalary = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEditJobTitle = new System.Windows.Forms.Label();
            this.lblEditSalary = new System.Windows.Forms.Label();
            this.txtEditJobTitle = new System.Windows.Forms.TextBox();
            this.txtEditSalary = new System.Windows.Forms.TextBox();
            this.grdSalaries = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaries)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 90);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Salary";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(40, 104);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 46);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTitleNewSalary
            // 
            this.lblTitleNewSalary.BackColor = System.Drawing.Color.Silver;
            this.lblTitleNewSalary.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleNewSalary.Location = new System.Drawing.Point(37, 174);
            this.lblTitleNewSalary.Name = "lblTitleNewSalary";
            this.lblTitleNewSalary.Size = new System.Drawing.Size(329, 32);
            this.lblTitleNewSalary.TabIndex = 7;
            this.lblTitleNewSalary.Text = "New Salary";
            this.lblTitleNewSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleEditSalary
            // 
            this.lblTitleEditSalary.BackColor = System.Drawing.Color.Silver;
            this.lblTitleEditSalary.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleEditSalary.Location = new System.Drawing.Point(389, 174);
            this.lblTitleEditSalary.Name = "lblTitleEditSalary";
            this.lblTitleEditSalary.Size = new System.Drawing.Size(329, 32);
            this.lblTitleEditSalary.TabIndex = 7;
            this.lblTitleEditSalary.Text = "Edit Salary";
            this.lblTitleEditSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(57, 260);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(59, 16);
            this.lblJobTitle.TabIndex = 8;
            this.lblJobTitle.Text = "Job Title";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(57, 310);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(46, 16);
            this.lblSalary.TabIndex = 8;
            this.lblSalary.Text = "Salary";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(148, 254);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(218, 22);
            this.txtJobTitle.TabIndex = 9;
            this.txtJobTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(148, 310);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(218, 22);
            this.txtSalary.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(148, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 32);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(60, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(392, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEditJobTitle
            // 
            this.lblEditJobTitle.AutoSize = true;
            this.lblEditJobTitle.Location = new System.Drawing.Point(389, 254);
            this.lblEditJobTitle.Name = "lblEditJobTitle";
            this.lblEditJobTitle.Size = new System.Drawing.Size(59, 16);
            this.lblEditJobTitle.TabIndex = 8;
            this.lblEditJobTitle.Text = "Job Title";
            // 
            // lblEditSalary
            // 
            this.lblEditSalary.AutoSize = true;
            this.lblEditSalary.Location = new System.Drawing.Point(389, 304);
            this.lblEditSalary.Name = "lblEditSalary";
            this.lblEditSalary.Size = new System.Drawing.Size(46, 16);
            this.lblEditSalary.TabIndex = 8;
            this.lblEditSalary.Text = "Salary";
            // 
            // txtEditJobTitle
            // 
            this.txtEditJobTitle.Location = new System.Drawing.Point(480, 248);
            this.txtEditJobTitle.Name = "txtEditJobTitle";
            this.txtEditJobTitle.Size = new System.Drawing.Size(218, 22);
            this.txtEditJobTitle.TabIndex = 9;
            this.txtEditJobTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEditSalary
            // 
            this.txtEditSalary.Location = new System.Drawing.Point(480, 304);
            this.txtEditSalary.Name = "txtEditSalary";
            this.txtEditSalary.Size = new System.Drawing.Size(218, 22);
            this.txtEditSalary.TabIndex = 9;
            // 
            // grdSalaries
            // 
            this.grdSalaries.AllowUserToAddRows = false;
            this.grdSalaries.AllowUserToDeleteRows = false;
            this.grdSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalaries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdSalaries.Location = new System.Drawing.Point(60, 418);
            this.grdSalaries.MultiSelect = false;
            this.grdSalaries.Name = "grdSalaries";
            this.grdSalaries.ReadOnly = true;
            this.grdSalaries.RowHeadersWidth = 51;
            this.grdSalaries.RowTemplate.Height = 24;
            this.grdSalaries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSalaries.Size = new System.Drawing.Size(344, 275);
            this.grdSalaries.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(60, 700);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 32);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(182, 700);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "Title";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Salary";
            this.Column2.HeaderText = "Salary";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Display";
            this.Column3.HeaderText = "Display";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // SalaryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 744);
            this.Controls.Add(this.grdSalaries);
            this.Controls.Add(this.txtEditSalary);
            this.Controls.Add(this.txtEditJobTitle);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblEditSalary);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.lblEditJobTitle);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblJobTitle);
            this.Controls.Add(this.lblTitleEditSalary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitleNewSalary);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblTitle);
            this.Name = "SalaryPage";
            this.Text = "SalaryPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalaryPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTitleNewSalary;
        private System.Windows.Forms.Label lblTitleEditSalary;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEditJobTitle;
        private System.Windows.Forms.Label lblEditSalary;
        private System.Windows.Forms.TextBox txtEditJobTitle;
        private System.Windows.Forms.TextBox txtEditSalary;
        private System.Windows.Forms.DataGridView grdSalaries;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
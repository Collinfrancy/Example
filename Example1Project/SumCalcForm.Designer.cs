namespace Example1Project
{
    partial class SumCalcForm
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
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnFindSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Viner Hand ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 83);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sum Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(93, 166);
            this.lblNumber1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(71, 23);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.Text = "Number 1";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(212, 166);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(227, 32);
            this.txtNumber1.TabIndex = 2;
            this.txtNumber1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(93, 222);
            this.lblNumber2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(71, 23);
            this.lblNumber2.TabIndex = 1;
            this.lblNumber2.Text = "Number 2";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(212, 222);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(227, 32);
            this.txtNumber2.TabIndex = 2;
            this.txtNumber2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(93, 293);
            this.lblSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(39, 23);
            this.lblSum.TabIndex = 1;
            this.lblSum.Text = "SUM";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(212, 293);
            this.txtSum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(227, 32);
            this.txtSum.TabIndex = 2;
            this.txtSum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnFindSum
            // 
            this.btnFindSum.Location = new System.Drawing.Point(332, 354);
            this.btnFindSum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnFindSum.Name = "btnFindSum";
            this.btnFindSum.Size = new System.Drawing.Size(105, 56);
            this.btnFindSum.TabIndex = 3;
            this.btnFindSum.Text = "Find Sum";
            this.btnFindSum.UseVisualStyleBackColor = true;
            this.btnFindSum.Click += new System.EventHandler(this.btnFindSum_Click);
            // 
            // SumCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.btnFindSum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "SumCalcForm";
            this.Text = "SumCalcForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnFindSum;
    }
}
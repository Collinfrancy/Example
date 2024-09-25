namespace Example1Project
{
    partial class SquareCalcForm
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
            this.btnFindSquare = new System.Windows.Forms.Button();
            this.txtSquare = new System.Windows.Forms.TextBox();
            this.lblSquare = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFindSquare
            // 
            this.btnFindSquare.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSquare.Location = new System.Drawing.Point(498, 387);
            this.btnFindSquare.Name = "btnFindSquare";
            this.btnFindSquare.Size = new System.Drawing.Size(157, 61);
            this.btnFindSquare.TabIndex = 11;
            this.btnFindSquare.Text = "Find Square";
            this.btnFindSquare.UseVisualStyleBackColor = true;
            this.btnFindSquare.Click += new System.EventHandler(this.btnFindSquare_Click);
            // 
            // txtSquare
            // 
            this.txtSquare.Location = new System.Drawing.Point(318, 250);
            this.txtSquare.Name = "txtSquare";
            this.txtSquare.ReadOnly = true;
            this.txtSquare.Size = new System.Drawing.Size(338, 22);
            this.txtSquare.TabIndex = 8;
            // 
            // lblSquare
            // 
            this.lblSquare.AutoSize = true;
            this.lblSquare.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquare.Location = new System.Drawing.Point(140, 250);
            this.lblSquare.Name = "lblSquare";
            this.lblSquare.Size = new System.Drawing.Size(65, 27);
            this.lblSquare.TabIndex = 5;
            this.lblSquare.Text = "Square";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(318, 182);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(338, 22);
            this.txtNumber.TabIndex = 10;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(140, 182);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(80, 27);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.Text = "Number ";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Viner Hand ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 90);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Square Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SquareCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFindSquare);
            this.Controls.Add(this.txtSquare);
            this.Controls.Add(this.lblSquare);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblTitle);
            this.Name = "SquareCalcForm";
            this.Text = "Square Calc";
            this.Load += new System.EventHandler(this.SquareCalcForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindSquare;
        private System.Windows.Forms.TextBox txtSquare;
        private System.Windows.Forms.Label lblSquare;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblTitle;
    }
}
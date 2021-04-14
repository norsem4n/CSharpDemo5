namespace CKarnasProgram5
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
            this.lblSqFoot = new System.Windows.Forms.Label();
            this.lblPaintCst = new System.Windows.Forms.Label();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.nudSqFtPaint = new System.Windows.Forms.NumericUpDown();
            this.nudPaintCost = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSqFtPaint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaintCost)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSqFoot
            // 
            this.lblSqFoot.AutoSize = true;
            this.lblSqFoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqFoot.Location = new System.Drawing.Point(59, 115);
            this.lblSqFoot.Name = "lblSqFoot";
            this.lblSqFoot.Size = new System.Drawing.Size(266, 24);
            this.lblSqFoot.TabIndex = 0;
            this.lblSqFoot.Text = "Square Footage to be Painted:";
            // 
            // lblPaintCst
            // 
            this.lblPaintCst.AutoSize = true;
            this.lblPaintCst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintCst.Location = new System.Drawing.Point(148, 168);
            this.lblPaintCst.Name = "lblPaintCst";
            this.lblPaintCst.Size = new System.Drawing.Size(177, 24);
            this.lblPaintCst.TabIndex = 1;
            this.lblPaintCst.Text = "Gallon of Paint Cost:";
            // 
            // btnEstimate
            // 
            this.btnEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimate.Location = new System.Drawing.Point(349, 221);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(160, 43);
            this.btnEstimate.TabIndex = 2;
            this.btnEstimate.Text = "Estimate Job";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReset.Location = new System.Drawing.Point(349, 293);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 34);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(641, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(234, 46);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(358, 25);
            this.lblMain.TabIndex = 8;
            this.lblMain.Text = "Estimate Calculator for Paint Job";
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Location = new System.Drawing.Point(12, 428);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(98, 13);
            this.lblDeveloper.TabIndex = 9;
            this.lblDeveloper.Text = "Developed by CGK";
            // 
            // nudSqFtPaint
            // 
            this.nudSqFtPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSqFtPaint.Location = new System.Drawing.Point(349, 115);
            this.nudSqFtPaint.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSqFtPaint.Name = "nudSqFtPaint";
            this.nudSqFtPaint.Size = new System.Drawing.Size(160, 29);
            this.nudSqFtPaint.TabIndex = 10;
            this.nudSqFtPaint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudPaintCost
            // 
            this.nudPaintCost.DecimalPlaces = 2;
            this.nudPaintCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPaintCost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPaintCost.Location = new System.Drawing.Point(349, 168);
            this.nudPaintCost.Name = "nudPaintCost";
            this.nudPaintCost.Size = new System.Drawing.Size(160, 29);
            this.nudPaintCost.TabIndex = 11;
            this.nudPaintCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudPaintCost.ThousandsSeparator = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudPaintCost);
            this.Controls.Add(this.nudSqFtPaint);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.lblPaintCst);
            this.Controls.Add(this.lblSqFoot);
            this.Name = "Form1";
            this.Text = "Assignment 3 - Paint Job";
            ((System.ComponentModel.ISupportInitialize)(this.nudSqFtPaint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaintCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSqFoot;
        private System.Windows.Forms.Label lblPaintCst;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.NumericUpDown nudSqFtPaint;
        private System.Windows.Forms.NumericUpDown nudPaintCost;
    }
}


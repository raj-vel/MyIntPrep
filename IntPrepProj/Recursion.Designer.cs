namespace IntPrepProj
{
    partial class Recursion
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
            this.PhoneNumberAlphabets_Permutation = new System.Windows.Forms.Button();
            this.PascalsTriangeRecursive = new System.Windows.Forms.Button();
            this.PredictHorseMove = new System.Windows.Forms.Button();
            this.FibonocciTillN = new System.Windows.Forms.Button();
            this.NthFibbonaciNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PhoneNumberAlphabets_Permutation
            // 
            this.PhoneNumberAlphabets_Permutation.Location = new System.Drawing.Point(46, 38);
            this.PhoneNumberAlphabets_Permutation.Name = "PhoneNumberAlphabets_Permutation";
            this.PhoneNumberAlphabets_Permutation.Size = new System.Drawing.Size(151, 35);
            this.PhoneNumberAlphabets_Permutation.TabIndex = 0;
            this.PhoneNumberAlphabets_Permutation.Text = "Phone Combinations";
            this.PhoneNumberAlphabets_Permutation.UseVisualStyleBackColor = true;
            this.PhoneNumberAlphabets_Permutation.Click += new System.EventHandler(this.PhoneNumberAlphabets_Permutation_Click);
            // 
            // PascalsTriangeRecursive
            // 
            this.PascalsTriangeRecursive.Location = new System.Drawing.Point(266, 38);
            this.PascalsTriangeRecursive.Name = "PascalsTriangeRecursive";
            this.PascalsTriangeRecursive.Size = new System.Drawing.Size(194, 35);
            this.PascalsTriangeRecursive.TabIndex = 1;
            this.PascalsTriangeRecursive.Text = "Pascal\'s Triange Recursive";
            this.PascalsTriangeRecursive.UseVisualStyleBackColor = true;
            this.PascalsTriangeRecursive.Click += new System.EventHandler(this.PascalsTriangeRecursive_Click);
            // 
            // PredictHorseMove
            // 
            this.PredictHorseMove.Location = new System.Drawing.Point(518, 38);
            this.PredictHorseMove.Name = "PredictHorseMove";
            this.PredictHorseMove.Size = new System.Drawing.Size(191, 35);
            this.PredictHorseMove.TabIndex = 2;
            this.PredictHorseMove.Text = "Predict Horse Move";
            this.PredictHorseMove.UseVisualStyleBackColor = true;
            this.PredictHorseMove.Click += new System.EventHandler(this.PredictHorseMove_Click);
            // 
            // FibonocciTillN
            // 
            this.FibonocciTillN.Location = new System.Drawing.Point(767, 38);
            this.FibonocciTillN.Name = "FibonocciTillN";
            this.FibonocciTillN.Size = new System.Drawing.Size(189, 35);
            this.FibonocciTillN.TabIndex = 3;
            this.FibonocciTillN.Text = "Fibbonaci Series till N";
            this.FibonocciTillN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.FibonocciTillN.UseVisualStyleBackColor = true;
            this.FibonocciTillN.Click += new System.EventHandler(this.FibonocciTillN_Click);
            // 
            // NthFibbonaciNumber
            // 
            this.NthFibbonaciNumber.Location = new System.Drawing.Point(1003, 39);
            this.NthFibbonaciNumber.Name = "NthFibbonaciNumber";
            this.NthFibbonaciNumber.Size = new System.Drawing.Size(205, 34);
            this.NthFibbonaciNumber.TabIndex = 4;
            this.NthFibbonaciNumber.Text = "Nth Fibbonaci Number";
            this.NthFibbonaciNumber.UseVisualStyleBackColor = true;
            this.NthFibbonaciNumber.Click += new System.EventHandler(this.NthFibbonaciNumber_Click);
            // 
            // Recursion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1804, 795);
            this.Controls.Add(this.NthFibbonaciNumber);
            this.Controls.Add(this.FibonocciTillN);
            this.Controls.Add(this.PredictHorseMove);
            this.Controls.Add(this.PascalsTriangeRecursive);
            this.Controls.Add(this.PhoneNumberAlphabets_Permutation);
            this.Name = "Recursion";
            this.Text = "Recursion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PhoneNumberAlphabets_Permutation;
        private System.Windows.Forms.Button PascalsTriangeRecursive;
        private System.Windows.Forms.Button PredictHorseMove;
        private System.Windows.Forms.Button FibonocciTillN;
        private System.Windows.Forms.Button NthFibbonaciNumber;
    }
}
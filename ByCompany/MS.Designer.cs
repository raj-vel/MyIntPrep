namespace ByCompany
{
    partial class MS
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
            this.CarNumberAndPenalty = new System.Windows.Forms.Button();
            this.SumOfTwoNumbersInArrayEqualExpected = new System.Windows.Forms.Button();
            this.BinaryNumberDivisibleBy3 = new System.Windows.Forms.Button();
            this.NumberToWords = new System.Windows.Forms.Button();
            this.PrintNumberToWordsUS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarNumberAndPenalty
            // 
            this.CarNumberAndPenalty.Location = new System.Drawing.Point(45, 30);
            this.CarNumberAndPenalty.Name = "CarNumberAndPenalty";
            this.CarNumberAndPenalty.Size = new System.Drawing.Size(158, 48);
            this.CarNumberAndPenalty.TabIndex = 0;
            this.CarNumberAndPenalty.Text = "CarNumber and Penalty";
            this.CarNumberAndPenalty.UseVisualStyleBackColor = true;
            this.CarNumberAndPenalty.Click += new System.EventHandler(this.CarNumberAndPenalty_Click);
            // 
            // SumOfTwoNumbersInArrayEqualExpected
            // 
            this.SumOfTwoNumbersInArrayEqualExpected.Location = new System.Drawing.Point(264, 30);
            this.SumOfTwoNumbersInArrayEqualExpected.Name = "SumOfTwoNumbersInArrayEqualExpected";
            this.SumOfTwoNumbersInArrayEqualExpected.Size = new System.Drawing.Size(199, 48);
            this.SumOfTwoNumbersInArrayEqualExpected.TabIndex = 1;
            this.SumOfTwoNumbersInArrayEqualExpected.Text = "Sum of two numbers Equals Expected";
            this.SumOfTwoNumbersInArrayEqualExpected.UseVisualStyleBackColor = true;
            this.SumOfTwoNumbersInArrayEqualExpected.Click += new System.EventHandler(this.SumOfTwoNumbersInArrayEqualExpected_Click);
            // 
            // BinaryNumberDivisibleBy3
            // 
            this.BinaryNumberDivisibleBy3.Location = new System.Drawing.Point(506, 30);
            this.BinaryNumberDivisibleBy3.Name = "BinaryNumberDivisibleBy3";
            this.BinaryNumberDivisibleBy3.Size = new System.Drawing.Size(241, 47);
            this.BinaryNumberDivisibleBy3.TabIndex = 2;
            this.BinaryNumberDivisibleBy3.Text = "Binary Number Divisible by 3";
            this.BinaryNumberDivisibleBy3.UseVisualStyleBackColor = true;
            this.BinaryNumberDivisibleBy3.Click += new System.EventHandler(this.BinaryNumberDivisibleBy3_Click);
            // 
            // NumberToWords
            // 
            this.NumberToWords.Location = new System.Drawing.Point(793, 30);
            this.NumberToWords.Name = "NumberToWords";
            this.NumberToWords.Size = new System.Drawing.Size(222, 47);
            this.NumberToWords.TabIndex = 3;
            this.NumberToWords.Text = "Print Number To Words";
            this.NumberToWords.UseVisualStyleBackColor = true;
            this.NumberToWords.Click += new System.EventHandler(this.NumberToWords_Click);
            // 
            // PrintNumberToWordsUS
            // 
            this.PrintNumberToWordsUS.Location = new System.Drawing.Point(1064, 30);
            this.PrintNumberToWordsUS.Name = "PrintNumberToWordsUS";
            this.PrintNumberToWordsUS.Size = new System.Drawing.Size(169, 47);
            this.PrintNumberToWordsUS.TabIndex = 4;
            this.PrintNumberToWordsUS.Text = "Print Number to Words - US";
            this.PrintNumberToWordsUS.UseVisualStyleBackColor = true;
            this.PrintNumberToWordsUS.Click += new System.EventHandler(this.PrintNumberToWordsUS_Click);
            // 
            // MS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 497);
            this.Controls.Add(this.PrintNumberToWordsUS);
            this.Controls.Add(this.NumberToWords);
            this.Controls.Add(this.BinaryNumberDivisibleBy3);
            this.Controls.Add(this.SumOfTwoNumbersInArrayEqualExpected);
            this.Controls.Add(this.CarNumberAndPenalty);
            this.Name = "MS";
            this.Text = "MS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CarNumberAndPenalty;
        private System.Windows.Forms.Button SumOfTwoNumbersInArrayEqualExpected;
        private System.Windows.Forms.Button BinaryNumberDivisibleBy3;
        private System.Windows.Forms.Button NumberToWords;
        private System.Windows.Forms.Button PrintNumberToWordsUS;
    }
}
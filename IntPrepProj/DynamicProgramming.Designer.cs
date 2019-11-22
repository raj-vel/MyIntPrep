namespace IntPrepProj
{
    partial class DynamicProgramming
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
            this.PossibleWaysToDecodeADigit = new System.Windows.Forms.Button();
            this.UniquePathsFromStartToEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PossibleWaysToDecodeADigit
            // 
            this.PossibleWaysToDecodeADigit.Location = new System.Drawing.Point(46, 40);
            this.PossibleWaysToDecodeADigit.Name = "PossibleWaysToDecodeADigit";
            this.PossibleWaysToDecodeADigit.Size = new System.Drawing.Size(235, 42);
            this.PossibleWaysToDecodeADigit.TabIndex = 0;
            this.PossibleWaysToDecodeADigit.Text = "Count Possible Decoding Of given Digits";
            this.PossibleWaysToDecodeADigit.UseVisualStyleBackColor = true;
            this.PossibleWaysToDecodeADigit.Click += new System.EventHandler(this.PossibleWaysToDecodeADigit_Click);
            // 
            // UniquePathsFromStartToEnd
            // 
            this.UniquePathsFromStartToEnd.Location = new System.Drawing.Point(323, 40);
            this.UniquePathsFromStartToEnd.Name = "UniquePathsFromStartToEnd";
            this.UniquePathsFromStartToEnd.Size = new System.Drawing.Size(262, 42);
            this.UniquePathsFromStartToEnd.TabIndex = 1;
            this.UniquePathsFromStartToEnd.Text = "Count Unique Paths from Start to End";
            this.UniquePathsFromStartToEnd.UseVisualStyleBackColor = true;
            this.UniquePathsFromStartToEnd.Click += new System.EventHandler(this.UniquePathsFromStartToEnd_Click);
            // 
            // DynamicProgramming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 519);
            this.Controls.Add(this.UniquePathsFromStartToEnd);
            this.Controls.Add(this.PossibleWaysToDecodeADigit);
            this.Name = "DynamicProgramming";
            this.Text = "DynamicProgramming";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PossibleWaysToDecodeADigit;
        private System.Windows.Forms.Button UniquePathsFromStartToEnd;
    }
}
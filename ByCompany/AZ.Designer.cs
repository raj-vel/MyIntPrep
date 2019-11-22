namespace ByCompany
{
    partial class AZ
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
            this.PermutationOfCharsInaString = new System.Windows.Forms.Button();
            this.CountNumberOfIslands = new System.Windows.Forms.Button();
            this.CountMaxAreaOfIsland = new System.Windows.Forms.Button();
            this.CategorizeAndSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PermutationOfCharsInaString
            // 
            this.PermutationOfCharsInaString.Location = new System.Drawing.Point(70, 45);
            this.PermutationOfCharsInaString.Name = "PermutationOfCharsInaString";
            this.PermutationOfCharsInaString.Size = new System.Drawing.Size(156, 44);
            this.PermutationOfCharsInaString.TabIndex = 0;
            this.PermutationOfCharsInaString.Text = "Find Permutation of chars in a string";
            this.PermutationOfCharsInaString.UseVisualStyleBackColor = true;
            this.PermutationOfCharsInaString.Click += new System.EventHandler(this.PermutationOfCharsInaString_Click);
            // 
            // CountNumberOfIslands
            // 
            this.CountNumberOfIslands.Location = new System.Drawing.Point(296, 45);
            this.CountNumberOfIslands.Name = "CountNumberOfIslands";
            this.CountNumberOfIslands.Size = new System.Drawing.Size(185, 44);
            this.CountNumberOfIslands.TabIndex = 1;
            this.CountNumberOfIslands.Text = "Count Number of Islands";
            this.CountNumberOfIslands.UseVisualStyleBackColor = true;
            this.CountNumberOfIslands.Click += new System.EventHandler(this.CountNumberOfIslands_Click);
            // 
            // CountMaxAreaOfIsland
            // 
            this.CountMaxAreaOfIsland.Location = new System.Drawing.Point(551, 45);
            this.CountMaxAreaOfIsland.Name = "CountMaxAreaOfIsland";
            this.CountMaxAreaOfIsland.Size = new System.Drawing.Size(188, 44);
            this.CountMaxAreaOfIsland.TabIndex = 2;
            this.CountMaxAreaOfIsland.Text = "Count Max Area of Island";
            this.CountMaxAreaOfIsland.UseVisualStyleBackColor = true;
            this.CountMaxAreaOfIsland.Click += new System.EventHandler(this.CountMaxAreaOfIsland_Click);
            // 
            // CategorizeAndSort
            // 
            this.CategorizeAndSort.Location = new System.Drawing.Point(809, 45);
            this.CategorizeAndSort.Name = "CategorizeAndSort";
            this.CategorizeAndSort.Size = new System.Drawing.Size(194, 44);
            this.CategorizeAndSort.TabIndex = 3;
            this.CategorizeAndSort.Text = "Categorize and Sort";
            this.CategorizeAndSort.UseVisualStyleBackColor = true;
            this.CategorizeAndSort.Click += new System.EventHandler(this.CategorizeAndSort_Click);
            // 
            // AZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 803);
            this.Controls.Add(this.CategorizeAndSort);
            this.Controls.Add(this.CountMaxAreaOfIsland);
            this.Controls.Add(this.CountNumberOfIslands);
            this.Controls.Add(this.PermutationOfCharsInaString);
            this.Name = "AZ";
            this.Text = "AZ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PermutationOfCharsInaString;
        private System.Windows.Forms.Button CountNumberOfIslands;
        private System.Windows.Forms.Button CountMaxAreaOfIsland;
        private System.Windows.Forms.Button CategorizeAndSort;
    }
}
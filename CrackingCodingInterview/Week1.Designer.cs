namespace CrackingCodingInterview
{
    partial class Week1
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
            this.label1 = new System.Windows.Forms.Label();
            this.IsStringUnique = new System.Windows.Forms.Button();
            this.Palindrome_Permutation = new System.Windows.Forms.Button();
            this.RotateMatrixToRight = new System.Windows.Forms.Button();
            this.RemoveDuplicateFromLinkedList = new System.Windows.Forms.Button();
            this.PartitionOfLinkedList = new System.Windows.Forms.Button();
            this.IntersectionOfTwoLinkedLists = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.MinimumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Week 1";
            // 
            // IsStringUnique
            // 
            this.IsStringUnique.Location = new System.Drawing.Point(30, 56);
            this.IsStringUnique.Name = "IsStringUnique";
            this.IsStringUnique.Size = new System.Drawing.Size(183, 37);
            this.IsStringUnique.TabIndex = 1;
            this.IsStringUnique.Text = "IsUnique characters in String";
            this.IsStringUnique.UseVisualStyleBackColor = true;
            this.IsStringUnique.Click += new System.EventHandler(this.IsStringUnique_Click);
            // 
            // Palindrome_Permutation
            // 
            this.Palindrome_Permutation.Location = new System.Drawing.Point(259, 56);
            this.Palindrome_Permutation.Name = "Palindrome_Permutation";
            this.Palindrome_Permutation.Size = new System.Drawing.Size(197, 37);
            this.Palindrome_Permutation.TabIndex = 2;
            this.Palindrome_Permutation.Text = "Plaindrome Permutation";
            this.Palindrome_Permutation.UseVisualStyleBackColor = true;
            this.Palindrome_Permutation.Click += new System.EventHandler(this.Palindrome_Permutation_Click);
            // 
            // RotateMatrixToRight
            // 
            this.RotateMatrixToRight.Location = new System.Drawing.Point(500, 56);
            this.RotateMatrixToRight.Name = "RotateMatrixToRight";
            this.RotateMatrixToRight.Size = new System.Drawing.Size(165, 37);
            this.RotateMatrixToRight.TabIndex = 3;
            this.RotateMatrixToRight.Text = "Rotate Matrix";
            this.RotateMatrixToRight.UseVisualStyleBackColor = true;
            this.RotateMatrixToRight.Click += new System.EventHandler(this.RotateMatrixToRight_Click);
            // 
            // RemoveDuplicateFromLinkedList
            // 
            this.RemoveDuplicateFromLinkedList.Location = new System.Drawing.Point(735, 56);
            this.RemoveDuplicateFromLinkedList.Name = "RemoveDuplicateFromLinkedList";
            this.RemoveDuplicateFromLinkedList.Size = new System.Drawing.Size(166, 36);
            this.RemoveDuplicateFromLinkedList.TabIndex = 4;
            this.RemoveDuplicateFromLinkedList.Text = "Remove Duplicates from LinkedList";
            this.RemoveDuplicateFromLinkedList.UseVisualStyleBackColor = true;
            this.RemoveDuplicateFromLinkedList.Click += new System.EventHandler(this.RemoveDuplicateFromLinkedList_Click);
            // 
            // PartitionOfLinkedList
            // 
            this.PartitionOfLinkedList.Location = new System.Drawing.Point(977, 56);
            this.PartitionOfLinkedList.Name = "PartitionOfLinkedList";
            this.PartitionOfLinkedList.Size = new System.Drawing.Size(163, 36);
            this.PartitionOfLinkedList.TabIndex = 5;
            this.PartitionOfLinkedList.Text = "Partition of LinkedList";
            this.PartitionOfLinkedList.UseVisualStyleBackColor = true;
            this.PartitionOfLinkedList.Click += new System.EventHandler(this.PartitionOfLinkedList_Click);
            // 
            // IntersectionOfTwoLinkedLists
            // 
            this.IntersectionOfTwoLinkedLists.Location = new System.Drawing.Point(1186, 56);
            this.IntersectionOfTwoLinkedLists.Name = "IntersectionOfTwoLinkedLists";
            this.IntersectionOfTwoLinkedLists.Size = new System.Drawing.Size(156, 36);
            this.IntersectionOfTwoLinkedLists.TabIndex = 6;
            this.IntersectionOfTwoLinkedLists.Text = "Intersection of Two Linkedlists";
            this.IntersectionOfTwoLinkedLists.UseVisualStyleBackColor = true;
            this.IntersectionOfTwoLinkedLists.Click += new System.EventHandler(this.IntersectionOfTwoLinkedLists_Click);
            // 
            // Week1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 791);
            this.Controls.Add(this.IntersectionOfTwoLinkedLists);
            this.Controls.Add(this.PartitionOfLinkedList);
            this.Controls.Add(this.RemoveDuplicateFromLinkedList);
            this.Controls.Add(this.RotateMatrixToRight);
            this.Controls.Add(this.Palindrome_Permutation);
            this.Controls.Add(this.IsStringUnique);
            this.Controls.Add(this.label1);
            this.Name = "Week1";
            this.Text = "Cracking Coding Interview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IsStringUnique;
        private System.Windows.Forms.Button Palindrome_Permutation;
        private System.Windows.Forms.Button RotateMatrixToRight;
        private System.Windows.Forms.Button RemoveDuplicateFromLinkedList;
        private System.Windows.Forms.Button PartitionOfLinkedList;
        private System.Windows.Forms.Button IntersectionOfTwoLinkedLists;
    }
}


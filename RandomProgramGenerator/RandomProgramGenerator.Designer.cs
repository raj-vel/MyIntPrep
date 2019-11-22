namespace RandomProgramGenerator
{
    partial class RandomProgramGenerator
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
            this.Array = new System.Windows.Forms.Button();
            this.String = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.Button();
            this.BinaryTree = new System.Windows.Forms.Button();
            this.LinkedLists = new System.Windows.Forms.Button();
            this.Matrix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.All = new System.Windows.Forms.Button();
            this.Recursion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Array
            // 
            this.Array.Location = new System.Drawing.Point(29, 35);
            this.Array.Name = "Array";
            this.Array.Size = new System.Drawing.Size(203, 41);
            this.Array.TabIndex = 0;
            this.Array.Text = "Array";
            this.Array.UseVisualStyleBackColor = true;
            this.Array.Click += new System.EventHandler(this.Array_Click);
            // 
            // String
            // 
            this.String.Location = new System.Drawing.Point(316, 35);
            this.String.Name = "String";
            this.String.Size = new System.Drawing.Size(210, 40);
            this.String.TabIndex = 1;
            this.String.Text = "String";
            this.String.UseVisualStyleBackColor = true;
            this.String.Click += new System.EventHandler(this.String_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(605, 35);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(196, 39);
            this.Number.TabIndex = 2;
            this.Number.Text = "Number";
            this.Number.UseVisualStyleBackColor = true;
            this.Number.Click += new System.EventHandler(this.Number_Click);
            // 
            // BinaryTree
            // 
            this.BinaryTree.Location = new System.Drawing.Point(888, 35);
            this.BinaryTree.Name = "BinaryTree";
            this.BinaryTree.Size = new System.Drawing.Size(215, 38);
            this.BinaryTree.TabIndex = 3;
            this.BinaryTree.Text = "Binary Tree";
            this.BinaryTree.UseVisualStyleBackColor = true;
            this.BinaryTree.Click += new System.EventHandler(this.BinaryTree_Click);
            // 
            // LinkedLists
            // 
            this.LinkedLists.Location = new System.Drawing.Point(29, 134);
            this.LinkedLists.Name = "LinkedLists";
            this.LinkedLists.Size = new System.Drawing.Size(203, 38);
            this.LinkedLists.TabIndex = 4;
            this.LinkedLists.Text = "Linked Lists";
            this.LinkedLists.UseVisualStyleBackColor = true;
            this.LinkedLists.Click += new System.EventHandler(this.LinkedLists_Click);
            // 
            // Matrix
            // 
            this.Matrix.Location = new System.Drawing.Point(316, 134);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(210, 38);
            this.Matrix.TabIndex = 5;
            this.Matrix.Text = "Matrix";
            this.Matrix.UseVisualStyleBackColor = true;
            this.Matrix.Click += new System.EventHandler(this.Matrix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 208);
            this.label1.MaximumSize = new System.Drawing.Size(800, 50);
            this.label1.MinimumSize = new System.Drawing.Size(500, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Random Program:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // All
            // 
            this.All.Location = new System.Drawing.Point(408, 307);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(239, 39);
            this.All.TabIndex = 7;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // Recursion
            // 
            this.Recursion.Location = new System.Drawing.Point(605, 134);
            this.Recursion.Name = "Recursion";
            this.Recursion.Size = new System.Drawing.Size(196, 38);
            this.Recursion.TabIndex = 8;
            this.Recursion.Text = "Recursion";
            this.Recursion.UseVisualStyleBackColor = true;
            this.Recursion.Click += new System.EventHandler(this.Recursion_Click);
            // 
            // RandomProgramGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 440);
            this.Controls.Add(this.Recursion);
            this.Controls.Add(this.All);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.LinkedLists);
            this.Controls.Add(this.BinaryTree);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.String);
            this.Controls.Add(this.Array);
            this.Name = "RandomProgramGenerator";
            this.Text = "RandomProgramGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Array;
        private System.Windows.Forms.Button String;
        private System.Windows.Forms.Button Number;
        private System.Windows.Forms.Button BinaryTree;
        private System.Windows.Forms.Button LinkedLists;
        private System.Windows.Forms.Button Matrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Button Recursion;
    }
}


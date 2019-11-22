namespace IntPrepProj
{
    partial class Arrays_V2
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
            this.ProductOfArrayExceptSelf = new System.Windows.Forms.Button();
            this.KthLargestElementInArray_QuickSelect = new System.Windows.Forms.Button();
            this.SmallestMissingPositiveInt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductOfArrayExceptSelf
            // 
            this.ProductOfArrayExceptSelf.Location = new System.Drawing.Point(45, 40);
            this.ProductOfArrayExceptSelf.Name = "ProductOfArrayExceptSelf";
            this.ProductOfArrayExceptSelf.Size = new System.Drawing.Size(192, 40);
            this.ProductOfArrayExceptSelf.TabIndex = 0;
            this.ProductOfArrayExceptSelf.Text = "Product of Array Except Self";
            this.ProductOfArrayExceptSelf.UseVisualStyleBackColor = true;
            this.ProductOfArrayExceptSelf.Click += new System.EventHandler(this.ProductOfArrayExceptSelf_Click);
            // 
            // KthLargestElementInArray_QuickSelect
            // 
            this.KthLargestElementInArray_QuickSelect.Location = new System.Drawing.Point(285, 40);
            this.KthLargestElementInArray_QuickSelect.Name = "KthLargestElementInArray_QuickSelect";
            this.KthLargestElementInArray_QuickSelect.Size = new System.Drawing.Size(215, 40);
            this.KthLargestElementInArray_QuickSelect.TabIndex = 1;
            this.KthLargestElementInArray_QuickSelect.Text = "Kth Largest Element in Array - QuickSelect";
            this.KthLargestElementInArray_QuickSelect.UseVisualStyleBackColor = true;
            this.KthLargestElementInArray_QuickSelect.Click += new System.EventHandler(this.KthLargestElementInArray_QuickSelect_Click);
            // 
            // SmallestMissingPositiveInt
            // 
            this.SmallestMissingPositiveInt.Location = new System.Drawing.Point(562, 40);
            this.SmallestMissingPositiveInt.Name = "SmallestMissingPositiveInt";
            this.SmallestMissingPositiveInt.Size = new System.Drawing.Size(262, 40);
            this.SmallestMissingPositiveInt.TabIndex = 2;
            this.SmallestMissingPositiveInt.Text = "Smallest Missing Positive Integer";
            this.SmallestMissingPositiveInt.UseVisualStyleBackColor = true;
            this.SmallestMissingPositiveInt.Click += new System.EventHandler(this.SmallestMissingPositiveInt_Click);
            // 
            // Arrays_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 728);
            this.Controls.Add(this.SmallestMissingPositiveInt);
            this.Controls.Add(this.KthLargestElementInArray_QuickSelect);
            this.Controls.Add(this.ProductOfArrayExceptSelf);
            this.Name = "Arrays_V2";
            this.Text = "Arrays_V2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductOfArrayExceptSelf;
        private System.Windows.Forms.Button KthLargestElementInArray_QuickSelect;
        private System.Windows.Forms.Button SmallestMissingPositiveInt;
    }
}
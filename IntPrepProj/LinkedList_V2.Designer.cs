namespace IntPrepProj
{
    partial class LinkedList_V2
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
            this.InsertNodeAtFront = new System.Windows.Forms.Button();
            this.InsertNodeAtLast = new System.Windows.Forms.Button();
            this.InsertNodeInMid = new System.Windows.Forms.Button();
            this.DeleteANodeFromLinkedList = new System.Windows.Forms.Button();
            this.MergeTwoSortedLinkedLists = new System.Windows.Forms.Button();
            this.ReverseTheLinkedList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InsertNodeAtFront
            // 
            this.InsertNodeAtFront.Location = new System.Drawing.Point(28, 34);
            this.InsertNodeAtFront.Name = "InsertNodeAtFront";
            this.InsertNodeAtFront.Size = new System.Drawing.Size(147, 38);
            this.InsertNodeAtFront.TabIndex = 0;
            this.InsertNodeAtFront.Text = "Insert Node at Front";
            this.InsertNodeAtFront.UseVisualStyleBackColor = true;
            this.InsertNodeAtFront.Click += new System.EventHandler(this.InsertNodeAtFront_Click);
            // 
            // InsertNodeAtLast
            // 
            this.InsertNodeAtLast.Location = new System.Drawing.Point(210, 34);
            this.InsertNodeAtLast.Name = "InsertNodeAtLast";
            this.InsertNodeAtLast.Size = new System.Drawing.Size(159, 38);
            this.InsertNodeAtLast.TabIndex = 1;
            this.InsertNodeAtLast.Text = "Insert Node at Last";
            this.InsertNodeAtLast.UseVisualStyleBackColor = true;
            this.InsertNodeAtLast.Click += new System.EventHandler(this.InsertNodeAtLast_Click);
            // 
            // InsertNodeInMid
            // 
            this.InsertNodeInMid.Location = new System.Drawing.Point(403, 34);
            this.InsertNodeInMid.Name = "InsertNodeInMid";
            this.InsertNodeInMid.Size = new System.Drawing.Size(175, 38);
            this.InsertNodeInMid.TabIndex = 2;
            this.InsertNodeInMid.Text = "Insert Node in middle";
            this.InsertNodeInMid.UseVisualStyleBackColor = true;
            this.InsertNodeInMid.Click += new System.EventHandler(this.InsertNodeInMid_Click);
            // 
            // DeleteANodeFromLinkedList
            // 
            this.DeleteANodeFromLinkedList.Location = new System.Drawing.Point(613, 34);
            this.DeleteANodeFromLinkedList.Name = "DeleteANodeFromLinkedList";
            this.DeleteANodeFromLinkedList.Size = new System.Drawing.Size(196, 38);
            this.DeleteANodeFromLinkedList.TabIndex = 3;
            this.DeleteANodeFromLinkedList.Text = "Delete a Node From LinkedList";
            this.DeleteANodeFromLinkedList.UseVisualStyleBackColor = true;
            this.DeleteANodeFromLinkedList.Click += new System.EventHandler(this.DeleteANodeFromLinkedList_Click);
            // 
            // MergeTwoSortedLinkedLists
            // 
            this.MergeTwoSortedLinkedLists.Location = new System.Drawing.Point(838, 34);
            this.MergeTwoSortedLinkedLists.Name = "MergeTwoSortedLinkedLists";
            this.MergeTwoSortedLinkedLists.Size = new System.Drawing.Size(203, 38);
            this.MergeTwoSortedLinkedLists.TabIndex = 4;
            this.MergeTwoSortedLinkedLists.Text = "Merge Two Sorted Linked List";
            this.MergeTwoSortedLinkedLists.UseVisualStyleBackColor = true;
            this.MergeTwoSortedLinkedLists.Click += new System.EventHandler(this.MergeTwoSortedLinkedLists_Click);
            // 
            // ReverseTheLinkedList
            // 
            this.ReverseTheLinkedList.Location = new System.Drawing.Point(1093, 34);
            this.ReverseTheLinkedList.Name = "ReverseTheLinkedList";
            this.ReverseTheLinkedList.Size = new System.Drawing.Size(169, 38);
            this.ReverseTheLinkedList.TabIndex = 5;
            this.ReverseTheLinkedList.Text = "Reverse the LinkedList";
            this.ReverseTheLinkedList.UseVisualStyleBackColor = true;
            this.ReverseTheLinkedList.Click += new System.EventHandler(this.ReverseTheLinkedList_Click);
            // 
            // LinkedList_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 609);
            this.Controls.Add(this.ReverseTheLinkedList);
            this.Controls.Add(this.MergeTwoSortedLinkedLists);
            this.Controls.Add(this.DeleteANodeFromLinkedList);
            this.Controls.Add(this.InsertNodeInMid);
            this.Controls.Add(this.InsertNodeAtLast);
            this.Controls.Add(this.InsertNodeAtFront);
            this.Name = "LinkedList_V2";
            this.Text = "LinkedList_V2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InsertNodeAtFront;
        private System.Windows.Forms.Button InsertNodeAtLast;
        private System.Windows.Forms.Button InsertNodeInMid;
        private System.Windows.Forms.Button DeleteANodeFromLinkedList;
        private System.Windows.Forms.Button MergeTwoSortedLinkedLists;
        private System.Windows.Forms.Button ReverseTheLinkedList;
    }
}
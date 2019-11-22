namespace IntPrepProj
{
    partial class Stack
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
            this.GetMinInStack = new System.Windows.Forms.Button();
            this.StackInLinkedList = new System.Windows.Forms.Button();
            this.StackUsingQueueFastOnPush = new System.Windows.Forms.Button();
            this.StackUsingQueue_FastOnPop = new System.Windows.Forms.Button();
            this.ExpressionEvaluation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetMinInStack
            // 
            this.GetMinInStack.Location = new System.Drawing.Point(45, 47);
            this.GetMinInStack.Name = "GetMinInStack";
            this.GetMinInStack.Size = new System.Drawing.Size(213, 40);
            this.GetMinInStack.TabIndex = 0;
            this.GetMinInStack.Text = "Get Min In Stack";
            this.GetMinInStack.UseVisualStyleBackColor = true;
            this.GetMinInStack.Click += new System.EventHandler(this.GetMinInStack_Click);
            // 
            // StackInLinkedList
            // 
            this.StackInLinkedList.Location = new System.Drawing.Point(323, 47);
            this.StackInLinkedList.Name = "StackInLinkedList";
            this.StackInLinkedList.Size = new System.Drawing.Size(198, 40);
            this.StackInLinkedList.TabIndex = 1;
            this.StackInLinkedList.Text = "Stack using Linkedlist";
            this.StackInLinkedList.UseVisualStyleBackColor = true;
            this.StackInLinkedList.Click += new System.EventHandler(this.StackInLinkedList_Click);
            // 
            // StackUsingQueueFastOnPush
            // 
            this.StackUsingQueueFastOnPush.Location = new System.Drawing.Point(590, 47);
            this.StackUsingQueueFastOnPush.Name = "StackUsingQueueFastOnPush";
            this.StackUsingQueueFastOnPush.Size = new System.Drawing.Size(193, 40);
            this.StackUsingQueueFastOnPush.TabIndex = 2;
            this.StackUsingQueueFastOnPush.Text = "Stack Using Queue - Faster Push";
            this.StackUsingQueueFastOnPush.UseVisualStyleBackColor = true;
            this.StackUsingQueueFastOnPush.Click += new System.EventHandler(this.StackUsingQueueFastOnPush_Click);
            // 
            // StackUsingQueue_FastOnPop
            // 
            this.StackUsingQueue_FastOnPop.Location = new System.Drawing.Point(857, 47);
            this.StackUsingQueue_FastOnPop.Name = "StackUsingQueue_FastOnPop";
            this.StackUsingQueue_FastOnPop.Size = new System.Drawing.Size(176, 40);
            this.StackUsingQueue_FastOnPop.TabIndex = 3;
            this.StackUsingQueue_FastOnPop.Text = "Stack Using Queue - Fast Pop";
            this.StackUsingQueue_FastOnPop.UseVisualStyleBackColor = true;
            this.StackUsingQueue_FastOnPop.Click += new System.EventHandler(this.StackUsingQueue_FastOnPop_Click);
            // 
            // ExpressionEvaluation
            // 
            this.ExpressionEvaluation.Location = new System.Drawing.Point(45, 121);
            this.ExpressionEvaluation.Name = "ExpressionEvaluation";
            this.ExpressionEvaluation.Size = new System.Drawing.Size(213, 41);
            this.ExpressionEvaluation.TabIndex = 4;
            this.ExpressionEvaluation.Text = "Expression Evulation";
            this.ExpressionEvaluation.UseVisualStyleBackColor = true;
            this.ExpressionEvaluation.Click += new System.EventHandler(this.ExpressionEvaluation_Click);
            // 
            // Stack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 560);
            this.Controls.Add(this.ExpressionEvaluation);
            this.Controls.Add(this.StackUsingQueue_FastOnPop);
            this.Controls.Add(this.StackUsingQueueFastOnPush);
            this.Controls.Add(this.StackInLinkedList);
            this.Controls.Add(this.GetMinInStack);
            this.Name = "Stack";
            this.Text = "Stack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetMinInStack;
        private System.Windows.Forms.Button StackInLinkedList;
        private System.Windows.Forms.Button StackUsingQueueFastOnPush;
        private System.Windows.Forms.Button StackUsingQueue_FastOnPop;
        private System.Windows.Forms.Button ExpressionEvaluation;
    }
}
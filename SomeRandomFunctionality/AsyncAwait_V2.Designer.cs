namespace SomeRandomFunctionality
{
    partial class AsyncAwait_V2
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
            this.AsyncAwaitDebug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AsyncAwaitDebug
            // 
            this.AsyncAwaitDebug.Location = new System.Drawing.Point(94, 46);
            this.AsyncAwaitDebug.Name = "AsyncAwaitDebug";
            this.AsyncAwaitDebug.Size = new System.Drawing.Size(255, 23);
            this.AsyncAwaitDebug.TabIndex = 0;
            this.AsyncAwaitDebug.Text = "Async Await Debug";
            this.AsyncAwaitDebug.UseVisualStyleBackColor = true;
            this.AsyncAwaitDebug.Click += new System.EventHandler(this.AsyncAwaitDebug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // AsyncAwait_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AsyncAwaitDebug);
            this.Name = "AsyncAwait_V2";
            this.Text = "AsyncAwait_V2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AsyncAwaitDebug;
        private System.Windows.Forms.Label label1;
    }
}
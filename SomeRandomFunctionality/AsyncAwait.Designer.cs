namespace SomeRandomFunctionality
{
    partial class AsyncAwait
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.AsyncAwaitParallel = new System.Windows.Forms.Button();
            this.StepByStepPrintOfAsyncAwait = new System.Windows.Forms.Button();
            this.lblAsyncAwaitPrint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(905, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sync Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(905, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Async Await Process";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(285, 181);
            this.resultLabel.MaximumSize = new System.Drawing.Size(800, 300);
            this.resultLabel.MinimumSize = new System.Drawing.Size(800, 300);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(800, 300);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "label1";
            // 
            // AsyncAwaitParallel
            // 
            this.AsyncAwaitParallel.Location = new System.Drawing.Point(288, 126);
            this.AsyncAwaitParallel.Name = "AsyncAwaitParallel";
            this.AsyncAwaitParallel.Size = new System.Drawing.Size(905, 32);
            this.AsyncAwaitParallel.TabIndex = 3;
            this.AsyncAwaitParallel.Text = "Async Await Parallel";
            this.AsyncAwaitParallel.UseVisualStyleBackColor = true;
            this.AsyncAwaitParallel.Click += new System.EventHandler(this.AsyncAwaitParallel_Click);
            // 
            // StepByStepPrintOfAsyncAwait
            // 
            this.StepByStepPrintOfAsyncAwait.Location = new System.Drawing.Point(288, 496);
            this.StepByStepPrintOfAsyncAwait.Name = "StepByStepPrintOfAsyncAwait";
            this.StepByStepPrintOfAsyncAwait.Size = new System.Drawing.Size(878, 23);
            this.StepByStepPrintOfAsyncAwait.TabIndex = 4;
            this.StepByStepPrintOfAsyncAwait.Text = "Print Async Await steps";
            this.StepByStepPrintOfAsyncAwait.UseVisualStyleBackColor = true;
            this.StepByStepPrintOfAsyncAwait.Click += new System.EventHandler(this.StepByStepPrintOfAsyncAwait_Click);
            // 
            // lblAsyncAwaitPrint
            // 
            this.lblAsyncAwaitPrint.AutoSize = true;
            this.lblAsyncAwaitPrint.Location = new System.Drawing.Point(285, 536);
            this.lblAsyncAwaitPrint.MaximumSize = new System.Drawing.Size(500, 150);
            this.lblAsyncAwaitPrint.MinimumSize = new System.Drawing.Size(500, 150);
            this.lblAsyncAwaitPrint.Name = "lblAsyncAwaitPrint";
            this.lblAsyncAwaitPrint.Size = new System.Drawing.Size(500, 150);
            this.lblAsyncAwaitPrint.TabIndex = 5;
            this.lblAsyncAwaitPrint.Text = "Print Steps";
            // 
            // AsyncAwait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 722);
            this.Controls.Add(this.lblAsyncAwaitPrint);
            this.Controls.Add(this.StepByStepPrintOfAsyncAwait);
            this.Controls.Add(this.AsyncAwaitParallel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AsyncAwait";
            this.Text = "Async Await";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button AsyncAwaitParallel;
        private System.Windows.Forms.Button StepByStepPrintOfAsyncAwait;
        private System.Windows.Forms.Label lblAsyncAwaitPrint;
    }
}


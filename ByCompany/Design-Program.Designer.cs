namespace ByCompany
{
    partial class Design_Program
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
            this.Soduku_Fill_Matrix = new System.Windows.Forms.Button();
            this.Soduku_Validate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Soduku_Fill_Matrix
            // 
            this.Soduku_Fill_Matrix.Location = new System.Drawing.Point(36, 28);
            this.Soduku_Fill_Matrix.Name = "Soduku_Fill_Matrix";
            this.Soduku_Fill_Matrix.Size = new System.Drawing.Size(187, 31);
            this.Soduku_Fill_Matrix.TabIndex = 0;
            this.Soduku_Fill_Matrix.Text = "Soduku - Fill Matrix";
            this.Soduku_Fill_Matrix.UseVisualStyleBackColor = true;
            this.Soduku_Fill_Matrix.Click += new System.EventHandler(this.Soduku_Fill_Matrix_Click);
            // 
            // Soduku_Validate
            // 
            this.Soduku_Validate.Location = new System.Drawing.Point(275, 28);
            this.Soduku_Validate.Name = "Soduku_Validate";
            this.Soduku_Validate.Size = new System.Drawing.Size(192, 31);
            this.Soduku_Validate.TabIndex = 1;
            this.Soduku_Validate.Text = "Soduku - Validate";
            this.Soduku_Validate.UseVisualStyleBackColor = true;
            this.Soduku_Validate.Click += new System.EventHandler(this.Soduku_Validate_Click);
            // 
            // Design_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 494);
            this.Controls.Add(this.Soduku_Validate);
            this.Controls.Add(this.Soduku_Fill_Matrix);
            this.Name = "Design_Program";
            this.Text = "Design_Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Soduku_Fill_Matrix;
        private System.Windows.Forms.Button Soduku_Validate;
    }
}
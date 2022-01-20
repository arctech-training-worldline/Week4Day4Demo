namespace Week4Day4Demo
{
    partial class FormProgressBarDemo
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
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.ButtonIncreaseProgress = new System.Windows.Forms.Button();
            this.LabelProgressText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(486, 179);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(797, 59);
            this.ProgressBar1.Step = 1;
            this.ProgressBar1.TabIndex = 0;
            // 
            // ButtonIncreaseProgress
            // 
            this.ButtonIncreaseProgress.Location = new System.Drawing.Point(468, 378);
            this.ButtonIncreaseProgress.Name = "ButtonIncreaseProgress";
            this.ButtonIncreaseProgress.Size = new System.Drawing.Size(222, 73);
            this.ButtonIncreaseProgress.TabIndex = 1;
            this.ButtonIncreaseProgress.Text = "Increase Progress";
            this.ButtonIncreaseProgress.UseVisualStyleBackColor = true;
            this.ButtonIncreaseProgress.Click += new System.EventHandler(this.ButtonIncreaseProgress_Click);
            // 
            // LabelProgressText
            // 
            this.LabelProgressText.AutoSize = true;
            this.LabelProgressText.Location = new System.Drawing.Point(820, 197);
            this.LabelProgressText.Name = "LabelProgressText";
            this.LabelProgressText.Size = new System.Drawing.Size(69, 40);
            this.LabelProgressText.TabIndex = 2;
            this.LabelProgressText.Text = "0%";
            this.LabelProgressText.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormProgressBarDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1842, 867);
            this.Controls.Add(this.LabelProgressText);
            this.Controls.Add(this.ButtonIncreaseProgress);
            this.Controls.Add(this.ProgressBar1);
            this.Name = "FormProgressBarDemo";
            this.Text = "FormProgressBarDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.Button ButtonIncreaseProgress;
        private System.Windows.Forms.Label LabelProgressText;
    }
}
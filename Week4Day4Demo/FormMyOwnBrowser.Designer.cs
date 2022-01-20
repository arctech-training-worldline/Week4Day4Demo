namespace Week4Day4Demo
{
    partial class FormMyOwnBrowser
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
            this.TextBoxUrl = new System.Windows.Forms.TextBox();
            this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ButtonGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxUrl
            // 
            this.TextBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUrl.Location = new System.Drawing.Point(12, 12);
            this.TextBoxUrl.Name = "TextBoxUrl";
            this.TextBoxUrl.Size = new System.Drawing.Size(1933, 56);
            this.TextBoxUrl.TabIndex = 0;
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebBrowser1.Location = new System.Drawing.Point(12, 85);
            this.WebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new System.Drawing.Size(2053, 1148);
            this.WebBrowser1.TabIndex = 1;
            // 
            // ButtonGo
            // 
            this.ButtonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGo.Location = new System.Drawing.Point(1951, 10);
            this.ButtonGo.Name = "ButtonGo";
            this.ButtonGo.Size = new System.Drawing.Size(114, 58);
            this.ButtonGo.TabIndex = 2;
            this.ButtonGo.Text = "Go";
            this.ButtonGo.UseVisualStyleBackColor = true;
            this.ButtonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // FormMyOwnBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2072, 1245);
            this.Controls.Add(this.ButtonGo);
            this.Controls.Add(this.WebBrowser1);
            this.Controls.Add(this.TextBoxUrl);
            this.Name = "FormMyOwnBrowser";
            this.Text = "FormMyOwnBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUrl;
        private System.Windows.Forms.WebBrowser WebBrowser1;
        private System.Windows.Forms.Button ButtonGo;
    }
}
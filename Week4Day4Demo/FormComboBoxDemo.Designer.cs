namespace Week4Day4Demo
{
    partial class FormComboBoxDemo
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
            this.LabelState = new System.Windows.Forms.Label();
            this.LabelCity = new System.Windows.Forms.Label();
            this.ComboBoxState = new System.Windows.Forms.ComboBox();
            this.ComboBoxCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelState
            // 
            this.LabelState.AutoSize = true;
            this.LabelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelState.Location = new System.Drawing.Point(194, 179);
            this.LabelState.Name = "LabelState";
            this.LabelState.Size = new System.Drawing.Size(218, 88);
            this.LabelState.TabIndex = 0;
            this.LabelState.Text = "State";
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCity.Location = new System.Drawing.Point(207, 254);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(106, 55);
            this.LabelCity.TabIndex = 1;
            this.LabelCity.Text = "City";
            // 
            // ComboBoxState
            // 
            this.ComboBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxState.FormattingEnabled = true;
            this.ComboBoxState.Location = new System.Drawing.Point(396, 176);
            this.ComboBoxState.Name = "ComboBoxState";
            this.ComboBoxState.Size = new System.Drawing.Size(324, 63);
            this.ComboBoxState.TabIndex = 2;
            this.ComboBoxState.SelectedIndexChanged += new System.EventHandler(this.ComboBoxState_SelectedIndexChanged);
            // 
            // ComboBoxCity
            // 
            this.ComboBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCity.FormattingEnabled = true;
            this.ComboBoxCity.Location = new System.Drawing.Point(396, 251);
            this.ComboBoxCity.Name = "ComboBoxCity";
            this.ComboBoxCity.Size = new System.Drawing.Size(324, 63);
            this.ComboBoxCity.TabIndex = 3;
            // 
            // FormComboBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 627);
            this.Controls.Add(this.ComboBoxCity);
            this.Controls.Add(this.ComboBoxState);
            this.Controls.Add(this.LabelCity);
            this.Controls.Add(this.LabelState);
            this.Name = "FormComboBoxDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComboBoxDemo";
            this.Load += new System.EventHandler(this.FormComboBoxDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelState;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.ComboBox ComboBoxState;
        private System.Windows.Forms.ComboBox ComboBoxCity;
    }
}
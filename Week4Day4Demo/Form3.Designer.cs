namespace Week4Day4Demo
{
    partial class Form3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckedListBoxTopicsOfInterest = new System.Windows.Forms.CheckedListBox();
            this.LabelTopicsOfInterest = new System.Windows.Forms.Label();
            this.DateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.LabelBirthDate = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOpenFromFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LabelCounter = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelCounter);
            this.groupBox1.Controls.Add(this.CheckedListBoxTopicsOfInterest);
            this.groupBox1.Controls.Add(this.LabelTopicsOfInterest);
            this.groupBox1.Controls.Add(this.DateTimePickerBirthDate);
            this.groupBox1.Controls.Add(this.LabelBirthDate);
            this.groupBox1.Controls.Add(this.LabelLastName);
            this.groupBox1.Controls.Add(this.LabelFirstName);
            this.groupBox1.Controls.Add(this.TextBoxLastName);
            this.groupBox1.Controls.Add(this.TextBoxFirstName);
            this.groupBox1.Controls.Add(this.LabelName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1454, 656);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // CheckedListBoxTopicsOfInterest
            // 
            this.CheckedListBoxTopicsOfInterest.FormattingEnabled = true;
            this.CheckedListBoxTopicsOfInterest.Items.AddRange(new object[] {
            "Shopping",
            "Programming",
            "Watching Movies",
            "Netflix",
            "Cricket"});
            this.CheckedListBoxTopicsOfInterest.Location = new System.Drawing.Point(466, 361);
            this.CheckedListBoxTopicsOfInterest.Name = "CheckedListBoxTopicsOfInterest";
            this.CheckedListBoxTopicsOfInterest.Size = new System.Drawing.Size(507, 269);
            this.CheckedListBoxTopicsOfInterest.TabIndex = 10;
            // 
            // LabelTopicsOfInterest
            // 
            this.LabelTopicsOfInterest.AutoSize = true;
            this.LabelTopicsOfInterest.Location = new System.Drawing.Point(73, 349);
            this.LabelTopicsOfInterest.Name = "LabelTopicsOfInterest";
            this.LabelTopicsOfInterest.Size = new System.Drawing.Size(364, 51);
            this.LabelTopicsOfInterest.TabIndex = 9;
            this.LabelTopicsOfInterest.Text = "Topics of Interest:";
            this.LabelTopicsOfInterest.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DateTimePickerBirthDate
            // 
            this.DateTimePickerBirthDate.Location = new System.Drawing.Point(463, 240);
            this.DateTimePickerBirthDate.Name = "DateTimePickerBirthDate";
            this.DateTimePickerBirthDate.Size = new System.Drawing.Size(506, 56);
            this.DateTimePickerBirthDate.TabIndex = 8;
            // 
            // LabelBirthDate
            // 
            this.LabelBirthDate.AutoSize = true;
            this.LabelBirthDate.Location = new System.Drawing.Point(223, 245);
            this.LabelBirthDate.Name = "LabelBirthDate";
            this.LabelBirthDate.Size = new System.Drawing.Size(214, 51);
            this.LabelBirthDate.TabIndex = 7;
            this.LabelBirthDate.Text = "BirthDate:";
            this.LabelBirthDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(985, 155);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(104, 51);
            this.LabelLastName.TabIndex = 4;
            this.LabelLastName.Text = "Last";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(557, 155);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(106, 51);
            this.LabelFirstName.TabIndex = 3;
            this.LabelFirstName.Text = "First";
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(860, 86);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(400, 56);
            this.TextBoxLastName.TabIndex = 2;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(454, 86);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(400, 56);
            this.TextBoxFirstName.TabIndex = 1;
            this.TextBoxFirstName.TextChanged += new System.EventHandler(this.TextBoxFirstName_TextChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(288, 86);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(149, 51);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Name:";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(1224, 680);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(246, 76);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(972, 680);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(246, 76);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOpenFromFile
            // 
            this.ButtonOpenFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOpenFromFile.Location = new System.Drawing.Point(532, 680);
            this.ButtonOpenFromFile.Name = "ButtonOpenFromFile";
            this.ButtonOpenFromFile.Size = new System.Drawing.Size(434, 76);
            this.ButtonOpenFromFile.TabIndex = 3;
            this.ButtonOpenFromFile.Text = "Open From File";
            this.ButtonOpenFromFile.UseVisualStyleBackColor = true;
            this.ButtonOpenFromFile.Click += new System.EventHandler(this.ButtonOpenFromFile_Click);
            this.ButtonOpenFromFile.MouseEnter += new System.EventHandler(this.ButtonOpenFromFile_MouseEnter);
            this.ButtonOpenFromFile.MouseLeave += new System.EventHandler(this.ButtonOpenFromFile_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LabelCounter
            // 
            this.LabelCounter.AutoSize = true;
            this.LabelCounter.Location = new System.Drawing.Point(64, 86);
            this.LabelCounter.Name = "LabelCounter";
            this.LabelCounter.Size = new System.Drawing.Size(138, 51);
            this.LabelCounter.TabIndex = 11;
            this.LabelCounter.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 766);
            this.Controls.Add(this.ButtonOpenFromFile);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "New User Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelBirthDate;
        private System.Windows.Forms.DateTimePicker DateTimePickerBirthDate;
        private System.Windows.Forms.Label LabelTopicsOfInterest;
        private System.Windows.Forms.CheckedListBox CheckedListBoxTopicsOfInterest;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOpenFromFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LabelCounter;
    }
}
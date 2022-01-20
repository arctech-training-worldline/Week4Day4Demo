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
            this.LabelPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelNotes = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LabelCounter = new System.Windows.Forms.Label();
            this.CheckedListBoxTopicsOfInterest = new System.Windows.Forms.CheckedListBox();
            this.LabelTopicsOfInterest = new System.Windows.Forms.Label();
            this.DateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.LabelBirthDate = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonOpenFromFile = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.LabelPassword);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.LabelNotes);
            this.groupBox1.Controls.Add(this.linkLabel1);
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
            this.groupBox1.Size = new System.Drawing.Size(1454, 1179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(213, 981);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(224, 51);
            this.LabelPassword.TabIndex = 15;
            this.LabelPassword.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(462, 671);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(798, 266);
            this.textBox1.TabIndex = 14;
            // 
            // LabelNotes
            // 
            this.LabelNotes.AutoSize = true;
            this.LabelNotes.Location = new System.Drawing.Point(288, 671);
            this.LabelNotes.Name = "LabelNotes";
            this.LabelNotes.Size = new System.Drawing.Size(147, 51);
            this.LabelNotes.TabIndex = 13;
            this.LabelNotes.Text = "Notes:";
            this.LabelNotes.Click += new System.EventHandler(this.LabelNotes_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1090, 372);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(218, 51);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ButtonOpenFromFile
            // 
            this.ButtonOpenFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOpenFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOpenFromFile.Location = new System.Drawing.Point(508, 1247);
            this.ButtonOpenFromFile.Name = "ButtonOpenFromFile";
            this.ButtonOpenFromFile.Size = new System.Drawing.Size(434, 76);
            this.ButtonOpenFromFile.TabIndex = 6;
            this.ButtonOpenFromFile.Text = "Open From File";
            this.ButtonOpenFromFile.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.No;
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(962, 1247);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(246, 76);
            this.ButtonCancel.TabIndex = 16;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(1227, 1247);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(246, 76);
            this.ButtonSave.TabIndex = 16;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(476, 989);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(784, 56);
            this.textBox2.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 1350);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOpenFromFile);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User Registration";
            this.DoubleClick += new System.EventHandler(this.Form3_DoubleClick);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LabelCounter;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label LabelNotes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button ButtonOpenFromFile;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox textBox2;
    }
}
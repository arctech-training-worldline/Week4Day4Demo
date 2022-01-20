using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Day4Demo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Are you sure you want to save this record", "About to Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
            {
                SaveToFile();
                MessageBox.Show("Saved Data Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (response == DialogResult.No)
            {
                MessageBox.Show("Save has been aborted", "Not Saving anymore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveToFile()
        {
            var path = @"C:\Users\avina\OneDrive - arctechinfo.com\Documents\Training\Sessions\C#\20-Jan-2021\Week4Day4Demo\Week4Day4Demo\Files\Record.txt";
            var sw = File.CreateText(path);

            var selectedTopics = "";
            foreach (var checkedItem in CheckedListBoxTopicsOfInterest.CheckedItems)
            {
                selectedTopics += $"{checkedItem},";
            }

            selectedTopics = selectedTopics.Substring(0, selectedTopics.Length - 1);

            var data = $"{TextBoxFirstName.Text},{TextBoxLastName.Text},{DateTimePickerBirthDate.Text},[{selectedTopics}]";

            sw.WriteLine(data);
            sw.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonOpenFromFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var path = openFileDialog1.FileName;

            var data = File.ReadAllText(path);

            var dataItems = data.Split(',');

            TextBoxFirstName.Text = dataItems[0];
            TextBoxLastName.Text = dataItems[1];
            DateTimePickerBirthDate.Text = dataItems[2];

            // Assignment
            //see if you can load the topics from file to screen
        }

        private void ButtonOpenFromFile_MouseEnter(object sender, EventArgs e)
        {
            ButtonOpenFromFile.BackColor = Color.Aqua;
        }

        private void ButtonOpenFromFile_MouseLeave(object sender, EventArgs e)
        {
            ButtonOpenFromFile.BackColor = Color.WhiteSmoke;
        }

        private void TextBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            LabelCounter.Text = $@"{TextBoxFirstName.Text.Length}";
        }

        private void Form3_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}

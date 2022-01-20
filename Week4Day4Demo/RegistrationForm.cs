using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Day4Demo
{
    internal class RegistrationForm : Form
    {
        private Label label1;
        private TextBox textbox1;

        public RegistrationForm()
        {
            SetupControl();
            InitializeComponent();
        }

        private void SetupControl()
        {
            label1 = new Label();
            label1.Text = @"Name: ";
            label1.Location = new Point(10, 50);
            label1.Size = new Size(50, 50);

            textbox1 = new TextBox();
            textbox1.Location = new Point(100, 50);
            textbox1.Size = new Size(200, 50);

            Controls.Add(label1);
            Controls.Add(textbox1);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RegistrationForm
            // 
            this.ClientSize = new System.Drawing.Size(1212, 536);
            this.Name = "RegistrationForm";
            this.Text = "My manually created form";
            this.ResumeLayout(false);

        }
    }
}

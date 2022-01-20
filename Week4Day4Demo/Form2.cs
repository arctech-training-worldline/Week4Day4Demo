using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Day4Demo
{
    internal class Form2 : Form
    {
        public Form2()
        {
            Text = "My 2nd Form created manually";
            Width = 1000;
            Height = 500;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1624, 559);
            this.Name = "Form2";
            this.ResumeLayout(false);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Day4Demo
{
    public partial class FormProgressBarDemo : Form
    {
        public FormProgressBarDemo()
        {
            InitializeComponent();
        }

        private void ButtonIncreaseProgress_Click(object sender, EventArgs e)
        {
            ProgressBar1.PerformStep();
            LabelProgressText.Text = $@"{ProgressBar1.Value}%";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

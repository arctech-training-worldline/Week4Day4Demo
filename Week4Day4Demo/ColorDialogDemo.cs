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
    public partial class ColorDialogDemo : Form
    {
        public ColorDialogDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();

            var result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }
    }
}

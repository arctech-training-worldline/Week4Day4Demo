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
    public partial class FormMyOwnBrowser : Form
    {
        public FormMyOwnBrowser()
        {
            InitializeComponent();
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            WebBrowser1.Navigate(TextBoxUrl.Text);
        }
    }
}

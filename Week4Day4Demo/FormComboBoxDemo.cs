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
    public partial class FormComboBoxDemo : Form
    {
        public FormComboBoxDemo()
        {
            InitializeComponent();
        }

        private void FormComboBoxDemo_Load(object sender, EventArgs e)
        {
            var states = new string[] { "Maharashtra", "Tamil Nadu", "Kerala", "Uttar Pradesh" };

            foreach (var state in states)
            {
                ComboBoxState.Items.Add(state);
            }
        }

        private void ComboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBoxState.Text)
            {
                case "Maharashtra":
                    ComboBoxCity.Items.Clear();
                    ComboBoxCity.Text = "";
                    ComboBoxCity.Items.Add("Mumbai");
                    ComboBoxCity.Items.Add("Pune");
                    ComboBoxCity.Items.Add("Nagpur");
                    ComboBoxCity.Items.Add("Raigad");
                    ComboBoxCity.Items.Add("Ratnagiri");

                    break;
                case "Tamil Nadu":
                    ComboBoxCity.Items.Clear();
                    ComboBoxCity.Text = "";
                    ComboBoxCity.Items.Add("Chennai");
                    ComboBoxCity.Items.Add("Madurai");
                    ComboBoxCity.Items.Add("Trichy");
                    break;
            }
        }
    }
}

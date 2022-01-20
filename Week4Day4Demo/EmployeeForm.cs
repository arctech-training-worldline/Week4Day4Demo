using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4Day4Demo
{
    internal class EmployeeForm : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Label label2;

        public EmployeeForm()
        {
            InitializeComponent();
            MyOwnCode();
        }

        private void MyOwnCode()
        {
            textBox2 = new TextBox();
            textBox2.Location = new Point(151, 300);
            textBox2.Size = new Size(400, 50);

            base.Controls.Add(textBox2);

            label2 = new Label();
            label2.Text = "Enter name:";
            label2.Location = new Point(10, 10);
            label2.Size = new Size(100, 50);
            
            base.Controls.Add(label2);
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(478, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(719, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Name:";
            // 
            // EmployeeForm
            // 
            this.ClientSize = new System.Drawing.Size(1057, 443);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, res;
            num1 = Convert.ToDouble(textBox1.Text);
            num2= Convert.ToDouble(textBox2.Text);

            switch (comboBox1.Text)
            {
                case "+":
                    res = num1 + num2;
                    textBox3.Text = Convert.ToString(res);
                    break;
                case "-":
                    res = num1 - num2;
                    textBox3.Text = Convert.ToString(res);
                    break;
                case "*":
                    res = num1 * num2;
                    textBox3.Text = Convert.ToString(res);
                    break;
                case "/":
                    res = num1 / num2;
                    textBox3.Text = Convert.ToString(res);
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }
    }
}

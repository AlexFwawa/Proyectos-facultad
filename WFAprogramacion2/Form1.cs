using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAprogramacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("steam://install/730");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calcularsuma();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calcularsuma();
        }

        private void calcularsuma()
        {
            double num1, num2;
            if (double.TryParse(textBox1.Text, out num1) && double.TryParse(textBox2.Text, out num2))
            {
                label1.Text = "resultado: " + (num1 + num2).ToString();
            }
            else
            {
                label1.Text = "resultado: ---";
            }
        }
    }
}

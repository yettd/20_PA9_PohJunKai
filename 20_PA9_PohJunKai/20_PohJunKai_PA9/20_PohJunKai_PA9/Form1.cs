using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_PohJunKai_PA9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float amount =float.Parse(textBox1.Text);
                if (amount >= 0)
                {
                    if (radioButton1.Checked == true)
                    {
                        float convert = amount * 0.74f;
                        textBox2.Text = convert.ToString();
                    }
                    else if (radioButton2.Checked == true)
                    {
                        float convert = amount * 81.97f;
                        textBox2.Text = convert.ToString();
                    }
                }
                else
                {
                    textBox2.Text = "Please enter a positive number";

                }
            }
            catch
            {
                textBox2.Text = "Please enter number";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

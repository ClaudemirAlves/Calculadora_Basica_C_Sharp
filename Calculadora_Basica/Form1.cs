using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Basica
{
    public partial class Form1 : Form
    {
        double num = 0;
        double memoria = 0;
        Boolean soma = false;
        Boolean sub = false;
        Boolean mult = false;
        Boolean div = false;
        double resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = 0;
            label3.Text = label3.Text + num;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = 1;
            label3.Text = label3.Text + num;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num = 2;
            label3.Text = label3.Text + num;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num = 3;
            label3.Text = label3.Text + num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = 4;
            label3.Text = label3.Text + num;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num = 5;
            label3.Text = label3.Text + num;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num = 6;
            label3.Text = label3.Text + num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = 7;
            label3.Text = label3.Text + num;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = 8;
            label3.Text = label3.Text + num;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num = 9;
            label3.Text = label3.Text + num;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            soma = true;
            sub = false;
            mult = false;
            div = false;
            if (label3.Text != "") {
                memoria = Convert.ToDouble(label3.Text);
                label1.Text = label3.Text + "+";
                label3.Text = "";
            }
            else
            {   
                if (label2.Text == "")
                {
                }
                else
                {
                    label3.Text = label2.Text;
                    memoria = Convert.ToDouble(label3.Text);
                    label1.Text = label3.Text + "+";
                    label3.Text = "";
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            soma = false;
            sub = true;
            mult = false;
            div = false;
            if (label3.Text != "")
            {
                memoria = Convert.ToDouble(label3.Text);
                label1.Text = label3.Text + "-";
                label3.Text = "";
            }
            else
            {
                if (label2.Text == "")
                {
                }
                else
                {
                    label3.Text = label2.Text;
                    memoria = Convert.ToDouble(label3.Text);
                    label1.Text = label3.Text + "-";
                    label3.Text = "";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            soma = false;
            sub = false;
            mult = true;
            div = false;
            if (label3.Text != "")
            {
                memoria = Convert.ToDouble(label3.Text);
                label1.Text = label3.Text + "x";
                label3.Text = "";
            }
            else
            {
                if (label2.Text == "")
                {
                }
                else
                {
                    label3.Text = label2.Text;
                    memoria = Convert.ToDouble(label3.Text);
                    label1.Text = label3.Text + "x";
                    label3.Text = "";
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            soma = false;
            sub = false;
            mult = false;
            div = true;
            if (label3.Text != "")
            {
                memoria = Convert.ToDouble(label3.Text);
                label1.Text = label3.Text + "/";
                label3.Text = "";
            }
            else
            {
                if (label2.Text == "")
                {
                }
                else
                {
                    label3.Text = label2.Text;
                    memoria = Convert.ToDouble(label3.Text);
                    label1.Text = label3.Text + "/";
                    label3.Text = "";
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label3.Text = "";
            label2.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {   if (label3.Text != "")
            {
                if (soma == true)
                {
                    resultado = memoria + Convert.ToDouble(label3.Text);
                    label2.Text = Convert.ToString(resultado);
                    label1.Text = label1.Text + label3.Text;
                    label3.Text = "";
                }
                if (sub == true)
                {
                    resultado = memoria - Convert.ToDouble(label3.Text);
                    label2.Text = Convert.ToString(resultado);
                    label1.Text = label1.Text + label3.Text;
                    label3.Text = "";
                }
                if (mult == true)
                {
                    resultado = memoria * Convert.ToDouble(label3.Text);
                    label2.Text = Convert.ToString(resultado);
                    label1.Text = label1.Text + label3.Text;
                    label3.Text = "";
                }
                if (div == true)
                {
                    resultado = memoria / Convert.ToDouble(label3.Text);
                    label2.Text = Convert.ToString(resultado);
                    label1.Text = label1.Text + label3.Text;
                    label3.Text = "";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + ",";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static double a, rez;
        static string b;

        private void F1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void K1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void C1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void F_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void K_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void C_CheckedChanged(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            b = (textBox1.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(b);
            if ((C.Checked == true))
            {

                if (C1.Checked == true)
                {
                    rez = a;
                }
                if (K1.Checked == true)
                {
                    rez = a + 273.15;
                }
                if (F1.Checked == true)
                {
                    rez = a + ((9 / 5) + 32);
                }

                if (a < -273.15)
                {
                    MessageBox.Show("Некорректный ввод данных");
                    rez = 0;
                }

            }
            if ((K.Checked == true))
            {

                if (C1.Checked == true)
                {
                    rez = a - 273.15;
                }
                if (K1.Checked == true)
                {
                    rez = a;
                }
                if (F1.Checked == true)
                {
                    rez = a - 273.15 + ((9 / 5) + 32);
                }

                if (a < 0)
                {
                    MessageBox.Show("Некорректный ввод данных");
                    rez = 0;
                }
            }
            if ((F.Checked == true))
            {

                if (C1.Checked == true)
                {
                    rez = a - ((9 / 5) + 32);
                }
                if (K1.Checked == true)
                {
                    rez = a + 273.15 - ((9 / 5) + 32);
                }
                if (F1.Checked == true)
                {
                    rez = a;
                }

                if (a < -459.67)
                {
                    MessageBox.Show("Некорректный ввод данных");
                    rez = 0;
                }
            }
            Result.Text = Convert.ToString(rez);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

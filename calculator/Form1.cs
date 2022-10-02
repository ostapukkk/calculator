using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    
    public partial class Form1 : Form
    {
        public String D; // действие

        public String N1; // запомнить число

        public bool n2; //набираем второе число

        public int test_m(int dn1, int dn2)
        {
            return dn1 + dn2;
        }

        public int test_m1(int dn1, int dn2)
        {
            return dn1 - dn2;
        }

        public int test_m2(int dn1, int dn2)
        {
            return dn1 * dn2;
        }

        public int test_m3(int dn1, int dn2)
        {
            return dn1 / dn2;
        }
        public Form1()
        {
            n2 = false;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e) // очистка

        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (n2)
            {

                n2 = false;

                textBox1.Text = "0";

            }

            Button B = (Button)sender;

            if (textBox1.Text == "0")

                textBox1.Text = B.Text;

            else
            textBox1.Text = textBox1.Text + B.Text;
        }

        private void button7_Click(object sender, EventArgs e) // +-*/
        {
            Button B = (Button)sender;

            D = B.Text;

            N1 = textBox1.Text;

            n2 = true;

        }

        private void button2_Click(object sender, EventArgs e) //кнопка равно
        {
            double dn1, dn2, rez;

            rez = 0;

            dn1 = Convert.ToDouble(N1); 
                                              // конвертируем strind в double
            dn2 = Convert.ToDouble(textBox1.Text);

            if (D == "+")
            {
                rez = dn1 + dn2;
            }

            if (D == "-")
            {
                rez = dn1 - dn2;
            }

            if (D == "×")
            {
                rez = dn1 * dn2;
            }

            if (D == "÷")
            {
                rez = dn1 / dn2;
            }
                       
            D = "=";

            n2 = true;

            textBox1.Text = rez.ToString();

        }
    }
}

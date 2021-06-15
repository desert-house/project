using ConvertS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            string s;
            //Console.WriteLine("Введите число: ");
            s = textBox1.Text;
            //Console.WriteLine("Введите изначальную систему счисления числа: ");
            a = Convert.ToInt32(textBox2.Text);
            //Console.WriteLine("Введите систему счисления, в которую надо перевести: ");
            b = Convert.ToInt32(textBox4.Text);
            //Console.WriteLine("Итог: ");
            textBox3.Text = Conv.Toany(a, b, s);
            //Console.ReadLine();
        }
    }
}

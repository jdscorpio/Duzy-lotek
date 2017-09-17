using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Duzy_lotek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://jd.vlo.gda.pl");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random los = new Random();

            int ile, poczatek, koniec;
            try
            {
                ile = Convert.ToInt32(textBox1.Text);
                if (ile <= 0 || ile >= 1000000)
                    MessageBox.Show("Liczba musi być z zakresu: <1;1000000>");

                poczatek = Convert.ToInt32(textBox2.Text);
                koniec = Convert.ToInt32(textBox3.Text);

                for (int i = 1; i <= ile; i++)
                    textBox4.AppendText(los.Next(poczatek, koniec).ToString() + " ");
            }
            catch
            {
                MessageBox.Show("Błąd danych");
            }
        }
    }
}

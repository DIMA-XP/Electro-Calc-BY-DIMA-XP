using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Watt_To_Amper_BY_DIMA_XP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float a = 0;
            float b = 0;
            double c;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            c = (float)a / (double)b;
            textBox3.Text = c.ToString("0.0000000000");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;
            double c;
            a = float.Parse(textBox6.Text);
            b = float.Parse(textBox5.Text);
            c = (float)a * (double)b;
            textBox4.Text = c.ToString("0.0000000000");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length == 0) || (textBox2.Text.Length == 0))
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if ((textBox6.Text.Length == 0) || (textBox5.Text.Length == 0))
                button2.Enabled = false;
            else
                button2.Enabled = true;

        }

    }
}
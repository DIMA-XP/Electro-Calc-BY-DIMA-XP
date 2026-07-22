using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calc_Watt_To_Amper_BY_DIMA_XP
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float a = 0;
            float b = 0;
            double c;
            a = float.Parse(textBox9.Text);
            b = float.Parse(textBox8.Text);
            c = (float)a / (double)b;
            textBox7.Text = c.ToString("0.0000000000");
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if ((textBox9.Text.Length == 0) || (textBox8.Text.Length == 0))
                button5.Enabled = false;
            else
                button5.Enabled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }


        private void textBox8_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();
        }
    }
}

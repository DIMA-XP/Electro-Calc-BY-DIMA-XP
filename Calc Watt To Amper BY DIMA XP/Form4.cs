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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fD0 = 0.0f;
            float fDA = 0.0f;
            float fPi = 3.14f;
            float fdata_0 = 0.0f;
            float fD1 = 0.0f;
            fD0 = float.Parse(textBox1.Text);
            fD1 = fD0 / 2;
            fDA = (fD1 * fD1) * fPi;
            fdata_0 = fDA;
            textBox2.Text = fdata_0.ToString("0.00000");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length == 0))
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
                    }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

      
    }
     
}

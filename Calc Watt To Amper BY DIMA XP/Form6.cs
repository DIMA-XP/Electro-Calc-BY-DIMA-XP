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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 secondForm = new Form7();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();
        }

        int fCountByte = 0;
private void button1_Click(object sender, EventArgs e)
{

float fC_flag = 0.0f;
int[] fC_procentArray = { 13, 45, 155, 400, 900 };//массив с процентами
float fC_out = 0.0f;
fC_flag = float.Parse(textBox1.Text);
//
fC_out = fC_flag + (fC_flag * fC_procentArray[fCountByte] / 100);
//
textBox2.Text = fC_out.ToString("0.00");
}
    



        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void r13_CheckedChanged(object sender, EventArgs e)
        {
            { fCountByte = 0; }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
        }

        private void r45_CheckedChanged(object sender, EventArgs e)
        {
            { fCountByte = 1; }
        }

        private void r155_CheckedChanged(object sender, EventArgs e)
        {
            { fCountByte = 2; }
        }

        private void r400_CheckedChanged(object sender, EventArgs e)
        {
            { fCountByte = 3; }
        }

        private void r900_CheckedChanged(object sender, EventArgs e)
        {
            { fCountByte = 4; }
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
    }
}

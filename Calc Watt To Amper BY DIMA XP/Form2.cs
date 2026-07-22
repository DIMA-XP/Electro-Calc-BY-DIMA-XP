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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();
            Proc.StartInfo.FileName = "http://dimaxp.sytes.net";
            Proc.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();
            Proc.StartInfo.FileName = "www.vk.com/dimaxpvista1328";
            Proc.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дима Попов пидорас! За то что оскорбительно слился и закинул в чс, здесь не будет больше ссылки на его страницу вк!", "Ой что-та пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();
            Proc.StartInfo.FileName = "https://vk.com/hcpp20334";
            Proc.Start(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm3 = new Form1();
            frm3.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();
            Proc.StartInfo.FileName = "https://github.com/HCPP20334";
            Proc.Start(); 
        }
    }
}

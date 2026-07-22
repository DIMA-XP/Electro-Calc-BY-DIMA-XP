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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Считываем данные (заменяем точку на запятую для безопасности)
                double U = double.Parse(textBox1.Text);
                double R = double.Parse(textBox2.Text);

                // 2. Проверка на корректность данных
                if (R <= 0)
                {
                    MessageBox.Show("Сопротивление должно быть больше нуля!", "Ой что-то пошло не так :(");
                    return;
                }

                // 3. Формула мощности: P = U² / R
                double P = (U * U) / R;

                // 4. Вывод результата (в 2013 используем string.Format)
                // {0:F2} ограничивает вывод двумя знаками после запятой
                textBox3.Text = string.Format("{0:F2} Вт", P);

                // Подсказка: если мощность более 1000 Вт, можно вывести и в кВт
                if (P >= 1000)
                {
                    double kW = P / 1000;
                    textBox3.Text += string.Format(" ({0:F2} кВт)", kW);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите числовые значения.", "Ой что-то пошло не так :(");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 secondForm = new Form8();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}

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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Получаем данные из TextBox
                // Используем .Replace(',', '.') для корректной работы с дробными числами
                double uEmpty = double.Parse(textBox1.Text);      // Напряжение без нагрузки
                double uLoaded = double.Parse(textBox2.Text);     // Напряжение под нагрузкой
                double rLoad = double.Parse(textBox3.Text);    // Сопротивление нагрузки

                // 2. Проверка корректности введенных данных
                if (uLoaded >= uEmpty)
                {
                    MessageBox.Show("Напряжение под нагрузкой должно быть меньше холостого хода!", "Ошибка");
                    return;
                }
                if (rLoad <= 0)
                {
                    MessageBox.Show("Сопротивление нагрузки должно быть больше нуля!", "Ошибка");
                    return;
                }

                // 3. Расчет тока, который протекает через нагрузку сейчас
                double iLoad = uLoaded / rLoad;

                // 4. Расчет внутреннего сопротивления сети (петли фаза-ноль)
                // Zs = (U0 - Un) / In
                double zNetwork = (uEmpty - uLoaded) / iLoad;

                // 5. Расчет ожидаемого тока короткого замыкания
                // Isc = U0 / Zs
                double isc = uEmpty / zNetwork;

                // 6. Вывод результата в 4-й TextBox
                textBox4.Text = string.Format("{0:F4}", isc);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, заполните все поля числовыми значениями.", "Ошибка ввода");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

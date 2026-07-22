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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 secondForm = new Form8();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Считывание данных (с заменой точки на запятую)
                double Uin = double.Parse(textBox1.Text.Replace('.', ','));
                double Uout = double.Parse(textBox2.Text.Replace('.', ','));
                double ImA = double.Parse(textBox3.Text.Replace('.', ',')); // Ввод в мА

                // 2. Параметры сети (стандарт 2026 года)
                double Freq = 50.0; // Частота сети 50 Гц
                double I = ImA / 1000.0; // Переводим мА в Амперы

                // 3. Проверка корректности (Uвх должно быть больше Uвых)
                if (Uin <= Uout)
                {
                    MessageBox.Show("Входное напряжение должно быть больше выходного!");
                    return;
                }

                // 4. Расчет емкости в Фарадах
                // Формула: C = I / (2 * pi * f * sqrt(Uin^2 - Uout^2))
                double denominator = 2 * Math.PI * Freq * Math.Sqrt(Math.Pow(Uin, 2) - Math.Pow(Uout, 2));
                double C_farads = I / denominator;

                // 5. Перевод в микрофарады (мкФ)
                double C_mkF = C_farads * 1000000;

                // 6. Вывод результата (совместимо с VS 2013)
                textBox4.Text = string.Format("{0:F3} мкФ", C_mkF);

                // Дополнительная информация по напряжению конденсатора
                // Рабочее напряжение должно быть с запасом (мин 400В для сети 230В)
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите числовые значения.", "Ой что-то пошло не так :(");
            }
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}

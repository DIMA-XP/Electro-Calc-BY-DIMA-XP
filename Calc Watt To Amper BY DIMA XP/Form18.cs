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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Считывание данных с обработкой разделителей
                double U = double.Parse(textBox1.Text.Replace('.', ','));
                double I = double.Parse(textBox2.Text.Replace('.', ','));
                double cosPhi = double.Parse(textBox3.Text.Replace('.', ','));

                // 2. Валидация cos f (не может быть больше 1)
                if (cosPhi > 1 || cosPhi < 0)
                {
                    MessageBox.Show("Коэффициент cos φ должен быть от 0 до 1");
                    return;
                }

                // 3. Расчет мощностей
                // Полная мощность (S)
                double S = U * I;

                // Активная мощность (P)
                double P = S * cosPhi;

                // Реактивная мощность (Q)
                // Сначала находим sin(f). sin² + cos² = 1 => sin = sqrt(1 - cos²)
                double sinPhi = Math.Sqrt(1 - Math.Pow(cosPhi, 2));
                double Q = S * sinPhi;

                // 4. Формирование отчета
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.AppendLine("--- Калькулятор Электрика DIMA XP ---");
                sb.AppendLine("-------------------------------------------");
                sb.AppendFormat("Активная (P): {0:F2} Вт\r\n", P);
                sb.AppendFormat("Реактивная (Q): {0:F3} вар\r\n", Q);
                sb.AppendFormat("Полная (S): {0:F2} ВА\r\n", S);

                // кВт для наглядности
                if (S >= 1000)
                {
                    sb.AppendFormat("\r\nВ килоединицах:\r\n");
                    sb.AppendFormat("P = {0:F3} кВт / Q = {1:F3} квар", P / 1000.0, Q / 1000.0);
                }

                textBox4.Text = sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите корректные числа во все поля.");
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

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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Считывание данных с универсальной обработкой разделителя
                double P = double.Parse(textBox1.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
                double U = double.Parse(textBox2.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
                double n = double.Parse(textBox5.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
                double cosPhi = double.Parse(textBox4.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);

                // Приведение КПД к доле (если ввели например 85 вместо 0.85)
                if (n > 1) n /= 100;

                // 2. Расчет номинального тока двигателя (I)
                // Формула: I = P / (sqrt(3) * U_линейное * n * cosPhi)
                // Но так как мы включаем в однофазную сеть, расчет идет от характеристик двигателя
                double I = P / (Math.Sqrt(3) * 380 * n * cosPhi);

                double cWork = 0;

                // 3. Расчет емкости рабочего конденсатора (Cp)
                if (radioButton1.Checked)
                {
                    // Схема "Звезда": Cp = 2800 * I / U
                    cWork = 2800 * (I / U);
                }
                else
                {
                    // Схема "Треугольник": Cp = 4800 * I / U
                    cWork = 4800 * (I / U);
                }

                // 4. Расчет пусковой емкости (Cп = Cp * 2.5)
                double cStart = cWork * 2.5;

                // 5. Вывод результата (совместимо с C# 2013)
                
                string resultReport = string.Format("Ток двигателя: {0:F2} А\r\n", I);
                resultReport += string.Format("Рабочий конд. (Cp): {0:F1} мкФ\r\n", cWork);
                resultReport += string.Format("Пусковой конд. (Cп): {0:F1} мкФ\r\n", cStart);
                resultReport += "Мин. напряжение конденсаторов: 450 В";

                textBox3.Text = resultReport;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Проверьте, что все поля заполнены числами.", "Ой что-то пошло не так :(");
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

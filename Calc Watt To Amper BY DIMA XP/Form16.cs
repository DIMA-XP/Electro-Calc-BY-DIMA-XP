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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Считывание данных с заменой точки на запятую
                double power = double.Parse(textBox1.Text.Replace('.', ','));
                double tariff = double.Parse(textBox2.Text.Replace('.', ','));
                double minutes = double.Parse(textBox4.Text.Replace('.', ','));

                // 2. Расчет потребления в кВт
                // Делим на 1000, так как мощность в Ваттах, а тариф за Киловатты
                double powerKW = power / 1000.0;

                // 3. Расчет стоимости за 1 час (60 минут)
                double costPerHour = powerKW * tariff;

                // 4. Расчет стоимости за 1 МИНУТУ
                double costPerMinute = costPerHour / 60.0;

                // 5. Расчет итоговой стоимости за введенные минуты
                double totalCost = costPerMinute * minutes;

                // 6. Вывод результатов (используем string.Format для VS 2013)
                // Выводим 4 знака после запятой для минут, так как суммы очень малы
                textBox5.Text = string.Format("{0:F4} руб.", costPerMinute);

                // Итоговая сумма округляется до копеек (2 знака)
                textBox6.Text = string.Format("{0:F2} руб.", totalCost);
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, заполните все поля числовыми значениями!", "Ой что-то пошло не так :(");
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

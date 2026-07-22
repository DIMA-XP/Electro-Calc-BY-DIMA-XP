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
    public partial class Form17 : Form
    {
        public Form17()
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
                // 1. Считывание данных
                double totalArea = double.Parse(textBox1.Text);
                double furnitureArea = double.Parse(textBox2.Text);
                double targetPowerPerM2 = double.Parse(textBox3.Text);
                double linearPower = double.Parse(textBox4.Text);

                // 2. Расчет обогреваемой площади (S_полезная)
                double heatingArea = totalArea - furnitureArea;

                if (heatingArea <= 0)
                {
                    MessageBox.Show("Обогреваемая площадь должна быть больше нуля!");
                    return;
                }

                // 3. Расчет общей необходимой мощности
                double totalPower = heatingArea * targetPowerPerM2;

                // 4. Расчет необходимой длины кабеля (L = P_общая / P_линейная)
                double cableLength = totalPower / linearPower;

                // 5. Расчет шага укладки (в сантиметрах)
                // Формула: (S_полезная * 100) / L_кабеля
                double step = (heatingArea * 100.0) / cableLength;

                // 6. Формирование отчета (совместимо с VS 2013)
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.AppendLine("--- Калькулятор Электрика DIMA XP ---");
                sb.AppendFormat("Площадь обогрева: {0:F2} м2\r\n", heatingArea);
                sb.AppendFormat("Общая мощность: {0:F0} Вт\r\n", totalPower);
                sb.AppendFormat("Нужная длина кабеля: {0:F1} м\r\n", cableLength);
                sb.AppendFormat("Шаг укладки: {0:F1} см\r\n", step);

                textBox5.Text = sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Пожалуйста, введите корректные числа во все поля.", "Ой что-то пошло не так :(");
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

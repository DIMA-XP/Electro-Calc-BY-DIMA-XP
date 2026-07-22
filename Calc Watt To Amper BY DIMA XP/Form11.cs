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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Считывание данных
                double U = double.Parse(textBox1.Text.Replace(',', '.'));
                double P = double.Parse(textBox5.Text.Replace(',', '.'));
                double L = double.Parse(textBox2.Text.Replace(',', '.'));
                double S = double.Parse(textBox3.Text.Replace(',', '.'));
                double T = double.Parse(textBox4.Text.Replace(',', '.'));

                // 2. Удельное сопротивление при +20°C и температурный коэффициент (альфа)
                double rho20 = 0;
                double alpha = 0;

                if (radioButton2.Checked)
                {
                    rho20 = 0.0175; // Медь
                    alpha = 0.00393;
                }
                else
                {
                    rho20 = 0.028;  // Алюминий
                    alpha = 0.00403;
                }

                // 3. Расчет удельного сопротивления при текущей температуре T
                double rhoT = rho20 * (1 + alpha * (T - 20));

                // 4. Расчет тока (считаем cos phi = 1 для упрощения)
                double I = P / U;

                // 5. Расчет потерь напряжения (для однофазной сети)
                double deltaU = (2 * L * rhoT * I) / S;
                double lossPercent = (deltaU / U) * 100;

                // 6. Вывод результата
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.AppendLine("--- Калькулятор Электрика DIMA XP ---");
                sb.AppendLine("-------------------------------------------------------------------------");
                sb.AppendFormat("Сопротивление при {0}°C: {1:F5}\r\n", T, rhoT);
                sb.AppendFormat("Потери напряжения: {0:F2} В\r\n", deltaU);
                sb.AppendFormat("Потери в процентах: {0:F2}%\r\n", lossPercent);

                if (lossPercent > 5)
                {
                    sb.AppendLine("!!! ВНИМАНИЕ: Превышен порог 5% !!!");
                    textBox6.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    textBox6.ForeColor = System.Drawing.Color.DarkGreen;
                }

                textBox6.Text = sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Проверьте числовые значения во всех полях.", "Внимание");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();
        }
    }
}

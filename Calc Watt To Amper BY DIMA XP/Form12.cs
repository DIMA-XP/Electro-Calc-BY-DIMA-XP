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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Считывание данных из TextBox
                double area = double.Parse(textBox1.Text); // Площадь в м.кв
                int rooms = (int)numericUpDown1.Value; // Количество комнат
                int sockets = (int)numericUpDown2.Value; // Количество розеток + ТВ + ПК
                int lights = (int)numericUpDown3.Value;   // люстры
                int switches = (int)numericUpDown4.Value; // выключатели

                bool isElectricPlita = radioButton2.Checked; //Электроплита да/нет
                bool hasCond = checkBox1.Checked; // Проверка чек-бокса Кондиционер Да/Нет

                // 2. Расчет количества автоматов
                // 1 вводной + 1 свет + комнаты (розетки) + плита + кондей + санузел
                int breakers = 1 + 1 + rooms + 1;
                if (isElectricPlita) breakers += 1;
                if (hasCond) breakers += 1;

                // 3. Расчет длины кабеля (Точность ±10%)

                // --- КАБЕЛЬ 3х2.5 (Розетки, ТВ, ПК) ---
                // Базовая магистраль: площадь * 1.2
                // Опуски: количество точек * 2.2 метра (средняя высота от потолка до розетки)
                double cable25 = (area * 1.2) + (sockets * 2.2);

                // --- КАБЕЛЬ 3х1.5 (Свет) ---
                // Магистраль: площадь * 0.8
                // Опуски к выключателям: количество * 1.5 метра
                double cable15 = (area * 0.8) + (switches * 1.5) + (lights * 1.0);

                // --- СПЕЦ. ЛИНИИ ---
                double cable6 = isElectricPlita ? 15.0 : 0; // Прямая линия 3х6 на плиту
                if (hasCond) cable25 += 12.0; // Доп. линия на кондиционер

                // Добавляем технологический запас 10% (зачистка, коробки, повороты)
                cable25 *= 1.1;
                cable15 *= 1.1;

                // 4. Формирование отчета (совместимо с C# 2013)
                System.Text.StringBuilder report = new System.Text.StringBuilder();
                report.AppendLine("--- Калькулятор Электрика DIMA XP ---");
                report.AppendLine("--- ВНИМАНИЯ!!! - BETA Функция!!!! ---");
                report.AppendLine("--- РЕЗУЛЬТАТ МОЖЕТ БЫТЬ НЕ ТОЧЕН!  ---");
                report.AppendLine("--- Перед использованием данных из калькулятора перепроверяйте и уточняйте вручную!!!  ---");
                report.AppendLine("-----------------------------------------------------------------------------");
                report.AppendFormat("Автоматов в щитке: {0} шт.\r\n", breakers);
                report.AppendLine("-----------------------------------------------------------------------------");
                report.AppendLine("НЕОБХОДИМЫЙ КАБЕЛЬ (с запасом 10%):");
                report.AppendFormat("3х2.5 мм2 ГОСТ 31996-2012 (Розетки/Техника): {0:F1} м.\r\n", cable25);
                report.AppendFormat("3х1.5 мм2 ГОСТ 31996-2012 (Освещение): {0:F1} м.\r\n", cable15);

                if (isElectricPlita)
                    report.AppendFormat("Электроплита 3х6.0 мм2 (Силовой): {0:F1} м.\r\n", cable6);
                report.AppendLine("Вводной кабель 3х10 мм2 ВВГ-Нг или ВВГ-ПНг ГОСТ 31996-2012");

                report.AppendLine("-----------------------------------------------------------------------------");
                report.AppendLine("РЕКОМЕНДАЦИИ ПО АВТОМАТИКИ:");
                report.AppendLine("- Автоматы на розетки: 16А (тип B/C)");
                report.AppendLine("- Автоматы на свет: 6-10А (тип B/C)");
                if (isElectricPlita) report.AppendLine("- Автомат на плиту: 32А (тип C)");
                report.AppendLine("- УЗО на мокрые зоны: 25А/30мА тип A/AC");
                report.AppendLine("-----------------------------------------------------------------------------");
                report.AppendLine("Данные актуальны на момент 12.01.2026");

                textBox2.Text = report.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Пожалуйста, проверьте, что все поля заполнены числами.", "Ой что-то пошло не так :(");
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.FormClosed += (s, args) => this.Close(); // Закроет первую форму (и всё приложение) при закрытии второй
            secondForm.Show();
            this.Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

using System.Globalization;

namespace ForAndroid;

public partial class ApartmentCalcPage : ContentPage
{
    private int _rooms = 1;
    private int _sockets = 1;
    private int _lights = 1;
    private int _switches = 1;

    public ApartmentCalcPage()
    {
        InitializeComponent();
        UpdateUI();
    }

    private void UpdateUI()
    {
        LblRooms.Text = _rooms.ToString();
        LblSockets.Text = _sockets.ToString();
        LblLights.Text = _lights.ToString();
        LblSwitches.Text = _switches.ToString();
    }

    private void OnMinusRoomsClicked(object? sender, EventArgs e) { if (_rooms > 1) _rooms--; UpdateUI(); }
    private void OnPlusRoomsClicked(object? sender, EventArgs e) { _rooms++; UpdateUI(); }

    private void OnMinusSocketsClicked(object? sender, EventArgs e) { if (_sockets > 1) _sockets--; UpdateUI(); }
    private void OnPlusSocketsClicked(object? sender, EventArgs e) { _sockets++; UpdateUI(); }

    private void OnMinusLightsClicked(object? sender, EventArgs e) { if (_lights > 1) _lights--; UpdateUI(); }
    private void OnPlusLightsClicked(object? sender, EventArgs e) { _lights++; UpdateUI(); }

    private void OnMinusSwitchesClicked(object? sender, EventArgs e) { if (_switches > 1) _switches--; UpdateUI(); }
    private void OnPlusSwitchesClicked(object? sender, EventArgs e) { _switches++; UpdateUI(); }

    private void OnCalculateClicked(object? sender, EventArgs e)
    {
        try
        {
            double area = double.Parse(EntryArea.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);
            bool isElectricPlita = RadioElectric.IsChecked;
            bool hasCond = CheckCond.IsChecked;

            int breakers = 1 + 1 + _rooms + 1;
            if (isElectricPlita) breakers += 1;
            if (hasCond) breakers += 1;

            double cable25 = (area * 1.2) + (_sockets * 2.2);
            double cable15 = (area * 0.8) + (_switches * 1.5) + (_lights * 1.0);

            double cable6 = isElectricPlita ? 15.0 : 0;
            if (hasCond) cable25 += 12.0;

            cable25 *= 1.1;
            cable15 *= 1.1;

            System.Text.StringBuilder report = new System.Text.StringBuilder();
            report.AppendLine("--- Калькулятор Электрика DIMA XP ---");
            report.AppendLine("--- ВНИМАНИЯ!!! - BETA Функция!!!! ---");
            report.AppendLine("--- РЕЗУЛЬТАТ МОЖЕТ БЫТЬ НЕ ТОЧЕН!  ---");
            report.AppendLine("--- Перед использованием данных перепроверяйте вручную! ---");
            report.AppendLine("-----------------------------------------------------------------------------");
            report.AppendFormat("Автоматов в щитке: {0} шт.\r\n", breakers);
            report.AppendLine("-----------------------------------------------------------------------------");
            report.AppendLine("НЕОБХОДИМЫЙ КАБЕЛЬ (с запасом 10%):");
            report.AppendFormat("3х2.5 мм² ГОСТ 31996-2012 (Розетки/Техника): {0:F1} м.\r\n", cable25);
            report.AppendFormat("3х1.5 мм² ГОСТ 31996-2012 (Освещение): {0:F1} м.\r\n", cable15);

            if (isElectricPlita)
                report.AppendFormat("Электроплита 3х6.0 мм² (Силовой): {0:F1} м.\r\n", cable6);
            report.AppendLine("Вводной кабель 3х10 мм² ВВГ-нг или ВВГ-пнг ГОСТ 31996-2012");

            report.AppendLine("-----------------------------------------------------------------------------");
            report.AppendLine("РЕКОМЕНДАЦИИ ПО АВТОМАТИКЕ:");
            report.AppendLine("- Автоматы на розетки: 16А (тип B/C)");
            report.AppendLine("- Автоматы на свет: 6-10А (тип B/C)");
            if (isElectricPlita) report.AppendLine("- Автомат на плиту: 32А (тип C)");
            report.AppendLine("- УЗО на мокрые зоны: 25А/30мА тип A/AC");
            report.AppendLine("-----------------------------------------------------------------------------");
            report.AppendLine("Данные актуальны на момент 12.01.2026");

            LblResult.Text = report.ToString();
        }
        catch (Exception)
        {
            DisplayAlert("Ой что-то пошло не так :(", "Ошибка! Пожалуйста, проверьте, что все поля заполнены числами.", "OK");
        }
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
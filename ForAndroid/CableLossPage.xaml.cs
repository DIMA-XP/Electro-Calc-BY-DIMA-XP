namespace ForAndroid;

public partial class CableLossPage : ContentPage
{
    public CableLossPage()
    {
        InitializeComponent();
    }

    private void OnCalculateLossClicked(object sender, EventArgs e)
    {
        try
        {
            if (double.TryParse(EntryVoltage.Text?.Replace('.', ','), out double voltage) &&
                double.TryParse(EntryPower.Text?.Replace('.', ','), out double power) &&
                double.TryParse(EntryLength.Text?.Replace('.', ','), out double length) &&
                double.TryParse(EntrySection.Text?.Replace('.', ','), out double section) &&
                double.TryParse(EntryTemp.Text?.Replace('.', ','), out double temp))
            {
                if (section <= 0 || length <= 0 || voltage <= 0)
                {
                    DisplayAlert("Ошибка", "Длина, сечение и напряжение должны быть больше нуля.", "OK");
                    return;
                }

                // Удельное сопротивление при 20 °C (Ом·мм²/м): Алюминий ≈ 0.028, Медь ≈ 0.0175
                bool isAluminum = RbAluminum.IsChecked;
                double rho20 = isAluminum ? 0.028 : 0.0175;

                // Учёт температуры (температурный коэффициент)
                // Для меди и алюминия коэффициент alpha ≈ 0.004 1/°C
                double rho = rho20 * (1 + 0.004 * (temp - 20));

                // Ток в однофазной сети (примерная формула для переменного тока): I = P / (U * cos(phi))
                // Считаем cos(phi) = 1 для простоты (активная нагрузка)
                double current = power / voltage;

                // Сопротивление линии (туда и обратно, умножаем на 2)
                double resistance = (2 * rho * length) / section;

                // Падение напряжения (в Вольтах)
                double voltageDrop = current * resistance;

                // Падение напряжения в процентах
                double percentDrop = (voltageDrop / voltage) * 100;

                EditorResult.Text = $"Падение напряжения: {voltageDrop:F2} В\n" +
                                    $"Потери в процентах: {percentDrop:F2} %\n" +
                                    $"Сопротивление линии: {resistance:F4} Ом";
            }
            else
            {
                DisplayAlert("Ошибка", "Заполните все поля корректными числами.", "OK");
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Ошибка расчёта", ex.Message, "OK");
        }
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
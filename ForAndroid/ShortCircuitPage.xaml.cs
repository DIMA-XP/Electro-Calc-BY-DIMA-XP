namespace ForAndroid;

public partial class ShortCircuitPage : ContentPage
{
    public ShortCircuitPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        try
        {
            // Считываем значения из полей (поддерживаем запятую и точку)
            if (double.TryParse(EntryU0.Text?.Replace('.', ','), out double u0) &&
                double.TryParse(EntryU.Text?.Replace('.', ','), out double u) &&
                double.TryParse(EntryR.Text?.Replace('.', ','), out double r))
            {
                if (r <= 0)
                {
                    DisplayAlert("Ошибка", "Сопротивление должно быть больше нуля.", "OK");
                    return;
                }

                if (u >= u0)
                {
                    DisplayAlert("Ошибка", "Напряжение под нагрузкой должно быть меньше напряжения без нагрузки.", "OK");
                    return;
                }

                // Расчёт внутреннего сопротивления источника и тока КЗ
                // Формула: Iкз = U0 / Rвн, где Rвн = (U0 - U) / (U / R) или аналогичная классическая
                double iKz = u0 / ((u0 - u) / (u / r));

                EntryResult.Text = $"{iKz:F2} А";
            }
            else
            {
                DisplayAlert("Ошибка", "Пожалуйста, введите корректные числовые значения.", "OK");
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
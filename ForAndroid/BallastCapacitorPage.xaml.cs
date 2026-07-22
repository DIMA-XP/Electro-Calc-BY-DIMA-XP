namespace ForAndroid;

public partial class BallastCapacitorPage : ContentPage
{
    public BallastCapacitorPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        try
        {
            if (double.TryParse(EntryUIn.Text?.Replace('.', ','), out double uIn) &&
                double.TryParse(EntryUOut.Text?.Replace('.', ','), out double uOut) &&
                double.TryParse(EntryCurrent.Text?.Replace('.', ','), out double iMa))
            {
                if (uIn <= uOut)
                {
                    DisplayAlert("Ошибка", "Входное напряжение должно быть больше выходного.", "OK");
                    return;
                }

                double iA = iMa / 1000.0; // переводим мА в Амперы
                double f = 50.0; // частота сети 50 Гц

                // Расчёт реактивного сопротивления и емкости (C = I / (2 * pi * f * U_cond))
                // Упрощенная расчетная формула для бестрансформаторного питания
                double uCond = Math.Sqrt(uIn * uIn - uOut * uOut);
                double capacitanceVal = (iA / (2 * Math.PI * f * uCond)) * 1000000; // в мкФ

                EntryResult.Text = $"{capacitanceVal:F2} мкФ";
            }
            else
            {
                DisplayAlert("Ошибка", "Введите корректные числовые значения.", "OK");
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Ошибка", ex.Message, "OK");
        }
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
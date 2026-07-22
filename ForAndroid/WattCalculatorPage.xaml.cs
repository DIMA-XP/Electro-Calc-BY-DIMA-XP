namespace ForAndroid;

public partial class WattCalculatorPage : ContentPage
{
    public WattCalculatorPage()
    {
        InitializeComponent();
    }

    // Перевод Ватт в Амперы (I = P / U)
    private async void OnCalculateAmpsClicked(object? sender, EventArgs e)
    {
        if (double.TryParse(EntryWatts.Text, out double watts) &&
            double.TryParse(EntryVolts1.Text, out double volts) && volts != 0)
        {
            double amps = watts / volts;
            EntryResultAmps.Text = amps.ToString("F2");
        }
        else
        {
            await DisplayAlert("Ошибка", "Введите корректные числа (напряжение не равно 0)", "ОК");
        }
    }

    // Перевод Амперов в Ватты (P = I * U)
    private async void OnCalculateWattsClicked(object? sender, EventArgs e)
    {
        if (double.TryParse(EntryAmps.Text, out double amps) &&
            double.TryParse(EntryVolts2.Text, out double volts))
        {
            double watts = amps * volts;
            EntryResultWatts.Text = watts.ToString("F2");
        }
        else
        {
            await DisplayAlert("Ошибка", "Введите корректные числа", "ОК");
        }
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
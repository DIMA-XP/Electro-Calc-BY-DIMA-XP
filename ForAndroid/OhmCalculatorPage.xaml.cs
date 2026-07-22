namespace ForAndroid;

public partial class OhmCalculatorPage : ContentPage
{
    public OhmCalculatorPage()
    {
        InitializeComponent();
    }

    private async void OnCalculateOhmClicked(object? sender, EventArgs e)
    {
        // I = U / R (Сила тока = Напряжение / Сопротивление)
        if (double.TryParse(EntryVoltage.Text, out double volts) &&
            double.TryParse(EntryResistance.Text, out double resistance) && resistance != 0)
        {
            double amps = volts / resistance;
            EntryOhmResult.Text = amps.ToString("F2") + " A";
        }
        else
        {
            await DisplayAlert("Ошибка", "Введите корректные данные (сопротивление не равно 0)", "ОК");
        }
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
namespace ForAndroid;

public partial class WireCalculatorPage : ContentPage
{
    public WireCalculatorPage()
    {
        InitializeComponent();
    }

    private async void OnCalculateWireClicked(object? sender, EventArgs e)
    {
        if (double.TryParse(EntryDiameter.Text, out double diameter) && diameter >= 0)
        {
            // S = (pi * d^2) / 4
            double crossSection = (Math.PI * Math.Pow(diameter, 2)) / 4;
            EntryWireResult.Text = crossSection.ToString("F2") + " мм²";
        }
        else
        {
            await DisplayAlert("Ошибка", "Введите корректный диаметр", "ОК");
        }
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
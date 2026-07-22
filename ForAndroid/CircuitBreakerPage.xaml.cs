namespace ForAndroid;

public partial class CircuitBreakerPage : ContentPage
{
    public CircuitBreakerPage()
    {
        InitializeComponent();
    }

    private async void OnCalculateBreakerClicked(object? sender, EventArgs e)
    {
        if (double.TryParse(EntryBreaker.Text, out double nominal))
        {
            double multiplier = 1.13; // по умолчанию

            if (Rb113.IsChecked) multiplier = 1.13;
            else if (Rb145.IsChecked) multiplier = 1.45;
            else if (Rb255.IsChecked) multiplier = 2.55;
            else if (Rb5.IsChecked) multiplier = 5.0;
            else if (Rb10.IsChecked) multiplier = 10.0;

            double result = nominal * multiplier;
            EntryBreakerResult.Text = result.ToString("F2") + " А";
        }
        else
        {
            await DisplayAlert("Ошибка", "Введите корректный номинал автомата", "ОК");
        }
    }

    private async void OnGoToCableTableClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new CableTablePage());
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
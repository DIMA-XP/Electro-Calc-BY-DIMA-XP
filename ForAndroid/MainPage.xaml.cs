namespace ForAndroid;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnWattCalculatorClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new WattCalculatorPage());
    }

    private async void OnOhmCalculatorClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new OhmCalculatorPage());
    }

    private async void OnWireCalculatorClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new WireCalculatorPage());
    }

    private async void OnCableTableClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new CableTablePage());
    }

    private async void OnCircuitBreakerClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new CircuitBreakerPage());
    }

    // Переход на страницу «Расчёт тока КЗ»
    private async void OnShortCircuitClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ShortCircuitPage());
    }

    // Переход на страницу «Расчёт потерь на кабеле»
    private async void OnCableLossClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CableLossPage());
    }

    private async void OnHcppFunctionsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HcppFunctionsPage());
    }

    private async void OnRj45Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new Rj45Page());
    }

    private async void OnApartmentCalcClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new ApartmentCalcPage());
    }

    private async void OnAboutClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new AboutPage());
    }

    private void OnExitClicked(object? sender, EventArgs e)
    {
        Environment.Exit(0);
    }
}
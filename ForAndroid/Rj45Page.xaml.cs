namespace ForAndroid;

public partial class Rj45Page : ContentPage
{
    public Rj45Page()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
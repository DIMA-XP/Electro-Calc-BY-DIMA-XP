namespace ForAndroid;

public partial class CableTablePage : ContentPage
{
    public CableTablePage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
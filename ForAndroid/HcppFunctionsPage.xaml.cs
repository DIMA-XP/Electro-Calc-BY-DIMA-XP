namespace ForAndroid;

public partial class HcppFunctionsPage : ContentPage
{
    public HcppFunctionsPage()
    {
        InitializeComponent();
    }

    private async void OnHeaterPowerClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HeaterPowerPage());
    }

    private async void OnPhaseCapacitorClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PhaseCapacitorPage());
    }

    private async void OnBallastCapacitorClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BallastCapacitorPage());
    }

    private async void OnEnergyCostClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EnergyCostPage());
    }

    private async void OnUnderfloorHeatingClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UnderfloorHeatingPage());
    }

    private async void OnPowerByCurrentClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PowerByCurrentPage());
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
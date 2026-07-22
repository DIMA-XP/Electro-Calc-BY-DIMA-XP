namespace ForAndroid;

public partial class HeaterPowerPage : ContentPage
{
    public HeaterPowerPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        try
        {
            if (double.TryParse(EntryVoltage.Text?.Replace('.', ','), out double u) &&
                double.TryParse(EntryResistance.Text?.Replace('.', ','), out double r))
            {
                if (r <= 0)
                {
                    DisplayAlert("Ошибка", "Сопротивление должно быть больше нуля.", "OK");
                    return;
                }

                // Мощность P = U² / R
                double power = (u * u) / r;
                EntryResult.Text = $"{power:F2} Вт";
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
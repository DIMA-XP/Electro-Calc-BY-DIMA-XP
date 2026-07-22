using System.Globalization;

namespace ForAndroid;

public partial class EnergyCostPage : ContentPage
{
    public EnergyCostPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        try
        {
            double power = double.Parse(EntryPower.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);
            double tariff = double.Parse(EntryTariff.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);
            double minutes = double.Parse(EntryMinutes.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);

            if (power < 0 || tariff < 0 || minutes < 0)
            {
                DisplayAlert("Ошибка", "Значения не могут быть отрицательными.", "OK");
                return;
            }

            // Стоимость 1 кВт*ч в минуту = Тариф / 60 (для 1 кВт)
            // Учитывая мощность прибора в Вт: (Мощность / 1000) * (Тариф / 60) за 1 минуту
            double costPerMinute = (power / 1000.0) * (tariff / 60.0);
            double totalCost = costPerMinute * minutes;

            EntryResMin.Text = costPerMinute.ToString("F4", CultureInfo.InvariantCulture);
            EntryResTotal.Text = totalCost.ToString("F2", CultureInfo.InvariantCulture);
        }
        catch (Exception)
        {
            DisplayAlert("Ошибка", "Проверьте корректность введенных данных.", "OK");
        }
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
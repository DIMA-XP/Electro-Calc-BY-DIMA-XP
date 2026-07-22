using System.Globalization;

namespace ForAndroid;

public partial class PowerByCurrentPage : ContentPage
{
    public PowerByCurrentPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object? sender, EventArgs e)
    {
        try
        {
            double u = double.Parse(EntryVoltage.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);
            double i = double.Parse(EntryCurrent.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);
            double cosPhi = double.Parse(EntryCosPhi.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);

            if (u <= 0 || i < 0 || cosPhi <= 0 || cosPhi > 1)
            {
                DisplayAlert("Ошибка", "Проверьте корректность введенных данных (cos φ от 0 до 1).", "OK");
                return;
            }

            // Активная мощность (P) в Вт
            double pActive = u * i * cosPhi;

            // Угол фазы и реактивная мощность (Q) в вар
            double sinPhi = Math.Sin(Math.Acos(cosPhi));
            double qReactive = u * i * sinPhi;

            // Полная мощность (S) в ВА
            double sFull = u * i;

            // В килоединицах
            double pKw = pActive / 1000.0;
            double qKvar = qReactive / 1000.0;

            LblResult.Text = $"--- Калькулятор Электрика DIMA XP ---\n" +
                             $"Активная (P): {pActive:F2} Вт\n" +
                             $"Реактивная (Q): {qReactive:F3} вар\n" +
                             $"Полная (S): {sFull:F2} ВА\n\n" +
                             $"В килоединицах:\n" +
                             $"P = {pKw:F3} кВт / Q = {qKvar:F3} квар";
        }
        catch (Exception)
        {
            DisplayAlert("Ошибка", "Введите корректные числовые значения.", "OK");
        }
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
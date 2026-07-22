using System.Globalization;

namespace ForAndroid;

public partial class UnderfloorHeatingPage : ContentPage
{
    public UnderfloorHeatingPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object? sender, EventArgs e)
    {
        try
        {
            double area = double.Parse(EntryArea.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);
            double offsets = double.Parse(EntryOffsets.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);
            double powerM2 = double.Parse(EntryPowerPerM2.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);
            double step = double.Parse(EntryStep.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);

            double effectiveArea = area - offsets;
            if (effectiveArea < 0) effectiveArea = 0;

            double totalPower = effectiveArea * powerM2;

            // Расчет длины кабеля: Площадь (м2) / (Шаг (см) / 100)
            double cableLength = 0;
            if (step > 0)
            {
                cableLength = effectiveArea / (step / 100.0);
            }

            LblResult.Text = $"--- Калькулятор Электрика DIMA XP ---\n" +
                             $"Площадь обогрева: {effectiveArea:F2} м²\n" +
                             $"Общая мощность: {totalPower:F0} Вт\n" +
                             $"Нужная длина кабеля: {cableLength:F1} м\n" +
                             $"Шаг укладки: {step:F1} см";
        }
        catch (Exception)
        {
            DisplayAlert("Ошибка", "Проверьте правильность введенных чисел.", "OK");
        }
    }

    private async void OnBackClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
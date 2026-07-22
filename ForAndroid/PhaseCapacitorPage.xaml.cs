using System.Globalization;

namespace ForAndroid;

public partial class PhaseCapacitorPage : ContentPage
{
    public PhaseCapacitorPage()
    {
        InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        try
        {
            // 1. Считывание данных с универсальной обработкой разделителей (точка/запятая)
            double p = double.Parse(EntryPower.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);
            double u = double.Parse(EntryVoltage.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);
            double eta = double.Parse(EntryEfficiency.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);
            double cosPhi = double.Parse(EntryCosPhi.Text?.Replace(',', '.') ?? "0", CultureInfo.InvariantCulture);

            if (u <= 0 || cosPhi <= 0 || eta <= 0 || p <= 0)
            {
                DisplayAlert("Ошибка", "Значения должны быть больше нуля.", "OK");
                return;
            }

            // Приведение КПД к доле (если ввели, например, 75 вместо 0.75)
            if (eta > 1)
            {
                eta /= 100.0;
            }

            // 2. Расчет номинального тока двигателя (I) по эталонной формуле
            double i = p / (Math.Sqrt(3) * 380.0 * eta * cosPhi);

            double cWork = 0;

            // 3. Расчет емкости рабочего конденсатора (Cp)
            // RbStar — это radioButton1 (Звезда), RbDelta — треугольник
            if (RbStar.IsChecked)
            {
                // Схема "Звезда"
                cWork = 2800.0 * (i / u);
            }
            else
            {
                // Схема "Треугольник"
                cWork = 4800.0 * (i / u);
            }

            // 4. Расчет пусковой емкости (Cп = Cp * 2.5)
            double cStart = cWork * 2.5;

            // 5. Вывод результата
            LblResult.Text = $"Ток двигателя: {i:F2} А\n" +
                             $"Рабочий конд. (Cp): {cWork:F1} мкФ\n" +
                             $"Пусковой конд. (Cп): {cStart:F1} мкФ\n" +
                             $"Мин. напряжение конденсаторов: 450 В";
        }
        catch (Exception)
        {
            DisplayAlert("Ой что-то пошло не так :(", "Ошибка! Проверьте, что все поля заполнены числами.", "OK");
        }
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
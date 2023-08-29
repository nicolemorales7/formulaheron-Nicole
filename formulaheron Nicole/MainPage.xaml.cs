namespace formulaheron_Nicole;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }


    private void CalcularButton_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(LadoAEntry.Text, out double ladoA) &&
            double.TryParse(LadoBEntry.Text, out double ladoB) &&
            double.TryParse(LadoCEntry.Text, out double ladoC))
        {
            double semiperimetro = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

            ResultadoLabel.Text = $"Área: {area:F2}";
        }
        else
        {
            ResultadoLabel.Text = "Ingrese longitudes válidas para los lados.";
        }
    }
}



    


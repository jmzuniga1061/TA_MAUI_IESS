namespace Zuniga.Views;

public partial class IessPage : ContentPage
{
    public IessPage()
    {
        InitializeComponent();
    }

    private async void CalcularAporteButton_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NombreEntry.Text))
        {
            await DisplayAlert(
                "Dato requerido",
                "Ingresa tu nombre.",
                "Aceptar");

            return;
        }

        if (string.IsNullOrWhiteSpace(ApellidoEntry.Text))
        {
            await DisplayAlert(
                "Dato requerido",
                "Ingresa tu apellido.",
                "Aceptar");

            return;
        }

        if (string.IsNullOrWhiteSpace(EdadEntry.Text))
        {
            await DisplayAlert(
                "Dato requerido",
                "Ingresa tu edad.",
                "Aceptar");

            return;
        }

        if (!int.TryParse(EdadEntry.Text, out int edad))
        {
            await DisplayAlert(
                "Edad no válida",
                "La edad debe ser un número entero.",
                "Aceptar");

            return;
        }

        if (edad <= 0 || edad > 120)
        {
            await DisplayAlert(
                "Edad no válida",
                "La edad debe ser mayor que 0 y menor o igual a 120 años.",
                "Aceptar");

            return;
        }

        if (string.IsNullOrWhiteSpace(SalarioEntry.Text))
        {
            await DisplayAlert(
                "Dato requerido",
                "Ingresa tu salario.",
                "Aceptar");

            return;
        }

        if (!decimal.TryParse(SalarioEntry.Text, out decimal salario))
        {
            await DisplayAlert(
                "Salario no válido",
                "El salario debe ser un valor numérico.",
                "Aceptar");

            return;
        }

        if (salario <= 0)
        {
            await DisplayAlert(
                "Salario no válido",
                "El salario debe ser mayor que 0.",
                "Aceptar");

            return;
        }

        decimal aporte = salario * 0.0945m;

        string mensaje =
            $"Bienvenido {NombreEntry.Text} {ApellidoEntry.Text}\n" +
            $"Tienes {edad} años\n" +
            $"Tu aporte mensual es ${aporte:F2}";

        await DisplayAlert(
            "Resultado",
            mensaje,
            "Aceptar");
    }
}
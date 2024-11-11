using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class CapaHospedagem : ContentPage
    {
        public CapaHospedagem()
        {
            InitializeComponent();
        }

        // Evento para o botão "Avançar"
        private async void OnNextButtonClicked(object sender, EventArgs e)
        {
            // Navega para a próxima página
            await Navigation.PushAsync(new ProximaPagina());
        }
    }

    internal class ProximaPagina : Page
    {
    }
}

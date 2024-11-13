using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class CapaHospedagem : ContentPage
    {
        public CapaHospedagem()
        {
            InitializeComponent();
        }

        // Evento para o bot�o "Avan�ar"
        private async void OnNextButtonClicked(object sender, EventArgs e)
        {
            // Navega para a pr�xima p�gina
            await Navigation.PushAsync(new ProximaPagina());
        }
    }

    internal class ProximaPagina : Page
    {
    }
}
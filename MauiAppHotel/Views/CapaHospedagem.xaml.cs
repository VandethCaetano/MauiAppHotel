using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class CapaHospedagem : ContentPage
    {
        public CapaHospedagem()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContratacaoHospedagem());
        }
    }
}

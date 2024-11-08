namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

		

		dtpck_checking.MinimumDate = DateTime.Now;
        dtpck_checking.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_checkout.MinimumDate = dtpck_checking.Date.AddDays(1);
		dtpck_checkout.MaximumDate = dtpck_checking.Date.AddMonths(6);

    }

	private void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Navigation.PushAsync(new HospedagemContratada());
		}
		catch (Exception ex)

		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
	}
	private void dtpck_cheking_DateSelected(object sender, DateChangedEventArgs e)
	{
		DatePicker elemento = sender as DatePicker;

		DateTime date_selecionada_cheking = elemento.Date;

		dtpck_checkout.MinimumDate = date_selecionada_cheking.AddDays(1);
		dtpck_checkout.MaximumDate= date_selecionada_cheking.AddMonths(6);
	}

}
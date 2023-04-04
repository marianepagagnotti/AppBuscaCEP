using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppBuscaCEP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BairrosPorCidade(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new BairrosPorCidade());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void CepPorLogradouro(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new CepPorLogradouro());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void CidadePorUf(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new CidadePorUf());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void EnderecoPorCep(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new EnderecoPorCep());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void EnderecoPorBairroECidade(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new EnderecoPorBairroECidade());
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
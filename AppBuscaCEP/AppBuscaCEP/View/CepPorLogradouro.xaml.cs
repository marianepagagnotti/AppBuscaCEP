using AppBuscaCEP.Model;
using AppBuscaCEP.Service;
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
    public partial class CepPorLogradouro : ContentPage
    {
        public CepPorLogradouro()
        {
            InitializeComponent();
        }

        private async void Buscar(object sender, EventArgs e)
        {
            try
            {
                carregando.IsRunning= true;

                List<Logradouro> arr_cep = await DataService.GetCepByLogradouro(txt_logradouro.Text);

                lst_ceps.ItemsSource= arr_cep;
            
            }catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
            finally
            {
                carregando.IsRunning= false;
            }
        }
    }
}
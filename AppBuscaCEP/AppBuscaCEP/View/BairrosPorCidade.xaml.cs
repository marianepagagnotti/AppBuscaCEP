using AppBuscaCEP.Model;
using AppBuscaCEP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBuscaCEP.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuscaCEP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BairrosPorCidade : ContentPage
    {
        public BairrosPorCidade()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                carregando.IsRunning = true;

                //List<Bairro> arr_bairros = await DataService.GetBairrosByIdCidade(txt_cidades.Text);

                //lst_bairros.ItemsSource = arr_bairros;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
            finally
            {
                carregando.IsRunning = false;
            }
        }
    }
}
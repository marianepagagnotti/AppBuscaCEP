﻿using AppBuscaCEP.Model;
using AppBuscaCEP.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuscaCEP.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CidadePorUf : ContentPage
    {
        ObservableCollection<Cidade> obs_cidade = new ObservableCollection<Cidade>();
        public CidadePorUf()
        {
            InitializeComponent();

            lst_cidade.ItemsSource = obs_cidade;
        }

        private async void pck_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Picker disparador = (Picker)sender;

                string uf = disparador.SelectedItem as string;

                List<Cidade> lista_cidade = await DataService.GetCidadeByUF(uf);

                obs_cidade.Clear();

                lista_cidade.ForEach(i => obs_cidade.Add(i));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "Ok");
            }
        }
    }
}
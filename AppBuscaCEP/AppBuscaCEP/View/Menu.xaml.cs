﻿using System;
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

        private void Button_Clicked(object sender, EventArgs e)
        {
            
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
    }
}
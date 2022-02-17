using ProiectMediiDeProgramare.Interfata_Client;
using ProiectMediiDeProgramare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProiectMediiDeProgramare
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipala : ContentPage
    {
        public PaginaPrincipala()
        {
            InitializeComponent();
        }

        private async void listViewDepartamente_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new AfiseazaServiciu
                {
                    BindingContext = e.SelectedItem as Departament
                });
            }
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listViewDepartamente.ItemsSource = await App.Database.GetDepartamenteAsync();
        }
    }
}
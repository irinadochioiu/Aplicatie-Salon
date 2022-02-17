using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProiectMediiDeProgramare.Models;
using ProiectMediiDeProgramare.Data;
using ProiectMediiDeProgramare.Administrator.F_Angajat;

namespace ProiectMediiDeProgramare
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Angajat_crud : ContentPage
    {
        public Angajat_crud()
        {
            InitializeComponent();
        }

        private async void btnAdaugaAngajat_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Adauga_angajat
            {
                BindingContext = new Angajat()
            });
        }

        private async void listViewAngajati_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                await Navigation.PushAsync(new Editeaza_Angajat
                {
                    BindingContext = e.SelectedItem as Angajat
                });
            }
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listViewAngajati.ItemsSource = await App.Database.GetAngajatiAsync();
        }
    }
}
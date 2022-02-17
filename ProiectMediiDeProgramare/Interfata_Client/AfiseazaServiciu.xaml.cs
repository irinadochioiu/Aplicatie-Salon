using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProiectMediiDeProgramare.Data;
using ProiectMediiDeProgramare.Models;


namespace ProiectMediiDeProgramare.Interfata_Client
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AfiseazaServiciu : ContentPage
    {
        public AfiseazaServiciu()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var dep = (Departament)BindingContext;
            listViewAngajati.ItemsSource = await App.Database.getDepartamentAngajatiAsync(dep.Id);
        }

        private async void listViewAngajati_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new Pagina_Programare
                {
                    BindingContext = e.SelectedItem as Angajat
                });
            }
        }
    }
}
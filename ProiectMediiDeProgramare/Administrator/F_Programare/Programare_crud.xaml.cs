using ProiectMediiDeProgramare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProiectMediiDeProgramare.Administrator.F_Programare
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Programare_crud : ContentPage
    {
        public Programare_crud()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listViewProgramari.ItemsSource = await App.Database.GetProgramariAsync();
        }

        private async void listViewProgramari_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new Vizualizeaza_Programare
                {
                    BindingContext = e.SelectedItem as Programare
                });
            }
        }
    }
}
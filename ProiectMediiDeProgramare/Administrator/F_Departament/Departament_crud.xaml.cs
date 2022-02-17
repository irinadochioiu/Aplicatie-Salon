using ProiectMediiDeProgramare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProiectMediiDeProgramare.Administrator.F_Departament
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Departament_crud : ContentPage
    {
        public Departament_crud()
        {
            InitializeComponent();
        }

        private async void btnAdaugaDepartament_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Adauga_departament
            {
                BindingContext = new Departament()
            });
        }

        private async void listViewDepartamente_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new Editeaza_departament
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
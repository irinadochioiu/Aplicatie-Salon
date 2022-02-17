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
    public partial class Adauga_departament : ContentPage
    {
        public Adauga_departament()
        {
            InitializeComponent();
        }

        private async void btnAdaugaDepartament_Clicked(object sender, EventArgs e)
        {
            var dep = (Departament)BindingContext;
            
            await App.Database.SaveDepartamentAsync(dep);
            await DisplayAlert("Succes", "Datele departamentului au fost introduse.", "OK");
            await Navigation.PopAsync();
        }
    }
}
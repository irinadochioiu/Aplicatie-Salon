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
    public partial class Editeaza_departament : ContentPage
    {
        public Editeaza_departament()
        {
            InitializeComponent();
        }

        private async void btnStergeDepartament_Clicked(object sender, EventArgs e)
        {
            bool ans = await DisplayAlert("Atentie", "Sunteti sigur ca doriti sa stergeti acest departament?", "Da", "Nu");
            if (ans)
            {
                var dep = (Departament)BindingContext;
                await App.Database.DeleteDepartamentAync(dep);
                await Navigation.PopAsync();
            }
            else
            {
                return;
            }
        }

        private async void btnSalveazaDepartament_Clicked(object sender, EventArgs e)
        {
            var dep = (Departament)BindingContext;
            await App.Database.SaveDepartamentAsync(dep);
            await DisplayAlert("Succes", "Detaliile departamentului au fost actualizate.", "OK");
            await Navigation.PopAsync();
        }
        
    }
}
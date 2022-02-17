using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProiectMediiDeProgramare.Administrator.F_Departament;
using ProiectMediiDeProgramare.Administrator.F_Programare;

namespace ProiectMediiDeProgramare.Administrator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipala_Admin : ContentPage
    {
        public PaginaPrincipala_Admin()
        {
            InitializeComponent();
        }
        private async void btnAngajati_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Angajat_crud());
        }

        private async void btnDepartamente_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Departament_crud());
        }

        private async void btnProgramari_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Programare_crud());
        }
    }
}
using ProiectMediiDeProgramare.Administrator;
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
    public partial class PaginaPornire : ContentPage
    {
        public PaginaPornire()
        {
            InitializeComponent();
        }

        private async void btnAdmin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaPrincipala_Admin());
        }

        private async void btnClient_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaPrincipala());
        }
    }
}
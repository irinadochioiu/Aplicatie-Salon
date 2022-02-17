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
    public partial class Vizualizeaza_Programare : ContentPage
    {
        public Vizualizeaza_Programare()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var pr = (Programare)BindingContext;
            Angajat ang = new Angajat();
            Client cl = new Client();
            ang = await App.Database.GetAngajatAsync(pr.AngajatId);
            cl = await App.Database.GetClientAsync(pr.ClientId);
            lblNumeAngajat.Text = ang.Nume;
            lblPrenumeAngajat.Text = ang.Prenume;
            lblNumeClient.Text = cl.Nume;
            lblPrenumeClient.Text = cl.Prenume;
        }

        private async void btnSterge_Clicked(object sender, EventArgs e)
        {
            bool ans = await DisplayAlert("Atentie", "Sunteti sigur ca doriti sa stergeti aceasta programare?", "Da", "Nu");
            if (ans)
            {
                var pr = (Programare)BindingContext;
                await App.Database.DeleteProgramariAync(pr);
                await Navigation.PopAsync();
            }
            else
            {
                return;
            }
        }
    }
}
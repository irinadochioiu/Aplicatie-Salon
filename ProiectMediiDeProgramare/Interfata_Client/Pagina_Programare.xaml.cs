using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProiectMediiDeProgramare.Models;
using ProiectMediiDeProgramare.Data;

namespace ProiectMediiDeProgramare.Interfata_Client
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina_Programare : ContentPage
    {
        public Pagina_Programare()
        {
            InitializeComponent();
        }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
            var ang = (Angajat)BindingContext;
            List<int> Ore = new List<int>();
            for (int i = ang.OraInceput; i < ang.OraSfarsit; i++)
            {
                Ore.Add(i);
            }
            picker.ItemsSource = Ore;
            Departament dep = new Departament();
            dep = await App.Database.GetDepartamentAsync(ang.DepartamentId);
            lblServiciu.Text = dep.Denumire;
            DateTime date = DateTime.Now;
            date = DateTime.Now;
            datePicker.MinimumDate = date;

        }

        private async void btnSalveaza_Clicked(object sender, EventArgs e)
        {
            var ang = (Angajat)BindingContext;
            int x = (int)picker.SelectedItem;
            DateTime datetime = new DateTime();
            var date = datetime.Date;
            Client cl = new Client
            {
                Nume = editorClientNume.Text,
                Prenume = editorClientPrenume.Text
            };
            await App.Database.SaveClientAsync(cl);
            Programare pr = new Programare
            {
                Ora = x,
                Date = date,
                ClientId = cl.Id,
                AngajatId = ang.Id
            };
            
            await App.Database.SaveProgramareAsync(pr);
            cl.ListaProgramari = new List<Programare> { pr };
            ang.ListaProgramari = new List<Programare> { pr };
            await DisplayAlert("Succes", "Programarea a fost inregistrata.", "OK");
            await Navigation.PushAsync(new PaginaPrincipala());


        }
    }
}
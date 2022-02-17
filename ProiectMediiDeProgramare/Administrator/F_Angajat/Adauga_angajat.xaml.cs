using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProiectMediiDeProgramare.Models;
using ProiectMediiDeProgramare.Data;

namespace ProiectMediiDeProgramare
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Adauga_angajat : ContentPage
    {
        public Adauga_angajat()
        {
            InitializeComponent();
            
        }
        public List<String> Ore = new List<string>() { "8-12", "9-13", "10-14", "11-15", "12-16", "13-17", "14-18" };
        private async void btnAdaugaAngajat_Clicked(object sender, EventArgs e)
        {
            var ang = (Angajat)BindingContext;
            var x = pickerAngajatDepartament.SelectedItem as Departament;
            ang.DepartamentId = x.Id;
            var p = pickerAngajatInterval.SelectedItem;
            switch(p)
            {
                case "8-12":
                    ang.OraInceput = 8;
                    ang.OraSfarsit = 12;
                    break;
                case "9-13":
                    ang.OraInceput = 9;
                    ang.OraSfarsit = 13;
                    break;
                case "10-14":
                    ang.OraInceput = 10;
                    ang.OraSfarsit = 14;
                    break;
                case "11-15":
                    ang.OraInceput = 11;
                    ang.OraSfarsit = 15;
                    break;
                case "12-16":
                    ang.OraInceput = 12;
                    ang.OraSfarsit = 16;
                    break;
                case "13-17":
                    ang.OraInceput = 13;
                    ang.OraSfarsit = 17;
                    break;
                case "14-18":
                    ang.OraInceput = 14;
                    ang.OraSfarsit = 18;
                    break;
            }
            await App.Database.SaveAngajatAsync(ang);
            await DisplayAlert("Succes", "Datele angajatului au fost introduse.", "OK");
            await Navigation.PopAsync();
            x.ListaAngajati.Add(ang);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            pickerAngajatDepartament.ItemsSource = await App.Database.GetDepartamenteAsync();
            pickerAngajatInterval.ItemsSource = Ore;
        }

        
    }
}
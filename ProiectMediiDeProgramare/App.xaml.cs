using ProiectMediiDeProgramare.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using ProiectMediiDeProgramare.Administrator;

[assembly: ExportFont("Andella.otf", Alias = "Font")]
[assembly: ExportFont("AvenirLTStd-Black.otf", Alias = "Font1")]
[assembly: ExportFont("AvenirLTStd-Book.otf", Alias = "Font2")]
[assembly: ExportFont("AvenirLTStd-Roman.otf", Alias = "Font3")]

namespace ProiectMediiDeProgramare
{
    public partial class App : Application
    {
        static SalonDatabase database;
        public static SalonDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new SalonDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Salon.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PaginaPornire());
            
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}


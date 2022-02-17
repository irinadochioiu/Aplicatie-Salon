using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMediiDeProgramare.Models
{
    public class Departament
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Descriere { get; set; }

        [OneToMany]
        public IList<Angajat> ListaAngajati { get; set; } = new List<Angajat>();
    }
}

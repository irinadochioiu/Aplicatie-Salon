using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ProiectMediiDeProgramare.Models
{
    public class Recenzie
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Scor { get; set; }
        public string Descriere { get; set; }

        [ForeignKey(typeof(Angajat))]
        public int AngajatId { get; set; }

        [ForeignKey(typeof(Client))]
        public int ClientId { get; set; }
    }
}

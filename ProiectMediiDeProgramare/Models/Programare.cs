using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMediiDeProgramare.Models
{
    public class Programare
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } 
        public DateTime Date { get; set; }
        public int Ora { get; set; }

        [ForeignKey(typeof(Angajat))]
        public int AngajatId { get; set; }

        [ForeignKey(typeof(Client))]
        public int ClientId { get; set; }
    }
}

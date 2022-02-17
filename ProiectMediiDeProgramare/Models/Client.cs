using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMediiDeProgramare.Models
{
    public class Client
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }

        [OneToMany]
        public List<Recenzie> ListaRecenzii { get; set; }

        [OneToMany]
        public List<Programare> ListaProgramari { get; set; }
    }
}

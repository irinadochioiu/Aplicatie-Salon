using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ProiectMediiDeProgramare.Models
{
    public class Angajat
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Descriere { get; set; }
        public string Poza { get; set; }
        public int OraInceput { get; set; }
        public int OraSfarsit { get; set; }

        [ForeignKey(typeof(Departament))]
        public int DepartamentId { get; set; }

        [OneToMany]
        public List<Recenzie> ListaRecenzii { get; set; }
        
        [OneToMany]
        public List<Programare> ListaProgramari { get; set; }
    }
}

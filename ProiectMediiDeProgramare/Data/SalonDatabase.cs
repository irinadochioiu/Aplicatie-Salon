using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using ProiectMediiDeProgramare.Models;

namespace ProiectMediiDeProgramare.Data
{
    public class SalonDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public SalonDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Angajat>().Wait();
            _database.CreateTableAsync<Client>().Wait();
            _database.CreateTableAsync<Departament>().Wait();
            _database.CreateTableAsync<Programare>().Wait();
            _database.CreateTableAsync<Recenzie>().Wait();
        }
        public Task<List<Angajat>> GetAngajatiAsync()
        {
            return _database.Table<Angajat>().ToListAsync();
        }
        public Task<Angajat> GetAngajatAsync(int id)
        {
            return _database.Table<Angajat>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveAngajatAsync(Angajat ang)
        {
            if (ang.Id != 0)
            {
                return _database.UpdateAsync(ang);
            }
            else
            {
                return _database.InsertAsync(ang);
            }
        }
        public Task<int> DeleteAngajatAync(Angajat ang)
        {
            return _database.DeleteAsync(ang);
        }


        public Task<List<Departament>> GetDepartamenteAsync()
        {
            return _database.Table<Departament>().ToListAsync();
        }
        public Task<Departament> GetDepartamentAsync(int id)
        {
            return _database.Table<Departament>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveDepartamentAsync(Departament dep)
        {
            if (dep.Id != 0)
            {
                return _database.UpdateAsync(dep);
            }
            else
            {
                return _database.InsertAsync(dep);
            }
        }
        public Task<int> DeleteDepartamentAync(Departament dep)
        {
            return _database.DeleteAsync(dep);
        }
        
        public Task<List<Angajat>> getDepartamentAngajatiAsync(int depid)
        {

            return _database.Table<Angajat>().Where(i => i.DepartamentId == depid).ToListAsync();
        }
        public Task<int> SaveClientAsync(Client cl)
        {
            if (cl.Id != 0)
            {
                return _database.UpdateAsync(cl);
            }
            else
            {
                return _database.InsertAsync(cl);
            }
        }
        public Task<int> SaveProgramareAsync(Programare pr)
        {
            if (pr.Id != 0)
            {
                return _database.UpdateAsync(pr);
            }
            else
            {
                return _database.InsertAsync(pr);
            }
        }
        public Task<List<Programare>> GetProgramariAsync()
        {
            return _database.Table<Programare>().ToListAsync();
        }
        public Task<int> DeleteProgramariAync(Programare pr)
        {
            return _database.DeleteAsync(pr);
        }
        public Task<Client> GetClientAsync(int id)
        {
            return _database.Table<Client>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }
    }
}

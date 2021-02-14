using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class FiliereBLO
    {
        private readonly DataDAO<Filiere> FiliereRepo;
        public FiliereBLO(string dbFolder)
        {
            FiliereRepo = new DataDAO<Filiere>(dbFolder);
        }

        public void AddFiliere(Filiere filiere)
        {
            FiliereRepo.Add(filiere);
        }

        public void DeleteFiliere(Filiere filiere)
        {
            FiliereRepo.Remove(filiere);
        }

        public void EditFiliere(Filiere oldFiliere, Filiere newFiliere)
        {
            FiliereRepo.Set(oldFiliere, newFiliere);
        }

        public IEnumerable<Filiere> GetAllFilieres()
        {
            return FiliereRepo.Find();
        }
        public IEnumerable<Filiere> GetBy(Func<Filiere, bool> predicate)
        {
            return FiliereRepo.Find(predicate);
        }

        public IEnumerable<Filiere> GetByID(string id)
        {
            return FiliereRepo.Find(x => x.ID == id);
        }

        public int CountFiliere()
        {
            return FiliereRepo.CountRepo();
        }


    }
}

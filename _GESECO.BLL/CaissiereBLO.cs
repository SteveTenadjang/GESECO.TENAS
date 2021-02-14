using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class CaissiereBLO
    {
        private readonly DataDAO<Caissiere> CaissiereRepo;
        public CaissiereBLO(string dbFolder)
        {
            CaissiereRepo = new DataDAO<Caissiere>(dbFolder);
        }

        public void AddCaissiere(Caissiere caissiere)
        {
            CaissiereRepo.Add(caissiere);
        }

        public void DeleteCaissiere(Caissiere caissiere)
        {
            CaissiereRepo.Remove(caissiere);
        }

        public void EditCaissiere(Caissiere oldCaissiere, Caissiere newCaissiere)
        {
            CaissiereRepo.Set(oldCaissiere, newCaissiere);
        }

        public IEnumerable<Caissiere> GetAllCaissieres()
        {
            return CaissiereRepo.Find();
        }
        public IEnumerable<Caissiere> GetBy(Func<Caissiere,bool> predicate)
        {
            return CaissiereRepo.Find(predicate);
        }

        public IEnumerable<Caissiere> GetByID(string id)
        {
            return CaissiereRepo.Find(x => x.ID == id);
        }
        public int CountCaissiere()
        {
            return CaissiereRepo.CountRepo();
        }

    }
}

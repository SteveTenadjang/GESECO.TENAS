using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class UniversiteBLO
    {
        private readonly DataDAO<Universite> UniversiteRepo;
        public UniversiteBLO(string dbFolder)
        {
            UniversiteRepo = new DataDAO<Universite>(dbFolder);
        }

        public void AddUniversite(Universite universite)
        {
            UniversiteRepo.Add(universite);
        }

        public void DeleteUniversite(Universite universite)
        {
            UniversiteRepo.Remove(universite);
        }

        public void EditUniversite(Universite oldUniversite, Universite newUniversite)
        {
            UniversiteRepo.Set(oldUniversite, newUniversite);
        }

        public IEnumerable<Universite> GetAllUniversites()
        {
            return UniversiteRepo.Find();
        }
        public IEnumerable<Universite> GetBy(Func<Universite, bool> predicate)
        {
            return UniversiteRepo.Find(predicate);
        }

        public IEnumerable<Universite> GetByID(string abreger)
        {
            return UniversiteRepo.Find(x => x.Abreger == abreger);
        }
    }
}

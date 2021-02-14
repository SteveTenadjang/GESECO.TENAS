using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class SpecialiteBLO
    {
        private readonly DataDAO<Specialite> SpecialiteRepo;
        public SpecialiteBLO(string dbFolder)
        {
            SpecialiteRepo = new DataDAO<Specialite>(dbFolder);
        }

        public void AddSpecialite(Specialite specialite)
        {
            SpecialiteRepo.Add(specialite);
        }

        public void DeleteSpecialite(Specialite specialite)
        {
            SpecialiteRepo.Remove(specialite);
        }

        public void EditSpecialite(Specialite oldSpecialite, Specialite newSpecialite)
        {
            SpecialiteRepo.Set(oldSpecialite, newSpecialite);
        }

        public IEnumerable<Specialite> GetAllSpecialites()
        {
            return SpecialiteRepo.Find();
        }
        public IEnumerable<Specialite> GetBy(Func<Specialite, bool> predicate)
        {
            return SpecialiteRepo.Find(predicate);
        }

        public IEnumerable<Specialite> GetByAbreger(string abrger)
        {
            return SpecialiteRepo.Find(x => x.Abreger == abrger);
        }


    }
}

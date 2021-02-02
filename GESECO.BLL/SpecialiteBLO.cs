using GESECO.BO;
using GESECO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BLL
{
    public class SpecialiteBLO
    {
        readonly DataDAO<Specialite> SpecialiteRepo;
        public SpecialiteBLO(string dbFolder)
        {
            SpecialiteRepo = new DataDAO<Specialite>(dbFolder);
        }

        public void CreateSpecialite(Specialite specialite)
        {
            SpecialiteRepo.Add(specialite);
        }

        public void DeleteSpecialite(Specialite specialite)
        {
            SpecialiteRepo.Remove(specialite);
        }

        public IEnumerable<Specialite> GetAllSpecialite()
        {
            return SpecialiteRepo.Find();
        }
        public IEnumerable<Specialite> GetBy(Func<Specialite, bool> predicate)
        {
            return SpecialiteRepo.Find(predicate);
        }

        public void EditSpecialite(Specialite oldSpecialite, Specialite newSpecialite)
        {
            SpecialiteRepo.Set(oldSpecialite, newSpecialite);
        }

    }
}

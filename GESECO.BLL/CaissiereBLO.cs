using GESECO.BO;
using GESECO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BLL
{
    public class CaissiereBLO
    {
        readonly DataDAO<Caissiere> CaissiereRepo;
        public CaissiereBLO(string dbFolder)
        {
            CaissiereRepo = new DataDAO<Caissiere>(dbFolder);
        }
        public void CreateCaissiere(Caissiere caissiere)
        {
            CaissiereRepo.Add(caissiere);
        }
        public void DeleteCaissiere(Caissiere caissiere)
        {
            CaissiereRepo.Remove(caissiere);
        }
        public IEnumerable<Caissiere> GetAllCaissieres()
        {
            return CaissiereRepo.Find();
        }
        public IEnumerable<Caissiere> GetByEmail(string email)
        {
            return CaissiereRepo.Find(x => x.Email == email);
        }

        public IEnumerable<Caissiere> GetBy(Func<Caissiere, bool> predicate)
        {
            return CaissiereRepo.Find(predicate);
        }
        public void EditCaissiere(Caissiere oldCaissiere, Caissiere newCaissiere)
        {
            CaissiereRepo.Set(oldCaissiere, newCaissiere);
        }
    }
}

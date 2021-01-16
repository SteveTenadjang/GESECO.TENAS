using GESECO.BO;
using GESECO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BLL
{
    public class FiliereBLO
    {
        readonly DataDAO<Filiere> FiliereRepo;
        public FiliereBLO(string dbFolder)
        {
            FiliereRepo = new DataDAO<Filiere>(dbFolder);
        }

        public void CreateFiliere(Filiere filiere)
        {
            FiliereRepo.Add(filiere);
        }

        public void DeleteFiliere(Filiere filiere)
        {
            FiliereRepo.Remove(filiere);
        }

        public IEnumerable<Filiere> GetAllFilieres()
        {
            return FiliereRepo.Find();
        }

        public IEnumerable<Filiere> GetBy(Func<Filiere, bool> predicate)
        {
            return FiliereRepo.Find(predicate);
        }

        public void EditFiliere(Filiere oldFiliere, Filiere newFiliere)
        {
            FiliereRepo.Set(oldFiliere, newFiliere);
        }

    }
}

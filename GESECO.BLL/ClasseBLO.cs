using GESECO.BO;
using GESECO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BLL
{
    public class ClasseBLO
    {
        readonly DataDAO<Classe> ClasseRepo;
        public ClasseBLO(string dbFolder)
        {
            ClasseRepo = new DataDAO<Classe>(dbFolder);
        }

        public void CreateFiliere(Classe classe)
        {
            ClasseRepo.Add(classe);
        }

        public void DeleteClasse(Classe classe)
        {
            ClasseRepo.Remove(classe);
        }

        public IEnumerable<Classe> GetAllClasses()
        {
            return ClasseRepo.Find();
        }

        public IEnumerable<Classe> GetBy(Func<Classe, bool> predicate)
        {
            return ClasseRepo.Find(predicate);
        }

        public void EditClasse(Classe oldClasse, Classe newClasse)
        {
            ClasseRepo.Set(oldClasse, newClasse);
        }

    }
}

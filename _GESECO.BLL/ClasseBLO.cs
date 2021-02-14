using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class ClasseBLO
    {
        private readonly DataDAO<Classe> ClasseRepo;
        public ClasseBLO(string dbFolder)
        {
            ClasseRepo = new DataDAO<Classe>(dbFolder);
        }

        public void AddClasse(Classe classe)
        {
            ClasseRepo.Add(classe);
        }

        public void DeleteClasse(Classe classe)
        {
            ClasseRepo.Remove(classe);
        }

        public void EditClasse(Classe oldClasse, Classe newClasse)
        {
            ClasseRepo.Set(oldClasse, newClasse);
        }

        public IEnumerable<Classe> GetAllClasses()
        {
            return ClasseRepo.Find();
        }
        public IEnumerable<Classe> GetBy(Func<Classe, bool> predicate)
        {
            return ClasseRepo.Find(predicate);
        }

        public IEnumerable<Classe> GetByID(string id)
        {
            return ClasseRepo.Find(x => x.ID == id);
        }

        public int CountClasse()
        {
            return ClasseRepo.CountRepo();
        }
    }
}

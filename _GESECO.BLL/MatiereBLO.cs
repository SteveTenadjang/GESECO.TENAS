using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class MatiereBLO
    {
        private readonly DataDAO<Matiere> MatiereRepo;
        public MatiereBLO(string dbFolder)
        {
            MatiereRepo = new DataDAO<Matiere>(dbFolder);
        }

        public void AddMatiere(Matiere matiere)
        {
            MatiereRepo.Add(matiere);
        }

        public void DeleteMatiere(Matiere matiere)
        {
            MatiereRepo.Remove(matiere);
        }

        public void EditMatiere(Matiere oldMatiere, Matiere newMatiere)
        {
            MatiereRepo.Set(oldMatiere, newMatiere);
        }

        public IEnumerable<Matiere> GetAllMatieres()
        {
            return MatiereRepo.Find();
        }

        public IEnumerable<Matiere> GetBy(Func<Matiere, bool> predicate)
        {
            return MatiereRepo.Find(predicate);
        }

        public IEnumerable<Matiere> GetByCode(string code)
        {
            return MatiereRepo.Find(x => x.Code == code);
        }
        public int CountMatiere()
        {
            return MatiereRepo.CountRepo();
        }

    }
}

using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class EnseignantBLO
    {
        private readonly DataDAO<Enseignant> EnseignantRepo;
        public EnseignantBLO(string dbFolder)
        {
            EnseignantRepo = new DataDAO<Enseignant>(dbFolder);
        }

        public void AddEnseignant(Enseignant enseignant)
        {
            EnseignantRepo.Add(enseignant);
        }

        public void DeleteEnseignant(Enseignant enseignant)
        {
            EnseignantRepo.Remove(enseignant);
        }

        public void EditEnseignant(Enseignant oldEnseignant, Enseignant newEnseignant)
        {
            EnseignantRepo.Set(oldEnseignant, newEnseignant);
        }

        public IEnumerable<Enseignant> GetAllEnseignants()
        {
            return EnseignantRepo.Find();
        }
        public IEnumerable<Enseignant> GetBy(Func<Enseignant, bool> predicate)
        {
            return EnseignantRepo.Find(predicate);
        }

        public IEnumerable<Enseignant> GetByID(string id)
        {
            return EnseignantRepo.Find(x => x.ID == id);
        }

        public int CountEnseignant()
        {
            return EnseignantRepo.CountRepo();
        }


    }
}

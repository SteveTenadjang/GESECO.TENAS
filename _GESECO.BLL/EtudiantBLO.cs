using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class EtudiantBLO
    {
        private readonly DataDAO<Etudiant> EtudiantRepo;
        public EtudiantBLO(string dbFolder)
        {
            EtudiantRepo = new DataDAO<Etudiant>(dbFolder);
        }

        public void AddEtudiant(Etudiant etudiant)
        {
            EtudiantRepo.Add(etudiant);
        }

        public void DeleteEtudiant(Etudiant etudiant)
        {
            EtudiantRepo.Remove(etudiant);
        }

        public void EditEtudiant(Etudiant oldEtudiant, Etudiant newEtudiant)
        {
            EtudiantRepo.Set(oldEtudiant, newEtudiant);
        }

        public IEnumerable<Etudiant> GetAllEtudiants()
        {
            return EtudiantRepo.Find();
        }
        public IEnumerable<Etudiant> GetBy(Func<Etudiant, bool> predicate)
        {
            return EtudiantRepo.Find(predicate);
        }

        public IEnumerable<Etudiant> GetByID(string id)
        {
            return EtudiantRepo.Find(x => x.ID == id);
        }
        public int CountEtudiant()
        {
            return EtudiantRepo.CountRepo();
        }
    }
}

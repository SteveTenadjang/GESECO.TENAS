using GESECO.BO;
using GESECO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BLL
{
    public class EtudiantBLO
    {
        DataDAO<Etudiant> EtudiantRepo;
        public EtudiantBLO(string dbFolder)
        {
            EtudiantRepo = new DataDAO<Etudiant>(dbFolder);
        }
        public void CreateEtudiant(Etudiant etudiant)
        {
            EtudiantRepo.Add(etudiant);
        }
        public void DeleteEtudiant(Etudiant etudiant)
        {
            EtudiantRepo.Remove(etudiant);
        }
        public int CountEtudiant()
        {
            return EtudiantRepo.Count();
        }
        public IEnumerable<Etudiant> GetAllEtudiants()
        {
            return EtudiantRepo.Find();
        }
        public IEnumerable<Etudiant> GetByMatricule(string matricule)
        {
            return EtudiantRepo.Find(x => x.Matricule == matricule);
        }
        public IEnumerable<Etudiant> GetByEmail(string email)
        {
            return EtudiantRepo.Find(x => x.Email == email);
        }

        public IEnumerable<Etudiant> GetBy(Func<Etudiant, bool> predicate)
        {
            return EtudiantRepo.Find(predicate);
        }

        public void EditEtudiant(Etudiant oldEtudiant, Etudiant newEtudiant)
        {
            EtudiantRepo.Set(oldEtudiant, newEtudiant);
        }

    }
}

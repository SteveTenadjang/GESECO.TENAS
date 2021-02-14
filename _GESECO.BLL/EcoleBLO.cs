using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class EcoleBLO
    {
        private readonly DataDAO<Ecole> EcoleRepo;
        public EcoleBLO(string dbFolder)
        {
            EcoleRepo = new DataDAO<Ecole>(dbFolder);
        }

        public void AddEcole(Ecole ecole)
        {
            EcoleRepo.Add(ecole);
        }

        public void DeleteEcole(Ecole ecole)
        {
            EcoleRepo.Remove(ecole);
        }

        public void EditEcole(Ecole oldEcole, Ecole newEcole)
        {
            EcoleRepo.Set(oldEcole, newEcole);
        }

        public IEnumerable<Ecole> GetAllEcoles()
        {
            return EcoleRepo.Find();
        }
        public IEnumerable<Ecole> GetBy(Func<Ecole, bool> predicate)
        {
            return EcoleRepo.Find(predicate);
        }

        public IEnumerable<Ecole> GetByID(string id)
        {
            return EcoleRepo.Find(x => x.ID == id);
        }

        public int CountEcole()
        {
            return EcoleRepo.CountRepo();
        }

    }
}

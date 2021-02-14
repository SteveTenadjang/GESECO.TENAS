using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class PaiementBLO
    {
        private readonly DataDAO<Paiement> PaiementRepo;
        public PaiementBLO(string dbFolder)
        {
            PaiementRepo = new DataDAO<Paiement>(dbFolder);
        }

        public void SavePaiement(Paiement paiement)
        {
            PaiementRepo.Add(paiement);
        }

        public void RemovePaiement(Paiement paiement)
        {
            PaiementRepo.RemoveSave(paiement);
        }

        public void CancelPaiement(Paiement paiement)
        {
            PaiementRepo.Remove(paiement);
        }

        public IEnumerable<Paiement> GetAllPaiements()
        {
            return PaiementRepo.Find();
        }

        public IEnumerable<Paiement> GetBy(Func<Paiement, bool> predicate)
        {
            return PaiementRepo.Find(predicate);
        }
        public int CountPaiement()
        {
            return PaiementRepo.CountRepo();
        }

    }
}

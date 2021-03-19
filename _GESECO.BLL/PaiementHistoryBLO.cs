using _GESECO.BO;
using _GESECO.DAL;
using System;
using System.Collections.Generic;

namespace _GESECO.BLL
{
    public class PaiementHistoryBLO
    {
        private readonly PaiementHistoryDAO PaiementRepo;
        public PaiementHistoryBLO(string dbFolder)
        {
            PaiementRepo = new PaiementHistoryDAO(dbFolder);
        }

        public void SaveToHistory(Paiement paiement)
        {
            PaiementRepo.Add(paiement);
        }

        public IEnumerable<Paiement> GetAllPaiements()
        {
            return PaiementRepo.Find();
        }

        public IEnumerable<Paiement> GetBy(Func<Paiement, bool> predicate)
        {
            return PaiementRepo.Find(predicate);
        }

        public int Counts()
        {
            return PaiementRepo.CountHistory();
        }

    }
}

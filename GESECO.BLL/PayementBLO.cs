using GESECO.BO;
using GESECO.DAL;
using System;
using System.Collections.Generic;

namespace GESECO.BLL
{
    public class PayementBLO
    {
        DataDAO<Payement> PayementRepo;
        public PayementBLO(string dbFolder)
        {
            PayementRepo = new DataDAO<Payement>(dbFolder);
        }

        public void CreatePayement(Payement payement)
        {
            PayementRepo.Add(payement);
        }

        public void DeletePayement(Payement payement)
        {
            PayementRepo.RemoveSave(payement);
            PayementRepo.Remove(payement);
        }

        public IEnumerable<Payement> GetAllPayements()
        {
            return PayementRepo.Find();
        }

    }
}

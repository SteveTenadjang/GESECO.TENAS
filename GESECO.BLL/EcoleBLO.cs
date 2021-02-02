using GESECO.BO;
using GESECO.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BLL
{
    public class EcoleBLO
    { 
        DataDAO<Ecole> EcoleRepo;
        public EcoleBLO(string dbFolder)
        {
            EcoleRepo = new DataDAO<Ecole>(dbFolder);
        }
        public void CreateEcole(Ecole ecole)
        {
            EcoleRepo.Add(ecole);
        }

        public IEnumerable<Ecole> GetAllEcoles()
        {
            return EcoleRepo.Find();
        }

        public IEnumerable<Ecole> GetByNom(string nom)
        {
            return EcoleRepo.Find(x => x.Nom == nom);
        }

        public void EditSchool(Ecole oldEcole, Ecole newEcole)
        {
            EcoleRepo.Set(oldEcole, newEcole);
        }

    }
}

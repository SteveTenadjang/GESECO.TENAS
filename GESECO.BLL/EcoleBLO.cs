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
    { //Todo make Ecole capable of taking many schools
        readonly DataDAO<Ecole> EcoleRepo;
        readonly private string dbFolder;
        public EcoleBLO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            EcoleRepo = new DataDAO<Ecole>(dbFolder);
        }
        public void CreateCEcole(Ecole newCEcole)
        {
            string filename = null;
            if (!string.IsNullOrEmpty(newCEcole.Logo))
            {
                string ext = Path.GetExtension(newCEcole.Logo);
                filename = Guid.NewGuid().ToString() + ext;
                FileInfo fileSource = new FileInfo(@"C:\Users\hp\OneDrive\Pictures\7.png");
                string filePath = Path.Combine(dbFolder, "logo", filename);
                FileInfo fileDest = new FileInfo(filePath);
                if (!fileDest.Directory.Exists)
                    fileDest.Directory.Create();
                fileSource.CopyTo(fileDest.FullName);
            }
            newCEcole.Logo = filename;
            EcoleRepo.Add(newCEcole);

            //if (!string.IsNullOrEmpty(oldCEcole.Logo))
                //File.Delete(oldCEcole.Logo);
        }

        public Ecole GetEcole()
        {
            Ecole ecole = EcoleRepo.Get();
            if (ecole != null)
                if (!string.IsNullOrEmpty(ecole.Logo))
                    ecole.Logo = Path.Combine(dbFolder, "logo", ecole.Logo);
            return ecole;
        }

    }
}

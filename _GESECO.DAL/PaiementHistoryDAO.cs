using _GESECO.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _GESECO.DAL
{
    public class PaiementHistoryDAO
    {
        private static List<Paiement> Paiements;
        private readonly string FILE_NAME = $@"{typeof(Paiement).Name} history.json";
        private readonly string dbFolder;
        private readonly FileInfo file;

        public PaiementHistoryDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;

            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }

            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }

            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    Paiements = JsonConvert.DeserializeObject<List<Paiement>>(json);
                }
            }

            if (Paiements == null)
            {
                Paiements = new List<Paiement>();
            }
        }
        public void Add(Paiement data)
        {
            Paiements.Add(data);
            Save();
        }
        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(Paiements);
                sw.WriteLine(json);
            }
        }

        public IEnumerable<Paiement> Find()
        {
            return new List<Paiement>(Paiements);
        }

        public IEnumerable<Paiement> Find(Func<Paiement, bool> predicate)
        {
            return new List<Paiement>(Paiements.Where(predicate).ToArray());
        }

        public int CountHistory()
        {
            return Paiements.Count();
        }

    }
}

using System.Collections.Generic;

namespace _GESECO.BO
{
    public class Classe
    {
        public string ID { get; set; }
        public string Nom { get; set; }
        public int NbPlace { get; set; }
        public Specialite SpecialiteC { get; set; }
        //public List<Etudiant> etudiants = new List<Etudiant>();

        public Classe()
        {

        }

        public Classe(string id,string nom, int nbPlace)
        {
            ID = id;
            Nom = nom;
            NbPlace = nbPlace;
        }

        public Classe(string id,string nom, int nbPlace, Specialite specialite)
            :this(id,nom,nbPlace)
        {
            SpecialiteC = specialite;
        }
        public Classe(Classe c, Specialite s)
        {
            ID = c.ID;
            Nom = c.Nom;
            NbPlace = c.NbPlace;
            SpecialiteC = s;
        }
        public Classe(Classe c)
        {
            ID = c.ID;
            Nom = c.Nom;
            NbPlace = c.NbPlace;
        }

        public override string ToString()
        {
            return $"{Nom}";
        }

        public override bool Equals(object obj)
        {
            return obj is Classe classe &&
                   ID == classe.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + EqualityComparer<string>.Default.GetHashCode(ID);
        }
    }
}
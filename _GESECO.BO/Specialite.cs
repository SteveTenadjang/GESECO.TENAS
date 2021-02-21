using System;
using System.Collections.Generic;

namespace _GESECO.BO
{
    public class Specialite
    {
        public string ID { get; set; }
        public string Nom { get; set; }
        public string Abreger { get; set; }
        public Filiere FiliereS { get; set; }

        //public List<Classe> classes = new List<Classe>();
        //public List<Matiere> matieres = new List<Matiere>();

        public Specialite()
        {

        }

        public Specialite(string id, string nom, string abreger)
        {
            ID = id;
            Nom = nom;
            Abreger = abreger;
        }
        public Specialite(string id, string nom,string abreger,Filiere filiere)
            :this(id,nom,abreger)
        {
            FiliereS = filiere;
        }

        public Specialite(Specialite specialite)
        {
            ID = specialite.ID;
            Nom = specialite.Nom;
            Abreger = specialite.Abreger;
        }
        public Specialite(Specialite specialite, Filiere filiere)
        {
            ID = specialite.ID;
            Nom = specialite.Nom;
            Abreger = specialite.Abreger;
            FiliereS = filiere;
        }

        public override bool Equals(object obj)
        {
            return obj is Specialite specialite &&
                   ID == specialite.ID;
        }

        public override string ToString()
        {
            return $"{Abreger} - {Nom}";
        }

        public override int GetHashCode()
        {
            return 1213502048 + EqualityComparer<string>.Default.GetHashCode(ID);
        }
    }
}
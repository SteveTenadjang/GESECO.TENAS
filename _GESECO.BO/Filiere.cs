using System;
using System.Collections.Generic;

namespace _GESECO.BO
{
    public class Filiere
    {
        //ToDo create a classe pensionPaie to save a student who paid fees and to know his unpaid fees in etudiantBLO
        public string ID { get; set; }
        public string Nom { get; set; }
        public string Abreger { get; set; }
        public double Pension { get; set; }
        public string Desciption { get; set; }
        public Ecole EcoleF { get; set; }

        //public List<Specialite> specialites = new List<Specialite>();

        public Filiere()
        {

        }

        public Filiere(string iD, string nom, string abreger,double pension, string desciption)
        {
            ID = iD;
            Nom = nom;
            Abreger = abreger;
            Desciption = desciption;
            Pension = pension;
        }

        public Filiere(string iD, string nom, string abreger,double pension, string desciption, Ecole e) 
            : this(iD, nom, abreger, pension,desciption)
        {
            EcoleF = e;
        }

        public Filiere(Filiere filier, Ecole e)
        {
            ID = filier.ID;
            Nom = filier.Nom;
            Abreger = filier.Abreger;
            Pension = filier.Pension;
            Desciption = filier.Desciption;
            EcoleF = e;
        }

        public override bool Equals(object obj)
        {
            return obj is Filiere filier &&
                   ID == filier.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + EqualityComparer<string>.Default.GetHashCode(ID);
        }

        public override string ToString()
        {
            return $"{Abreger} - {Nom}";
        }
    }
}
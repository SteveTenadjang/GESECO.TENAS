using System;
using System.Collections.Generic;

namespace _GESECO.BO
{
    public class Specialite
    {
        public string Nom { get; set; }
        public string Abreger { get; set; }
        public List<Classe> classes = new List<Classe>();
        public List<Matiere> matieres = new List<Matiere>();

        public Specialite()
        {

        }

        public Specialite(string nom, string abreger)
        {
            Nom = nom;
            Abreger = abreger;
        }

        public Specialite(string nom, string abreger, Classe classe)
            : this(nom, abreger)
        {
            classes.Add(classe);
        }
        public Specialite(string nom, string abreger,Matiere matiere)
         : this(nom, abreger)
        {
            matieres.Add(matiere);
        }

        public Specialite(string nom, string abreger, Classe classe,Matiere matiere)
            : this(nom, abreger,classe)
        {
            matieres.Add(matiere);
        }

        public Specialite(Specialite specialite, Classe classe)
        {
            Nom = specialite.Nom;
            Abreger = specialite.Abreger;
            classes.Add(classe);
        }
        public Specialite(Specialite specialite, Matiere matiere)
        {
            Nom = specialite.Nom;
            Abreger = specialite.Abreger;
            matieres.Add(matiere);
        }
        public Specialite(Specialite specialite, Classe classe,Matiere matiere)
        {
            Nom = specialite.Nom;
            Abreger = specialite.Abreger;
            matieres.Add(matiere);
            classes.Add(classe);
        }

        public override bool Equals(object obj)
        {
            return obj is Specialite specialite &&
                   Nom == specialite.Nom &&
                   Abreger == specialite.Abreger;
        }

        public override int GetHashCode()
        {
            int hashCode = -118106876;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Abreger);
            return hashCode;
        }

        public override string ToString()
        {
            Console.WriteLine($"{Abreger} - {Nom}");
            classes.ForEach(e => Console.WriteLine(e.ToString()));
            matieres.ForEach(e => Console.WriteLine(e.ToString()));
            return "";
        }
    }
}
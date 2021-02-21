using System;
using System.Collections.Generic;

namespace _GESECO.BO
{
    public class Enseignant : Personne
    {
        public Matiere MatiereE { get; set; }
        //public List<Matiere> matieres = new List<Matiere>();

        public Enseignant() 
            : base()
        {

        }

        public Enseignant(string iD, string nom, string prenom, string dateNaissance,
            long contact, string lieuNaissance, string sexe, string mDP, string email,
            string adresse, byte[] photo)
            : base(iD, nom, prenom, dateNaissance, contact, lieuNaissance, sexe, mDP, email, adresse, photo)
        {

        }
        public Enseignant(string iD, string nom, string prenom, string dateNaissance,
            long contact, string lieuNaissance, string sexe, string mDP, string email,
            string adresse, byte[] photo,Matiere matiere)
            : base(iD, nom, prenom, dateNaissance, contact, lieuNaissance, sexe, mDP, email, adresse, photo)
        {
            MatiereE = matiere;
        }

        public Enseignant(Enseignant e,Matiere m)
            : base(e.ID,e.Nom,e.Prenom,e.DateNaissance,e.Contact,e.LieuNaissance,e.Sexe,e.MDP,
                  e.Email,e.Adresse,e.Photo)
        {
            MatiereE = m;
        }

        public override bool Equals(object obj)
        {
            return obj is Personne personne &&
                   ID == personne.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + EqualityComparer<string>.Default.GetHashCode(ID);
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom} {DateTime.Now.Year - DateTime.Parse(DateNaissance).Year}Ans";
        }
    }
}
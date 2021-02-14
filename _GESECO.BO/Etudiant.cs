using System;
using System.Collections.Generic;

namespace _GESECO.BO
{
    public class Etudiant : Personne
    {
        public string Specialite { get; set; }

        public Etudiant()
        {

        }

        public Etudiant(string iD, string nom, string prenom, DateTime dateNaissance,
            long contact, string lieuNaissance, string sexe, string mDP, string email,
            string adresse, byte[] photo, string specialite)
            : base(iD, nom, prenom, dateNaissance, contact, lieuNaissance, sexe, mDP, email, adresse, photo)
        {
            Specialite = specialite;
        }

        public Etudiant(Etudiant e)
            : base(e.ID, e.Nom, e.Prenom, e.DateNaissance, e.Contact, e.LieuNaissance, e.Sexe, e.MDP,e.Email, e.Adresse, e.Photo)
        {
            Specialite = e.Specialite;
        }
        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                    ID == etudiant.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + EqualityComparer<string>.Default.GetHashCode(ID);
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom} {DateTime.Now.Year - DateNaissance.Year}Ans";
        }
    }
}

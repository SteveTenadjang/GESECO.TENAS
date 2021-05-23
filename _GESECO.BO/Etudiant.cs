using System;
using System.Collections.Generic;

namespace _GESECO.BO
{
    public class Etudiant : Personne
    {
        public Specialite SpecialiteE { get; set; }
        public List<Matiere> Matieres { get; set; } = new List<Matiere>();

        public Etudiant()
        {

        }

        public Etudiant(string iD, string nom, string prenom, DateTime dateNaissance,
            long contact, string lieuNaissance, string sexe, string email,
            string adresse, byte[] photo, Specialite specialite)
            : base(iD, nom, prenom, dateNaissance, contact, lieuNaissance, sexe, email, adresse, photo)
        {
            SpecialiteE = specialite;
        }

        public Etudiant(Etudiant e)
            : base(e.ID, e.Nom, e.Prenom, e.DateNaissance, e.Contact, e.LieuNaissance, e.Sexe,e.Email, e.Adresse, e.Photo)
        {
            SpecialiteE = e.SpecialiteE;
        }

        public Etudiant(Etudiant e,Matiere matiere)
            : base(e.ID, e.Nom, e.Prenom, e.DateNaissance, e.Contact, e.LieuNaissance, e.Sexe,e.Email, e.Adresse, e.Photo)
        {
            SpecialiteE = e.SpecialiteE;
            Matieres.Add(matiere);
        }

        public Etudiant(string iD, string nom, string prenom, DateTime dateNaissance,
            long contact, string lieuNaissance, string sexe, string email,
            string adresse, byte[] photo, Specialite specialite, Matiere matiere)
            : base(iD, nom, prenom, dateNaissance, contact, lieuNaissance, sexe, email, adresse, photo) 

        {
            SpecialiteE = specialite;
            Matieres.Add(matiere);
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

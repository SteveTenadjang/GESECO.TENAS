using System;
using System.Collections.Generic;

namespace _GESECO.BO
{
    public abstract class Personne
    {
        public string ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string DateNaissance { get; set; }
        public long Contact { get; set; }
        public string LieuNaissance { get; set; }
        public string Sexe { get; set; }
        public string MDP { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public byte[] Photo { get; set; }

        protected Personne()
        {

        }

        protected Personne(string iD, string nom, string prenom, string dateNaissance, 
            long contact, string lieuNaissance, string sexe, string mDP, string email,
            string adresse,byte[] photo)
        {
            ID = iD;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Contact = contact;
            LieuNaissance = lieuNaissance;
            Sexe = sexe;
            MDP = mDP;
            Email = email;
            Adresse = adresse;
            Photo = photo;
        }

        protected Personne(Personne p)
        {
            ID = p.ID;
            Nom = p.Nom;
            Prenom = p.Prenom;
            DateNaissance = p.DateNaissance;
            Contact = p.Contact;
            LieuNaissance = p.LieuNaissance;
            Sexe = p.Sexe;
            MDP = p.MDP;
            Email = p.Email;
            Adresse = p.Adresse;
            Photo = p.Photo;

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
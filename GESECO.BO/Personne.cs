using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BO
{
    abstract public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public long Contact { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public string Sexe { get; set; }

        protected Personne()
        {

        }

        protected Personne(string nom, string prenom, long contact, string adresse, string email,
            byte[] photo, DateTime dateNaissance, string lieuNaissance, string sexe)
        {
            Nom = nom;
            Prenom = prenom;
            Contact = contact;
            Adresse = adresse;
            Email = email;
            Photo = photo;
            DateNaissance = dateNaissance;
            LieuNaissance = lieuNaissance;
            Sexe = sexe;
        }

        protected Personne(Personne p)
        {
            Nom = p.Nom;
            Prenom = p.Prenom;
            Contact = p.Contact;
            Adresse = p.Adresse;
            Email = p.Email;
            Photo = p.Photo;
            DateNaissance = p.DateNaissance;
            LieuNaissance = p.LieuNaissance;
            Sexe = p.Sexe;
        }

    }
}

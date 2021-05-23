using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GESECO.BO
{
    public class Caissiere : Personne
    {
        public DateTime DateEmbauche { get; private set; }

        public Caissiere() : base()
        {

        }

        public Caissiere(string iD, string nom, string prenom, DateTime dateNaissance,
                        long contact, string lieuNaissance, string sexe, string email,
                        string adresse, byte[] photo)
            : base(iD, nom, prenom, dateNaissance, contact, lieuNaissance, sexe, email, adresse, photo)
        {
            DateEmbauche = DateTime.Parse(DateTime.UtcNow.ToShortDateString());
        }

        public Caissiere(Caissiere c)
            : base(c.ID, c.Nom, c.Prenom, c.DateNaissance, c.Contact, c.LieuNaissance, c.Sexe, c.Email, c.Adresse, c.Photo)
        {
            DateEmbauche = c.DateEmbauche;
        }

        public override bool Equals(object obj)
        {
            return obj is Caissiere admin &&
                   base.Equals(obj) &&
                   ID == admin.ID;
        }

        public override int GetHashCode()
        {
            int hashCode = 2082127350;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            return hashCode;
        }

        public override string ToString()
        {
            return $"{Nom} {Prenom} {DateTime.Now.Year - DateNaissance.Year}Ans";
        }

    }
}

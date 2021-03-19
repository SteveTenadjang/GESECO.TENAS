using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GESECO.BO
{
    public class Admin : Personne
    {
        public DateTime DateEmbauche { get; private set; }
        public string Poste { get; set; }

        public Admin() : base()
        {

        }

        public Admin(string iD, string nom, string prenom, DateTime dateNaissance,
                    long contact, string lieuNaissance, string sexe, string mDP, string email,
                    string adresse, byte[] photo, string poste)
            : base(iD, nom, prenom, dateNaissance, contact, lieuNaissance, sexe, mDP, email, adresse, photo)
        {
            DateEmbauche = DateTime.Parse(DateTime.UtcNow.ToShortDateString());
            Poste = poste;
        }

        public Admin(Admin a)
            : base(a.ID, a.Nom, a.Prenom, a.DateNaissance, a.Contact, a.LieuNaissance, a.Sexe, a.MDP, a.Email, a.Adresse, a.Photo)
        {
            DateEmbauche = a.DateEmbauche;
            Poste = a.Poste;
        }

        public override bool Equals(object obj)
        {
            return obj is Admin admin &&
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

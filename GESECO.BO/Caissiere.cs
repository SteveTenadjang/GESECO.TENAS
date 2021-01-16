using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BO
{
    public class Caissiere : Personne
    {
        public DateTime DateEmbauche { get; private set; }
        public Caissiere() : base()
        {

        }
        public Caissiere(string nom, string prenom, long contact, string adresse, string email, byte[] photo, DateTime dateNaissance, string lieuNaissance, string sexe, DateTime dateEmbauche)
            : base(nom, prenom, contact, adresse, email, photo, dateNaissance, lieuNaissance, sexe)
        {
            DateEmbauche = dateEmbauche;
        }

        public Caissiere(string nom, string prenom, long contact, string adresse, string email, byte[] photo, DateTime dateNaissance, string lieuNaissance, string sexe, Caissiere c)
            : base(nom, prenom, contact, adresse, email, photo, dateNaissance, lieuNaissance, sexe)
        {
            DateEmbauche = c.DateEmbauche;
        }

        public override bool Equals(object obj)
        {
            return obj is Caissiere caissiere &&
                   Nom == caissiere.Nom &&
                   Prenom == caissiere.Prenom &&
                   DateEmbauche == caissiere.DateEmbauche;
        }

        public override int GetHashCode()
        {
            int hashCode = -39816054;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenom);
            hashCode = hashCode * -1521134295 + DateEmbauche.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            return $"Nom: {Nom} Prenom: {Prenom} DateEmbauche: {DateEmbauche}";
        }

    }
}

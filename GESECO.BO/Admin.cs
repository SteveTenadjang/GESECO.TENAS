using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BO
{
    public class Admin : Personne
    {
        public string Poste { get; private set; }
        public string PassWord { get; private set; }
        public DateTime DateEmbauche { get; private set; }

        public Admin() : base()
        {

        }

        public Admin(string nom, string prenom, long contact, string adresse, string email, byte[] photo, DateTime dateNaissance, string lieuNaissance, string sexe, string poste, DateTime dateEmbauche,string password)
            : base(nom, prenom, contact, adresse, email, photo, dateNaissance, lieuNaissance, sexe)
        {
            this.Poste = poste;
            this.DateEmbauche = dateEmbauche;
            this.PassWord = password;
        }

        public Admin(string nom, string prenom, long contact, string adresse, string email, byte[] photo, DateTime dateNaissance, string lieuNaissance, string sexe, Admin a)
           : base(nom, prenom, contact, adresse, email, photo, dateNaissance, lieuNaissance, sexe)
        {
            this.Poste = a.Poste;
            this.DateEmbauche = a.DateEmbauche;
            this.PassWord = a.PassWord;

        }

        public override bool Equals(object obj)
        {
            return obj is Admin admin &&
                   Nom == admin.Nom &&
                   Prenom == admin.Prenom &&
                   Poste == admin.Poste &&
                   DateEmbauche == admin.DateEmbauche;
        }

        public override int GetHashCode()
        {
            int hashCode = 861387432;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Poste);
            hashCode = hashCode * -1521134295 + DateEmbauche.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"Nom: {Nom} Prenom: {Prenom} Poste : {Poste} DateEmbauche: {DateEmbauche}";
        }
    }
}

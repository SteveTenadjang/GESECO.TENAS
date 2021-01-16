using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BO
{
    public class Etudiant : Personne
    {
        public string Matricule { get; set; }
        public string FIntituler { get; set; }

        //Todo connect to filiere

        public Etudiant() : base()
        {

        }

        public Etudiant(string nom, string prenom, long contact, string adresse, string email,
            byte[] photo, DateTime dateNaissance, string lieuNaissance, string sexe, string filiere, string matricule)
            : base(nom, prenom, contact, adresse, email, photo, dateNaissance, lieuNaissance, sexe)
        {
            FIntituler = filiere;
            Matricule = matricule;
        }

        public Etudiant(string nom, string prenom, long contact, string adresse, string email,
        byte[] photo, DateTime dateNaissance, string lieuNaissance, string sexe, Etudiant e)
        : base(nom, prenom, contact, adresse, email, photo, dateNaissance, lieuNaissance, sexe)
        {
            FIntituler = e.FIntituler;
            Matricule = e.Matricule;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   base.Equals(obj) &&
                   Matricule == etudiant.Matricule;
        }

        public override int GetHashCode()
        {
            int hashCode = -1095396319;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Matricule);
            return hashCode;
        }

        public override string ToString()
        {
            return $"Nom: {Nom} Prenom: {Prenom} Age: {DateTime.Now.Year - DateNaissance.Year} Contact: {Contact} Email: {Email}";
        }
    }
}

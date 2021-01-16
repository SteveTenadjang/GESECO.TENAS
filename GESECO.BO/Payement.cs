using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BO
{
    public class Payement
    {
        public string Matricule { get; set; }
        public string Filiere { get; set; }
        public double AmountPaid { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Payement()
        {

        }

        public Payement(string matricule,string nom, string prenom, string filiere, double amountPaid)
        {
            Matricule = matricule;
            Filiere = filiere;
            AmountPaid = amountPaid;
            Nom = nom;
            Prenom = prenom;
        }

        public Payement(Payement p)
        {
            Matricule = p.Matricule;
            Filiere = p.Filiere;
            AmountPaid = p.AmountPaid;
            Nom = p.Nom;
            Prenom = p.Prenom;
        }

        public override string ToString()
        {
            return $"Matricule: {Matricule} Nom: {Nom} Prenom: {Prenom} Filiere: {Filiere} Montant: {AmountPaid}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GESECO.BO
{
    public class Paiement
    {
        public string Matricule { get; set; }
        public double AmountPaid { get; set; }
        public string JourPaie { get; private set; }

        public Paiement()
        {
            JourPaie = DateTime.UtcNow.ToShortDateString();
        }

        public Paiement(string matricule, double amountPaid)
        {
            Matricule = matricule;
            AmountPaid = amountPaid;
            JourPaie = DateTime.UtcNow.ToShortDateString();
        }

        public Paiement(Paiement p)
        {
            Matricule = p.Matricule;
            AmountPaid = p.AmountPaid;
            JourPaie = DateTime.UtcNow.ToShortDateString();
        }

        public override string ToString()
        {
            return $"Matricule: {Matricule} Montant: {AmountPaid} Date:{JourPaie}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BO
{
    public class Classe
    {
        public string Intituler { get; set; }
        public int Capacite { get; set; } //Todo arranger la capacite de la classe

        public Classe()
        {

        }

        public Classe(string intituler, int capacite)
        {
            Intituler = intituler;
            Capacite = capacite;
        }

        public Classe(Classe c)
        {
            Intituler = c.Intituler;
            Capacite = c.Capacite;
        }

        public override bool Equals(object obj)
        {
            return obj is Classe classe &&
                   Intituler == classe.Intituler &&
                   Capacite == classe.Capacite;
        }

        public override int GetHashCode()
        {
            int hashCode = -1357155790;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Intituler);
            hashCode = hashCode * -1521134295 + Capacite.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            return $"Intituler: {Intituler} Capacite {Capacite}";
        }

   }
}

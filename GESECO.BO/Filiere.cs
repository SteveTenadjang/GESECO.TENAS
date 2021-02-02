using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BO
{
    public class Filiere
    {
        public string Intituler { get; set; }
        public double Pension { get; set; }

        public Filiere()
        {

        }

        public Filiere(string intituler, double pension)
        {
            Intituler = intituler;
            Pension = pension;
        }

        public Filiere(Filiere f)
        {
            Intituler = f.Intituler;
            Pension = f.Pension;
        }

        public override bool Equals(object obj)
        {
            return obj is Filiere filiere &&
                   Intituler == filiere.Intituler &&
                   Pension == filiere.Pension;
        }

        public override int GetHashCode()
        {
            int hashCode = -1076339314;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Intituler);
            hashCode = hashCode * -1521134295 + Pension.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"Intituler: {Intituler} Pension: {Pension}";
        }
    }
}

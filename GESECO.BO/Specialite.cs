using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BO
{
    public class Specialite
    {
        public string Intituler { get; set; }
        public int Durrer { get; set; }
        public string Diplome { get; set; }

        public Specialite()
        {

        }

        public Specialite(string intituler, int durrer, string diplome)
        {
            Intituler = intituler;
            Durrer = durrer;
            Diplome = diplome;
        }

        public Specialite( Specialite s)
        {
            Intituler = s.Intituler;
            Durrer = s.Durrer;
            Diplome = s.Diplome;
        }

        public override bool Equals(object obj)
        {
            return obj is Specialite specialite &&
                   Intituler == specialite.Intituler;
        }

        public override int GetHashCode()
        {
            return 1287055317 + EqualityComparer<string>.Default.GetHashCode(Intituler);
        }

        public override string ToString()
        {
            return $"Intituler : {Intituler}";
        }
    }
}

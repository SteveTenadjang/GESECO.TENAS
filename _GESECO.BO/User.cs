using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GESECO.BO
{
    public class User
    {
        public string Identifiant { get; set; }
        public string MDP { get; set; }

        public User()
        {

        }

        public User(string identifiant, string mDP)
        {
            Identifiant = identifiant;
            MDP = mDP;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Identifiant == user.Identifiant &&
                   MDP == user.MDP;
        }

        public override int GetHashCode()
        {
            int hashCode = 950377466;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Identifiant);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MDP);
            return hashCode;
        }

    }
}

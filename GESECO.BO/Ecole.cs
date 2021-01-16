using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.BO
{
    public class Ecole
    {
        public string Nom { get; private set; }
        public string Email { get; private set; }
        public long Contact { get; private set; }
        public string Addresse { get; private set; }
        public string Logo { get; set; }

        public Ecole()
        {

        }

        public Ecole(string nom, string email, long contact, string addresse, string logo)
        {
            Nom = nom;
            Email = email;
            Contact = contact;
            Addresse = addresse;
            Logo = logo;
        }

        public Ecole(Ecole e)
        {
            Nom = e.Nom;
            Email = e.Email;
            Contact = e.Contact;
            Addresse = e.Addresse;
            Logo = e.Logo;
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   Nom == ecole.Nom &&
                   Addresse == ecole.Addresse;
        }

        public override int GetHashCode()
        {
            int hashCode = -76779585;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Addresse);
            return hashCode;
        }

        public override string ToString()
        {
            return $"Nom : {Nom} {Addresse}";
        }
    }
}

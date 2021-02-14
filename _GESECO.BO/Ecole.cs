using System;
using System.Collections.Generic;

namespace _GESECO.BO
{
    public class Ecole
    {
        //ToDo add logo
        public string ID { get; set; }
        public string Nom { get; set; }
        public string Abreger { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public long Contact { get; set; }
        public byte[] Logo { get; set; }
        public List<Filiere> filiers = new List<Filiere>();

        public Ecole()
        {

        }
        public Ecole(string id,string nom, string abreger, string email, string adresse, long contact,byte[] logo)
        {
            ID = id;
            Nom = nom;
            Abreger = abreger;
            Email = email;
            Adresse = adresse;
            Contact = contact;
            Logo = logo;
        }

        public Ecole(string id, string nom, string abreger, string email, string adresse, long contact, byte[] logo, Filiere filier)
            : this(id, nom, abreger, email, adresse, contact,logo)
        {
            filiers.Add(filier);
        }
        public Ecole(Ecole ecole, Filiere filier)
        {
            Nom = ecole.Nom;
            Abreger = ecole.Abreger;
            ID = ecole.ID;
            Email = ecole.Email;
            Adresse = ecole.Adresse;
            Contact = ecole.Contact;
            filiers.Add(filier);
        }
        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   Nom == ecole.Nom &&
                   Contact == ecole.Contact;
        }

        public override int GetHashCode()
        {
            int hashCode = -2136868768;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + Contact.GetHashCode();
            return hashCode;
        }
        public void Tostring()
        {
            filiers.ForEach(e => Console.WriteLine(e.ToString()));
            Console.WriteLine($"{Abreger} - {Nom}");
        }

        public override string ToString()
        {
            Console.WriteLine($"{Abreger} - {Nom}");
            filiers.ForEach(e => Console.WriteLine(e.ToString()));
            return "";
        }
    }
}
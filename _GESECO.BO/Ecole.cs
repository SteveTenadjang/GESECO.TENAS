using System;
using System.Collections.Generic;

namespace _GESECO.BO
{
    public class Ecole
    {
        public string ID { get; set; }
        public string Nom { get; set; }
        public string Abreger { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
        public long Contact { get; set; }
        public byte[] Logo { get; set; }
        public Universite UniversiteE { get; set; }

        //public List<Filiere> filiers = new List<Filiere>();

        public Ecole()
        {

        }
        public Ecole(string id, string nom, string abreger, string email, string adresse, long contact, byte[] logo)
        {
            ID = id;
            Nom = nom;
            Abreger = abreger;
            Email = email;
            Adresse = adresse;
            Contact = contact;
            Logo = logo;
        }
        public Ecole(string id, string nom, string abreger, string email, string adresse, long contact, byte[] logo,Universite universite)
            :this(id,nom,abreger,email,adresse,contact,logo)
        {
            UniversiteE = universite;
        }

        public Ecole(Ecole ecole)
        {
            Nom = ecole.Nom;
            Abreger = ecole.Abreger;
            ID = ecole.ID;
            Email = ecole.Email;
            Adresse = ecole.Adresse;
            Contact = ecole.Contact;
            Logo = ecole.Logo;

        }
        public Ecole(Ecole ecole,Universite universite)
        {
            Nom = ecole.Nom;
            Abreger = ecole.Abreger;
            ID = ecole.ID;
            Email = ecole.Email;
            Adresse = ecole.Adresse;
            Contact = ecole.Contact;
            Logo = ecole.Logo;
            UniversiteE = universite;
        }
        public override string ToString()
        {
            return $"{Abreger} - {Nom}";
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   ID == ecole.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + EqualityComparer<string>.Default.GetHashCode(ID);
        }
    }
}
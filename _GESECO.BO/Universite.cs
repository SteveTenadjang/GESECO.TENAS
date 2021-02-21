using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GESECO.BO
{
    public class Universite
    {
        public string ID { get; set; }
        public string Nom { get; set; }
        public string Abreger { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public long Contact { get; set; }
        public byte[] Logo { get; set; }
        //public List<Ecole> ecoles = new List<Ecole>();


        public Universite()
        {

        }

        public Universite(string id,string nom, string abreger,string email, string adresse, long contact,byte[] logo)
        {
            ID = id;
            Nom = nom;
            Abreger = abreger;
            Email = email;
            Adresse = adresse;
            Contact = contact;
            Logo = logo;
        }

        //public Universite(string nom, string abreger,string email, string adresse, long contact,byte[] logo, Ecole ecole) 
        //    : this(nom, abreger,email, adresse, contact,logo)
        //{
        //    ecoles.Add(ecole);
        //}

        public Universite(Universite universite)
        {
            ID = universite.ID;
            Nom = universite.Nom;
            Abreger = universite.Abreger;
            Contact = universite.Contact;
            Email = universite.Email;
            Adresse = universite.Adresse;
            Logo = universite.Logo;
            //ecoles.Add(ecole);
        }

        public override string ToString()
        {
            return $"{Abreger} - {Nom}";
        }

        public override bool Equals(object obj)
        {
            return obj is Universite universite &&
                   ID == universite.ID;
        }

        public override int GetHashCode()
        {
            return 1213502048 + EqualityComparer<string>.Default.GetHashCode(ID);
        }
    }
}

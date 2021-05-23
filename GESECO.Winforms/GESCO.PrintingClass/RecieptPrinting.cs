using _GESECO.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESECO.Winforms.GESCO.PrintingClass
{
    public class RecieptPrinting
    {
        public string ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public string SpecialiteE { get; set; }
        public double AmountPaid { get; set; }
        public double AmountUnpaid { get; set; }



        public string NomS { get; set; }
        public string AbregerS { get; set; }
        public string AdresseS { get; set; }
        public string EmailS { get; set; }
        public long? ContactS { get; set; }
        public byte[] LogoS { get; set; }


        public RecieptPrinting()
        {

        }

        public RecieptPrinting(string iD, string nom, string prenom, long contact, 
            string email, byte[] photo, string specialiteE, double amountPaid,double amountUnpaid)
        {
            ID = iD;
            Nom = nom;
            Prenom = prenom;
            Contact = contact;
            Email = email;
            Photo = photo;
            SpecialiteE = specialiteE;
            AmountPaid = amountPaid;
            AmountUnpaid = amountUnpaid;
        }

        public RecieptPrinting(string iD, string nom, string prenom, long contact, string email,
            byte[] photo, string specialiteE, double amountPaid, double amountUnpaid, string nomS,
            string abregerS, string adresseS, string emailS, long? contactS, byte[] logoS) 
            : this(iD, nom, prenom, contact, email, photo, specialiteE, amountPaid, amountUnpaid)
        {
            NomS = nomS;
            AbregerS = abregerS;
            AdresseS = adresseS;
            EmailS = emailS;
            ContactS = contactS;
            LogoS = logoS;
        }
    }
}

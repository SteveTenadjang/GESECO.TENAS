using System.Collections.Generic;

namespace _GESECO.BO
{
    public class Matiere
    {
        public string Code { get; set; }
        public string Intituler { get; set; }
        public int QuotaHoraire { get; set; }
        public double Note { get; set; }
        public Specialite SpecialiteM { get; set; }
        //public List<Enseignant> enseignants { get; set; }

        public Matiere()
        {

        }

        public Matiere(string code, string intituler, int quotaHoraire,double note)
        {
            Code = code;
            Intituler = intituler;
            QuotaHoraire = quotaHoraire;
            Note = note;
        }

        public Matiere(string code,string intituler, int quotaHoraire,double note,Specialite specialite)
            :this(code,intituler,quotaHoraire,note)
        {
            SpecialiteM = specialite;
        }

        public Matiere(Matiere matiere)
        {
            Code = matiere.Code;
            Intituler = matiere.Intituler;
            QuotaHoraire = matiere.QuotaHoraire;
            Note = matiere.Note;
        }
        public Matiere(Matiere matiere,Specialite specialite)
        {
            Code = matiere.Code;
            Intituler = matiere.Intituler;
            QuotaHoraire = matiere.QuotaHoraire;
            Note = matiere.Note;
            SpecialiteM = specialite;
        }

        public override string ToString()
        {
            return $"Intituler: {Intituler} - Quota Horaire: {QuotaHoraire}";
        }

        public override bool Equals(object obj)
        {
            return obj is Matiere matiere &&
                   Code == matiere.Code;
        }

        public override int GetHashCode()
        {
            return -434485196 + EqualityComparer<string>.Default.GetHashCode(Code);
        }
    }
}
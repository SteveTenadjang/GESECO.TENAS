using System.Collections.Generic;

namespace _GESECO.BO
{
    public class Matiere
    {
        public string Code { get; set; }
        public string Nom { get; set; }
        public int QuotaHoraire { get; set; }
        public double Note { get; set; }
        public List<Enseignant> enseignants { get; set; }

        public Matiere()
        {

        }

        public Matiere(string code, string nom, int quotaHoraire,double note)
        {
            Code = code;
            Nom = nom;
            QuotaHoraire = quotaHoraire;
            Note = note;
        }

        public Matiere(string code,string nom, int quotaHoraire,double note,Enseignant enseignant)
            :this(code,nom,quotaHoraire,note)
        {
            enseignants.Add(enseignant);
        }

        public Matiere(Matiere matiere, Enseignant enseignant)
        {
            Code = matiere.Code;
            Nom = matiere.Nom;
            QuotaHoraire = matiere.QuotaHoraire;
            Note = matiere.Note;
            enseignants.Add(enseignant);
        }

        public override bool Equals(object obj)
        {
            return obj is Matiere matiere &&
                   Code == matiere.Code &&
                   Nom == matiere.Nom &&
                   QuotaHoraire == matiere.QuotaHoraire;
        }

        public override int GetHashCode()
        {
            int hashCode = -929949052;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Code);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + QuotaHoraire.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"\t\t{Nom} - {QuotaHoraire}";
        }
    }
}
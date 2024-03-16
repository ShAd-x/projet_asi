using System.ComponentModel.DataAnnotations;

namespace Projet_ASI.Models
{
    public class Medecin
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }

        [Display(Name = "Date naissance")]
        [DataType(DataType.Date)]
        public DateTime Naissance { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }

        [Display(Name = "Code postal")]
        public string CodePostal { get; set; }

        [Display(Name = "Code RPPS")]
        public string RPPS { get; set; }

        [Display(Name = "Civilite")]
        public Civility Civilite { get; set; }

        public enum Civility
        {
            Monsieur = 0,
            Madame = 1,
            Autre = 2
        }
    }
}

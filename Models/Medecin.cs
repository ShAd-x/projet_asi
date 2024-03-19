using System.ComponentModel.DataAnnotations;

namespace Projet_ASI.Models
{
    public class Medecin
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; }

        [Display(Name = "Date naissance")]
        [DataType(DataType.Date)]
        public DateTime Naissance { get; set; }

        [Required(ErrorMessage = "Le téléphone est obligatoire")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Le numéro de téléphone doit contenir 10 chiffres")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "L'adresse est obligatoire")]
        public string Adresse { get; set; }

        [Display(Name = "Code postal")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Le code postal doit contenir 5 chiffres")]
        public string CodePostal { get; set; }

        [Display(Name = "Code RPPS")]
        [Required(ErrorMessage = "Le code RPPS est obligatoire")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Le code RPPS doit contenir 11 chiffres")]
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

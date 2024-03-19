using System.ComponentModel.DataAnnotations;

namespace Projet_ASI.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; }

        [Display(Name = "Date naissance")]
        [DataType(DataType.Date)]
        public DateTime Naissance { get; set; }

        [Required(ErrorMessage = "L'adresse email est obligatoire")]
        [EmailAddress(ErrorMessage = "Adresse email invalide")]
        public string Email { get; set; }

        [Required(ErrorMessage = "L'adresse est obligatoire")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Le téléphone est obligatoire")]
        public string Telephone { get; set; }

        [Display(Name = "Code postal")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Le code postal doit contenir 5 chiffres")]
        public string CodePostal { get; set; }

        [Display(Name = "Numéro de sécurité sociale")]
        [RegularExpression(@"^\d{13}$", ErrorMessage = "Le numéro de sécurité sociale doit contenir 13 chiffres")]
        public string NumSecu { get; set; }

        [Display(Name = "Civilite")]
        public Civility Civilite { get; set; }

        public enum Civility
        {
            Monsieur = 0,
            Madame = 1,
            Autre = 2
        }

        public int? MedecinId { get; set; }
        public Medecin? Medecin { get; set; }
		public ICollection<Bilan>? Bilan { get; set; }
	}
}


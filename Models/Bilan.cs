using System.ComponentModel.DataAnnotations;

namespace Projet_ASI.Models
{
    public class Bilan
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La date de consultation est obligatoire.")]
        [Display(Name = "Date de la consultation")]
        [DataType(DataType.Date)]
        public DateTime DateConsultation { get; set; }

        [Required(ErrorMessage = "L'heure de consultation est obligatoire.")]
        [Display(Name = "Heure de la consultation")]
        [DataType(DataType.Time)]
        public DateTime HeureConsultation { get; set; }

        [Required(ErrorMessage = "Le motif de consultation est obligatoire.")]
        public string? MotifConsultation { get; set; }

        [Required(ErrorMessage = "La note supplémentaire est obligatoire.")]
        public string? NoteSupplementaire { get; set; }

        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}

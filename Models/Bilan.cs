using System.ComponentModel.DataAnnotations;

namespace Projet_ASI.Models
{
	public class Bilan
	{
		public int Id { get; set; }
		[Required]
		[Display(Name = "Date de la consultation")]
		[DataType(DataType.Date)]
		public DateTime DateConsultation { get; set; }
		[Required]
		[Display(Name = "Heure de la consultation")]
		[DataType(DataType.Time)]
		public DateTime HeureConsultation { get; set; }
		[Required]
		public string? MotifConsultation { get; set; }
		[Required]
		public string? NoteSupplementaire { get; set; }

        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }

	}
}

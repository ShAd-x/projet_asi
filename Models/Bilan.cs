namespace Projet_ASI.Models
{
	public class Bilan
	{
		public int Id { get; set; }
		public int PatientId { get; set; }
		public DateTime DateConsultation { get; set; }
		public DateTime HeureConsultation { get; set; }
		public string? MotifConsultation { get; set; }
		public string? NoteSupplementaire { get; set; }

		public Patient Patient { get; set; }

	}
}

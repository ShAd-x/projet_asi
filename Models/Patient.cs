using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_ASI.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }

        [Display(Name = "Date naissance")]
        [DataType(DataType.Date)]
        public DateTime Naissance { get; set;}
        public string Email { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }

        [Display(Name = "Code postal")]
        public string CodePostal { get; set; }
        
        [Display(Name = "Numéro de sécurité sociale")]
        public string NumSecu { get; set; }

        [Display(Name = "Civilite")]
        public Civility Civilite { get; set; }

        public enum Civility
        {
            Monsieur = 0,
            Madame = 1,
            Autre = 2
        }
		public ICollection<Bilan>? Bilan { get; set; }
	}
}


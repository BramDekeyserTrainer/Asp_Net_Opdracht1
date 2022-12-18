using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Asp_Net_Opdracht1.Models
{
    public class Niveau
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Klassement")]
        public string Klassement { get; set; }

        [Required]
        [Display(Name = "ELO_Punten")]
        public int ELO_Punten { get; set; }
    }
}

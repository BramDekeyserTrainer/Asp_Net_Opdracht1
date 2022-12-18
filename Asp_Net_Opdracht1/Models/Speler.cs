using System.ComponentModel.DataAnnotations;

namespace Asp_Net_Opdracht1.Models
{
    public class Speler
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Club_Id")]
        public int Club_Id { get; set; }

        [Required]
        [Display(Name = "Speler_Voornaam")]
        public string Speler_Voornaam { get; set; }

        [Required]
        [Display(Name = "Speler_Achternaam")]
        public string speler_Achternaam { get; set; }
    }
}

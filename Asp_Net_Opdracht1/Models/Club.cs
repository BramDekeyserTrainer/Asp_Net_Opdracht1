using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Asp_Net_Opdracht1.Models
{
    public class Club
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Club_Naam")]
        public string Club_Naam { get; set; }

        [Required]
        [Display(Name = "Club_Adres")]
        public string Club_Adres { get; set; }

    }
}

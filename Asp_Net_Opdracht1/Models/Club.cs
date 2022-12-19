using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Asp_Net_Opdracht1.Models
{
    /*De klasse 'Club' stelt de databasetabel voor die we gebruiken voor de Clubs.
    Deze clubs worden voorzien van een Id, Club_Naam en Club_Adres*/
    public class Club
    {
        /*Ik heb gescaffold via deze klasse opdat er een Index.cshtml, Edit.cshtml, Details.cshtml, Delete.cshtml en Create.cshtml 
        zou worden gegenereerd voor de onderstaande tabel.
        Zo kan data gemanipuleerd worden binnen deze automatisch gegenereerde pagina's.
        (=CRUD)*/

        /*Met de 'Required' annotatie, stel ik dat dit niet null kan zijn.
         Ik geef een displaynaam aan het element van de tabel.
        We maken van Id een integer (int), aangezien deze een numerieke waarde is.*/
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        /*Met de 'Required' annotatie, stel ik dat dit niet null kan zijn.
         Ik geef een displaynaam aan het element van de tabel.
        We maken van Club_Naam een string, aangezien deze wordt uitgedrukt in platte tekst.*/
        [Required]
        [Display(Name = "Club_Naam")]
        public string Club_Naam { get; set; }

        /*Met de 'Required' annotatie, stel ik dat dit niet null kan zijn.
         Ik geef een displaynaam aan het element van de tabel.
        We maken van Club_Adres een string, aangezien deze wordt uitgedrukt in platte tekst.*/
        [Required]
        [Display(Name = "Club_Adres")]
        public string Club_Adres { get; set; }

    }
}

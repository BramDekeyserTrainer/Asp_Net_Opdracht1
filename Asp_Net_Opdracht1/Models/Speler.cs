using System.ComponentModel.DataAnnotations;

namespace Asp_Net_Opdracht1.Models
{
    /*Ik heb gescaffold via deze klasse opdat er een Index.cshtml, Edit.cshtml, Details.cshtml, Delete.cshtml en Create.cshtml 
    zou worden gegenereerd voor de onderstaande tabel.
    Zo kan data gemanipuleerd worden binnen deze automatisch gegenereerde pagina's.
    (=CRUD)*/

    /*De klasse 'Speler' stelt de databasetabel voor die we gebruiken voor de spelers.
     Deze spelers worden voorzien van een Id, Club_Id, Speler_Voornaam en Speler_Achternaam*/
    public class Speler
    {
        /*Met de 'Required' annotatie, stel ik dat dit niet null kan zijn.
         Ik geef een displaynaam aan het element van de tabel.
        We maken van Id een integer (int), aangezien deze een numerieke waarde is.*/
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        /*Met de 'Required' annotatie, stel ik dat dit niet null kan zijn.
        Ik geef een displaynaam aan het element van de tabel.
        We maken van Club_Id een integer (int), aangezien deze een numerieke waarde is.*/
        [Required]
        [Display(Name = "Club_Id")]
        public int Club_Id { get; set; }

        /*Met de 'Required' annotatie, stel ik dat dit niet null kan zijn.
        Ik geef een displaynaam aan het element van de tabel.
        We maken van Speler_Voornaam een string, aangezien deze wordt uitgedrukt in platte tekst.*/
        [Required]
        [Display(Name = "Speler_Voornaam")]
        public string Speler_Voornaam { get; set; }

        /*Met de 'Required' annotatie, stel ik dat dit niet null kan zijn.
        Ik geef een displaynaam aan het element van de tabel.
        We maken van Speler_Achternaam een string, aangezien deze wordt uitgedrukt in platte tekst.*/
        [Required]
        [Display(Name = "Speler_Achternaam")]
        public string speler_Achternaam { get; set; }
    }
}

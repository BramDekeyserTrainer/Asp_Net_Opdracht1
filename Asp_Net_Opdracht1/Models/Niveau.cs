using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Asp_Net_Opdracht1.Models
{
    /*Ik heb gescaffold via deze klasse opdat er een Index.cshtml, Edit.cshtml, Details.cshtml, Delete.cshtml en Create.cshtml 
    zou worden gegenereerd voor de onderstaande tabel.
    Zo kan data gemanipuleerd worden binnen deze automatisch gegenereerde pagina's.
    (=CRUD)*/

    /*De klasse 'Niveau' stelt de databasetabel voor die we gebruiken voor het niveau van de spelers.
    Deze Niveaus worden voorzien van een Id, Klassement en ELO-Punten.*/
    public class Niveau
    {
        /*Met de 'Required' annotatie, stel ik dat dit niet null kan zijn.
        Ik geef een displaynaam aan het element van de tabel.
        We maken van Id een integer (int), aangezien deze een numerieke waarde is.*/
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        /*Met de 'Required' annotatie, stel ik dat dit niet null kan zijn.
        Ik geef een displaynaam aan het element van de tabel.
        We maken van Klassement een string, aangezien deze wordt uitgedrukt in platte tekst.*/
        [Required]
        [Display(Name = "Klassement")]
        public string Klassement { get; set; }

        /*Met de 'Required' annotatie, stel ik dat dit niet null kan zijn.
        Ik geef een displaynaam aan het element van de tabel.
        We maken van Id een integer (int), aangezien deze een numerieke waarde is.*/
        [Required]
        [Display(Name = "ELO_Punten")]
        public int ELO_Punten { get; set; }
    }
}

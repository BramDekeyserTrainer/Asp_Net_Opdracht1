using Asp_Net_Opdracht1.Data;
using Microsoft.EntityFrameworkCore;

namespace Asp_Net_Opdracht1.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            /*Ik maak gebruik van ApplicationDbContext.
             Ik zet deze in de variabele 'context'.*/
            using (var context = new ApplicationDbContext(
               serviceProvider.GetRequiredService<
                   DbContextOptions<ApplicationDbContext>>())) 
            {

                /*Ik wil zeker zijn dat de database bestaat.
                 EnsureCreated() zorgt ervoor dat deze sowieso is aangemaakt.
                 Op mijn computer blijft men op dit lijntje vasthaken met een 'Error 50'.
                Als ik dit lijntje verwijder, komt deze melding echter eerst bij de eerste if(!context) tevoorschijn.
                Als anderen mijn project openen, kunnen zij echter wel op één of andere manier de site openen, wat ik niet kan.
                Dit maakt het moeilijk om te testen.*/
                context.Database.EnsureCreated();

                // Ik zoek naar spelers.
                if (!context.Speler.Any())
                {
                    /*Binnen de AddRange kan ik spelers aanmaken.*/
                    context.Speler.AddRange(
                        /*Ik maak een nieuwe speler aan.
                         Deze voorzie ik van informatie binnen de onderdelen die ik in de models heb gemaakt.
                        In dit geval is dit Id, Club_Id, Speler_Voornaam en Speler_Achternaam*/
                new Speler
                {
                    Id = 0,
                    Club_Id = 0,
                    Speler_Voornaam = "Bram",
                    speler_Achternaam = "Dekeyser"
                },

                /*Ik maak nog een nieuwe speler aan.*/
                new Speler
                {
                    Id = 1,
                    Club_Id = 1,
                    Speler_Voornaam = "Stijn",
                    speler_Achternaam = "Dekeyser"
                }
            );
                }

                // Ik zoek naar clubs.
                if (!context.Club.Any())
                {
                    /*Binnen de AddRange kan ik clubs aanmaken.*/
                    context.Club.AddRange(
                /*Ik maak een nieuwe club aan.
                 Deze voorzie ik van informatie binnen de onderdelen die ik in de models heb gemaakt.
                In dit geval is dit Id, Club_Adres en Club_Naam*/
                new Club
                {
                    Id = 0,
                    Club_Adres = "Hendrik Placestraat 37, 1702 Groot-Bijgaarden",
                    Club_Naam = "TTC Dilbeek"
                },

                /*Ik maak nog een nieuwe club aan.*/
                new Club
                {
                    Id = 1,
                    Club_Adres = "Sint-Godardusstraat 28, 1406 Belang"
                }
            );
                }

                // Ik zoek naar de niveaus.
                if (!context.Niveau.Any())
                {
                    /*Ik maak een nieuw niveau aan.
                    Deze voorzie ik van informatie binnen de onderdelen die ik in de models heb gemaakt.
                    In dit geval is dit Id, Klassement en ELO_Punten*/
                    context.Niveau.AddRange(
                new Niveau
                {
                    Id = 0,
                    Klassement = "E4",
                    ELO_Punten = 798
                },

                /*Ik maak nog een nieuw niveau aan.*/
                new Niveau
                {
                    Id = 1,
                    Klassement = "C4",
                    ELO_Punten = 1564
                }
            );
                }
                /*Ik slaag de veranderingen binnen context op.*/
                context.SaveChanges();
        }
        }
    }
}

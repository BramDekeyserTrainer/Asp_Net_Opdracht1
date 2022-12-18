using Asp_Net_Opdracht1.Data;
using Microsoft.EntityFrameworkCore;

namespace Asp_Net_Opdracht1.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
               serviceProvider.GetRequiredService<
                   DbContextOptions<ApplicationDbContext>>())) 
            {

                /*Ik wil zeker zijn dat de database bestaat.
                 * EnsureCreated() zorgt ervoor dat deze sowieso is aangemaakt.*/
                context.Database.EnsureCreated();

                // Ik zoek naar spelers.
                if (!context.Speler.Any())
                {


                    context.Speler.AddRange(
                new Speler
                {
                    Id = 0,
                    Club_Id = 0,
                    Speler_Voornaam = "Bram",
                    speler_Achternaam = "Dekeyser"
                },

                new Speler
                {
                    Id = 1,
                    Club_Id = 1,
                    Speler_Voornaam = "Stijn",
                    speler_Achternaam = "Dekeyser"
                }
            );
                }

                // Ik zoek naar spelers.
                if (!context.Club.Any())
                {


                    context.Club.AddRange(
                new Club
                {
                    Id = 0,
                    Club_Adres = "Hendrik Placestraat 37, 1702 Groot-Bijgaarden",
                    Club_Naam = "TTC Dilbeek"
                },

                new Club
                {
                    Id = 1,
                    Club_Adres = "Sint-Godardusstraat 28, 1406 Belang"
                }
            );
                }

                // Ik zoek naar spelers.
                if (!context.Niveau.Any())
                {


                    context.Niveau.AddRange(
                new Niveau
                {
                    Id = 0,
                    Klassement = "E4",
                    ELO_Punten = 798
                },

                new Niveau
                {
                    Id = 1,
                    Klassement = "C4",
                    ELO_Punten = 1564
                }
            );
                }




                context.SaveChanges();
        }
        }
    }
}

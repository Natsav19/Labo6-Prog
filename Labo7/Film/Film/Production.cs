using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    class Production
    {
        string nom;

        //Construction
        public Production(string nom)
        {
            this.nom = nom;
        }

        //Centre du Code
        public void AfficherCatalogue()
        {
            Catalogue monCatalogue = new Catalogue("Catalogue de Nathan");

            Film film = new Film("A L'AIDE", "Joe Biden", 2021, "Auto-Biographie de Joe Biden");
            film.AjouterActeur("Joe Biden");
            film.AjouterGenre("Comédie");

            monCatalogue.AjouterFilm(film);

            film = new Film("49.3", "Emmanuel Macron", 2023, "Révolution a Paris très violente");
            film.AjouterActeur("Emmanuel Macron");
            film.AjouterActeur("Jason Stadam");
            film.AjouterGenre("Action");
            film.AjouterGenre("Drame");

            monCatalogue.AjouterFilm(film);


            film = new Film("SHE IS SIXTEEN YEAR OLD!!!!!!!!", "Pedro Pascal", 2003, "Un Homme se retouve en cours apres avoir été pieger par une jeune !");
            film.AjouterActeur("Pedro Martiz");
            film.AjouterActeur("Elonaure Bedard");
            film.AjouterGenre("comedie");
            film.AjouterGenre("Abusrde");

            monCatalogue.AjouterFilm(film);

            film = new Film("Emil Is SUS", "Nathan Savard", 2019, "Emil est un imposteur dans ce drame terrible. VA T-IL SE FAIRE INJECTER ?");
            film.AjouterActeur("Emil Neron");
            film.AjouterActeur("Léonard Davinci");
            film.AjouterGenre("Drame");
            film.AjouterGenre("Sombre");

            monCatalogue.AjouterFilm(film);


            monCatalogue.AfficherFilm();

            Console.WriteLine("*----- RECHERCHE ----*");
            monCatalogue.RechercherParTitre("Emil Is SUS");
            monCatalogue.RechercherParActeur("Elonaure Bedard");
        }
    }
}

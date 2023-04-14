using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    partial class Catalogue
    {

        //Fonction de Recherche
        public void RechercherParTitre(string titrefilm)
        {
            foreach(Film film in tblFilm)
            {
                if (film.Titre == titrefilm )
                {
                    film.Afficher();
                }
            }
        }

        public void RechercherParActeur(string acteur2)
        {
            foreach (Film film in tblFilm)
            {
                foreach (string acteur in film.TblActeur )
                {
                    if (acteur == acteur2)
                    {
                        film.Afficher();
                    }
                }
            }
        }

    }
}

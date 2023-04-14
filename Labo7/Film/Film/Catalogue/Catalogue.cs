using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    partial class Catalogue
    {
        string nom;
        List<Film> tblFilm;


        //Constructeurs
        public Catalogue (string nom)
        {
            this.nom = nom;
            tblFilm = new List<Film> ();
        }

        //Méthodes
        public void AjouterFilm(Film film)
        {
            tblFilm.Add(film);
        }
        public void SuprimmerFilm(Film film)
        {
            tblFilm.Remove(film);
        }
        public void AfficherFilm()
        {
            foreach(Film film in tblFilm)
            {
                film.Afficher();
            }
        }
    }
}

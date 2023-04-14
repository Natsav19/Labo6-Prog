using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film
{
    public partial class Film
    {
        public string Titre { get; set; }
        string realisateur;
        int annee;
        public List<string> TblActeur { get; set; }

        //Constructeur
        public Film (string titre, string realisateur, int annee, string synopsis)
        {
            Titre = titre;
            this.realisateur = realisateur;
            this.annee = annee;
            this.synopsis = synopsis;
            TblActeur = new List<string>();
            genres = new List<string>();
        }



        //Ajout Pour Les Listes
        public void AjouterActeur(string acteur)
        {
            TblActeur.Add(acteur);
        }
        public void AjouterGenre(string genre)
        {
            genres.Add(genre);
        }



        //Affichage
        public void Afficher()
        {
            Console.WriteLine($"infromations sur le film : {Titre}");
            Console.WriteLine($"Réalisateur : {realisateur}");
            Console.WriteLine($"Annee de Sortie : {annee}");
            Console.WriteLine($"Synopsis : {synopsis}");
            AfficherGenre();
            AfficherActeur();
        }

        public void AfficherGenre()
        {
            Console.WriteLine("*--- GENRE ---*");
            foreach (string genre in genres)
            {
             Console.WriteLine(genre);
            }
        }

        public void AfficherActeur()
        {
            Console.WriteLine("Liste des Acteurs : ");
            foreach (string acteur in TblActeur)
            {
                Console.WriteLine(acteur);
            }
        }

    }
}

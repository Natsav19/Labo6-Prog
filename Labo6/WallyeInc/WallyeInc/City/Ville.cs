using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallyeInc
{
    class Ville
    {
        string nom;
        Batiment[] tblBatiment;


        //Constructeur
        public Ville (string nom)
        {
            this.nom = nom;
            tblBatiment = new Batiment[5];
            tblBatiment[0] = new Batiment();
            tblBatiment[1] = new Batiment();
            tblBatiment [2] = new Batiment();
            tblBatiment[3] = new Batiment();
            tblBatiment[4] = new Batiment ();
        }

        //Renvoie les informations d'un batiment
        public Batiment Evaluation(int nb)
        {
            Batiment rapport = tblBatiment[nb];
            Console.WriteLine($"Le Robot Collecte les Informations du Batiment #{nb+1}");

            return rapport;
        }
    }
}

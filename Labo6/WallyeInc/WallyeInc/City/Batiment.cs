using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallyeInc
{
    enum Etat
    {
        Parfait,
        Réparation,
        Destruction, 
    }
    class Batiment
    {
        public int Coordonnée { get; set; }
        public int QtsRessource { get; set; }
        public int Priorité { get; set; }
        public Etat Etat { get; set; }

        public Batiment()
        {
            //Setting de la variable Coordonnée
            Coordonnée = random.Next(1, 201);

            //Setting de la variable etat
            int nb = random.Next(0, 3);
            Etat = (Etat)nb;

            //Setting de la variable qtsRessource
            if (Etat == Etat.Réparation)
            {
                QtsRessource = random.Next(1, 26);
            }
            else { QtsRessource = 0; }

            //Setting de la variable Priorité 
            Priorité = random.Next(1, 6);
        }

        //Fonction Random
        static readonly Random random = new Random();
    }
}

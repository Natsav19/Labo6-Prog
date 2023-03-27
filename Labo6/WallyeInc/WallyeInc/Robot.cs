using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallyeInc
{
    class Robot
    {
        public string Nom { get; set; }
        Piece[] tblPieces;

        //Constructeur
        public Robot(string nom)
        {
            Nom = nom;
            tblPieces = new Piece[3];       
        }

        public Robot(Type nom, Batiment rapport)
        {
            Nom = $"Robot de {nom}";
            tblPieces = new Piece[3];
            if (nom == Type.Construction)
            {
                tblPieces[0] = new Construction(Nom, 15);
                tblPieces[1] = new Transport(Nom, 20);
                if (rapport.Coordonnée > 100)
                {
                    tblPieces[2] = new Vitesse("Moteur", 100);
                }
            }
            else
            {
                tblPieces[0] = new Destruction(Nom, 15);
                if (rapport.Coordonnée > 100)
                {
                    tblPieces[1] = new Vitesse("Moteur", 100);
                }
            }
            Console.WriteLine();
            AfficherRobot(tblPieces);
        }


        //AFFICHER LES PROPRIÉTÉS D'UN ROBOT
        public void AfficherRobot(Piece[] tblPieces)
        {
            Console.WriteLine($"*---- Priorité du {Nom} ----*");
            for (int i = 0; i < tblPieces.Length; i++)
            {
                if (tblPieces[i] != null)
                {
                    Console.WriteLine(tblPieces[i].ToString());
                }
                else
                {
                    Console.WriteLine("Aucune Pièce");
                }
                
            }
        }


    }
}

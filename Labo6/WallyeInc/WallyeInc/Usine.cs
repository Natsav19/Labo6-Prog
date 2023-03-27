using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallyeInc
{
    class Usine
    {
        string nom;

        //Constructeur
        public Usine(string nom)
        {
            this.nom = nom;
        }

        //Fonction qui CRÉER les Robots !
        public Robot CreerRobot(Type nom, Batiment rapport)
        {
                Robot robot = new Robot(nom, rapport);
                return robot;
        }

        public Robot CreerRobot(string nom)
        {
            Robot robot = new Robot(nom);
            return robot;
        }
    }
}

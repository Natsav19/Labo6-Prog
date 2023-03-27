using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallyeInc
{
    class Vitesse : Piece
    {
        int vitesse;

        //Constructeur
        public Vitesse (string nom,int vitesse) : base(nom)
        {
            this.vitesse = vitesse;
        }

        //Fonction ToString
        public override string ToString()
        {
            string info = base.ToString();

            info += $"---> Vitesse---> {vitesse}";
            return info;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallyeInc
{
    class Construction : Piece
    {
        int vitesseReparation;

        //Constructeur
        public Construction(string nom, int vitesseReparation ) : base(nom)
        {
            this.vitesseReparation = vitesseReparation;
        }

        //Fonction ToString
        public override string ToString()
        {
            string info = base.ToString();

            info += $"--->  Vitesse de Réapration ---> {vitesseReparation}";
            return info;
        }
    }


}

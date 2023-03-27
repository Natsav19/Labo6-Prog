using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallyeInc
{
    class Transport : Piece
    {
        int poids;

        //Constructeur
        public Transport(string nom, int poids) : base(nom)         {
            this.poids = poids;
        }

        //Fonction ToString
        public override string ToString()
        {
            string info = base.ToString();

            info += $"---> Poids ---> {poids}";
            return info;
        }

    }
}

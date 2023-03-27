using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallyeInc
{
    class Destruction : Piece
    {
        int degat;

        //Constructeur
        public Destruction (string nom, int degat) : base(nom)
        {
            this.degat = degat;
        }


        //Fonction ToString
        public override string ToString()
        {
            string info = base.ToString();

            info += $"---> Dégats ---> {degat}";
            return info;
        }
    }
}

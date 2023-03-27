using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallyeInc
{
    class Piece
    {
        
        string nom;

        //Constructeur
        public Piece(string nom)
        {
            this.nom = nom;
        }

        //Fonction ToString
        public override string ToString()
        {
            return $"{nom} ";
        }
    }
}

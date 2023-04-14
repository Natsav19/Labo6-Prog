using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    class Astronaute
    {
        public string Nom { get; set; }
        public int Looting { get; set; }
        public int Prix { get; set; }

        public Astronaute(string nom, int prix)
        {
            Nom = nom;
            Prix = prix;
            Looting = random.Next(1, 101);
        }

        static readonly Random random = new Random();
    }
}

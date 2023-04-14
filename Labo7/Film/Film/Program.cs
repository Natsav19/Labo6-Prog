using System;
using System.Collections.Generic;
using System.Text;

namespace Film
{
    class Program
    {

        static void Main(string[] args)
        {
            Production maProduction = new Production("netSUS");

            maProduction.AfficherCatalogue();
        }
    }
}

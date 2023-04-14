using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public partial class Mission
    {
        public void CompleterMission()
        {
            Etat = Status.terminée;
            Console.WriteLine("Mission terminée avec succès !");
        }
    }
}

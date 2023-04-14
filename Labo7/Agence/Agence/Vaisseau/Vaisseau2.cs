using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public partial class Vaisseau
    {

        //Fonction Changement de Vitesse
        public void ChangerVitesse()
        {
            try
            { 
                if (VitesseAct > VitesseMax)
                {
                    throw new Exception("La vitesse demandée dépasse la vitesse maximale");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            VitesseAct = VitesseMax;
        }
    }
}

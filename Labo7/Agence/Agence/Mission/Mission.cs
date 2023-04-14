using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
   public enum Status
    {
        planifiée,
        en_cours,
        terminée,
    }
    public partial class Mission
    {
        public string Nom { get; set; }
        public int Destination { get; set; }
        public int Depart { get; set; }
        public int Arriver { get; set; }
        public Status Etat { get; set; }


        //Constructeurs
        public Mission (string nom, int destination, int depart, int arriver, Status etat)
        {
            Nom = nom;
            Destination = destination;
            Depart = depart;
            Arriver = arriver;
            Etat = etat;
        }

        public Mission(int destination, int depart)
        {
            Nom = $"Mission d'exploration {random.Next(1,200)}";
            Destination = destination;
            Depart = depart;
            Arriver = random.Next(1, 100);
            Etat = Status.planifiée;
        }


        //Randomiser
        static readonly Random random = new Random();
    }
}

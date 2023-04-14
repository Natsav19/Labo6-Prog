using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public partial class Vaisseau
    {
        public string Nom { get; set; }
        public int NbPersonne { get; set; }
        public int VitesseAct { get; set; }
        public int VitesseMax { get; set; }
        public int Orbite { get; set; }

        //Constructeur

        public Vaisseau(string nom, int nbPersonne, int vitesseAct, int vitesseMax, int orbite)
        {
            Nom = nom;
            NbPersonne = nbPersonne;
            VitesseAct = vitesseAct;
            VitesseMax = vitesseMax;
            Orbite = orbite;
        }

        //Fonction Pour le Décollage
        public void Décollage(List<Mission> MissionEnCours, int coord, int date)
        {
            try
            {
                if (Orbite != 0)
                {
                    throw new Exception("Le Vaisseau est déja en orbite");
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            MissionEnCours.Add(new Mission(coord, date));
            Orbite = 1;
        }
    }
} 

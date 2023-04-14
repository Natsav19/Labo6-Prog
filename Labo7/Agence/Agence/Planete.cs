using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    class Planete
    {
        public string Nom { get; set; }
        public int Taille { get; set; }
        public int Distance { get; set; }
        public string Information { get; set; }
        public bool Visite { get; set; }

        //Constructeur
        public Planete(string nom, int taille, int distance, string information)
        {
            Nom = nom;
            Taille = taille;
            Distance = distance;
            Information = information;
            Visite = false;
        }

        //Fonction de Vérification 

        public int VérificationPlanete(List <Astronaute> Employer, int somme)
        {
            try 
            { 
                if (Visite == true)
                {
                    throw new Exception("Cette Planète est déja visitée");
                }
                else 
                {
                    int i = 0;
                    int totalExperience = 0;
                    foreach (Astronaute employe in Employer)
                    {
                        totalExperience += employe.Looting;
                        i++;
                    }
                    int MoyenneEmp = totalExperience / i;
                    somme = RécupérationMatériaux(MoyenneEmp, somme);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Visite = true;
            AfficherPlanete();
            return somme;
        }

        //Fonction Affichage Planete
        public void AfficherPlanete()
        {
            Console.WriteLine("*--------------------------------*");
            Console.WriteLine($"Nom --> {Nom}");
            Console.WriteLine($"Taille --> {Taille}");
            Console.WriteLine($"Distance de la Terre --> {Distance}");
            Console.WriteLine(Information);
            Console.WriteLine();
            Console.WriteLine("*--------------------------------*");
        }

        public int RécupérationMatériaux(int MoyenneEmp, int somme)
        {
            int nbMateriaux;
            int MateriauxRare;
            if ((MoyenneEmp > 80) && (MoyenneEmp < 101))
            {
                nbMateriaux = random.Next(50, 101);
                MateriauxRare = random.Next(0, 11);
            }
            else if ((MoyenneEmp > 50) && (MoyenneEmp < 80))
            {
                nbMateriaux = random.Next(25, 51);
                MateriauxRare = random.Next(0, 6);
            }
            else 
            {
                nbMateriaux = random.Next(0, 26);
                MateriauxRare = random.Next(0, 1);
            }
            Console.WriteLine($"Vous Avez récupérer {nbMateriaux} Matériaux!");
            somme = somme + (nbMateriaux * 15);
            Console.WriteLine($"Vous Avez récupérer {MateriauxRare} Matériaux rare !");
            somme = somme + (MateriauxRare * 100);
            return somme;
        }

        static readonly Random random = new Random();

    }
}

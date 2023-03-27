using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallyeInc
{
    enum Type
    {
        Construction,
        Destruction,
    }
    class Centre
    {
        string nom; 

        //Constructeur
        public Centre(string nom)
        {
            this.nom = nom;
        }

        //Méthodes Centre
        public void DémarrerSimulation()
        {
            Robot[] inventaire = new Robot[5];
            Ville ville1 = new Ville("Montréal");
            Usine usine = new Usine("WallyeInc");
            Robot robot1 = usine.CreerRobot("Robot Ressource");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Batiment rapport = ville1.Evaluation(i);
                AfficherRapport(rapport, i);
                if (rapport.Etat == Etat.Parfait)
                {
                    Console.WriteLine("Le Batiment est en Parfait État passons au prochain");
                }
                else if (rapport.Etat == Etat.Réparation)
                {
                    if (RegarderInventaire(inventaire, Type.Construction) == false )
                    {
                        Robot robot = usine.CreerRobot(Type.Construction, rapport);
                        inventaire[i] = robot;
                    }
                    else
                    {
                        Console.WriteLine("Nous avons envoyé un robot de notre Inventaire qui s'occupe de ce type de batiment");
                    }
                }
                else 
                {
                    if (RegarderInventaire(inventaire, Type.Destruction) == false)
                    {
                        Robot robot = usine.CreerRobot(Type.Destruction, rapport);
                        inventaire[i] = robot;
                    }
                    else
                    {
                        Console.WriteLine("Nous avons envoyé un robot de notre Inventaire qui s'occupe de ce type de batiment");
                    }
                }
            }
            Console.WriteLine("HOURA ! LA VILLE EST MAINTENANT RÉPARÉE !!");
        }


        //Fonction Qui Affiche les propriétés du Batiment X
        public void AfficherRapport(Batiment rapport, int i)
        {
            Console.WriteLine($"*----- Voici Le Rapport {i +1} -----*");
            Console.WriteLine($"Coordonnée : {rapport.Coordonnée}");
            Console.WriteLine($"Ressource Besoin : {rapport.QtsRessource}");
            Console.WriteLine($"État : {rapport.Etat}");
            Console.WriteLine($"Priorité : {rapport.Priorité}");
        }

        //VÉRIFICATION D'UN ROBOT X DANS L'INVENTAIRE
        public bool RegarderInventaire(Robot[] inventaire, Type type)
        {
            for (int i =0 ; i < inventaire.Length; i++)
            {
                if (inventaire[i] != null)
                { 
                    if (inventaire[i].Nom == $"Robot de {type}")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Agence
{
    class Agence
    {
        string nom;
        public List<Mission> MissionEnCours { get; set; }
        public List<Astronaute> tblEmployer { get; set; }

        public Agence(string nom)
        {
            this.nom = nom;
            MissionEnCours = new List<Mission>();
            tblEmployer = new List<Astronaute>();
        }

        public void LancerJeux()
        {
            Console.WriteLine("DÉBUT DU JEUX !!!");
            Console.WriteLine("Vous Commencez avec 5000$");
            int somme = 5000;
            //MENU ACTION
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"--> Année Numéro {i + 1}");
                Console.WriteLine($"Voici Votre Balance >>>>> {somme}");
                Console.WriteLine(">>>>Menu Action<<<<<<");
                Console.WriteLine("1- Lancer Une Mission");
                Console.WriteLine("2- Engager des Astronautes");
                Console.WriteLine("3- Voir votre Balance");
                Console.WriteLine("--> Tapez un chiffre pour faire une action (1,2 OU 3)");
                int choix = Convert.ToInt32(Console.ReadLine());
                //CONFIRMATION DU CHOIX
                while ((choix > 3) || (choix < 0))
                {
                    Console.WriteLine("--> Tapez un chiffre pour faire une action (1,2 OU 3)");
                    choix = Convert.ToInt32(Console.ReadLine());
                }
                if (choix == 1) {somme = LancerMission(somme); }
                if (choix == 2) { somme = EngagerAstronaute(somme); }
                if (choix == 3) { Console.WriteLine($"Voici Votre Balance >>>>> {somme}"); }
            }
            Console.WriteLine("GAME-OVER");
            Console.WriteLine("IMPOSTER IS COMING ! SUS");
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c start https://www.youtube.com/watch?v=pvbBVEErxM8",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            Process.Start(psi)
        }


        public int LancerMission(int somme)
        {
            Console.WriteLine("Pour Commencer la Mission il vous faut choisir un vaisseau!");
            //CRÉATION VAISSEAU
            Vaisseau vaisseau1 = new Vaisseau("FK-472", 6, 10, 20, 1);
            Vaisseau vaisseau2 = new Vaisseau("FK-473", 4, 13, 30, 0);
            Vaisseau vaisseau3 = new Vaisseau("FK-474", 2, 16, 40, 1);


            Console.WriteLine("Voici Votre garage a vaisseau :");
            Console.WriteLine("1- Nom --> FK-472 " +
                "Capacité --> 6 Passagers" +
                "Vitesse Maximum --> 20" );
            Console.WriteLine("2- Nom --> FK-473 " +
                "Capacité --> 4 Passagers" +
                "Vitesse Maximum --> 30" );
            Console.WriteLine("3- Nom --> FK-474 " +
                "Capacité --> 2 Passagers" +
                "Vitesse Maximum --> 40");
            Console.WriteLine();
            Console.WriteLine("Lequel allez-vous choisir ? (1 , 2 OU 3)");
            int choixV = Convert.ToInt32(Console.ReadLine());
            while ((choixV > 3) || (choixV < 0))
            {
                Console.WriteLine("Lequel allez-vous choisir ? (1 , 2 OU 3)");
            }
            if ( choixV == 1 ) { vaisseau1.Décollage(MissionEnCours, 10, 02122023);}
            else if(choixV == 2) { vaisseau2.Décollage(MissionEnCours, 13, 02052023);}
            else{ Vaisseau vaisseauM = vaisseau3; }


            Console.WriteLine("Décollage du Vaisseau....");
            //CRÉATION DES PLANETES
            List<Planete> planetes = new List<Planete>();
            planetes.Add(new Planete("Ludvine", 30, 10, "Planete Vivable"));
            planetes.Add(new Planete("Mars", 40, 13, "Planete non-vivable"));
            planetes.Add(new Planete("Jupiter", 50, 15, "Planete non-vivable"));
            planetes.Add(new Planete("Titan", 60, 20, "Possiblement Vivable"));

            Random random = new Random();
            int r = random.Next(0, planetes.Count);

            somme = planetes[r].VérificationPlanete(tblEmployer, somme);

            foreach (Mission mission in MissionEnCours)
            {
                mission.CompleterMission();
            }
            return somme;
        }
        public int EngagerAstronaute(int somme)
        {
            List<Astronaute> AstronautesDisponibles = new List<Astronaute>();
            AstronautesDisponibles.Add(new Astronaute("Jean", 1000));
            AstronautesDisponibles.Add(new Astronaute("Lucie", 1500));
            AstronautesDisponibles.Add(new Astronaute("Pierre", 1200)); 
            AstronautesDisponibles.Add(new Astronaute("CREWMATE", 1200));
            AstronautesDisponibles.Add(new Astronaute("Sophie", 1800));
            AstronautesDisponibles.Add(new Astronaute("IMPOSTEUR", 900));

            foreach(Astronaute a in AstronautesDisponibles)
            {
               
               Console.WriteLine($"{a.Nom} (Expérience : {a.Looting}, Prix : {a.Prix}$)");
            }

            Console.WriteLine("Choisissez un astronaute en entrant son numéro :");
            int choix = Convert.ToInt32(Console.ReadLine()); ;

            // Ajout de l'astronaute choisi à la liste des employés
            Astronaute astronauteChoisi = AstronautesDisponibles[choix];
            AstronautesDisponibles.RemoveAt(choix);
            tblEmployer.Add(astronauteChoisi);
            somme = somme - astronauteChoisi.Prix;
            return somme;
        }
        static readonly Random random = new Random();

    }
}

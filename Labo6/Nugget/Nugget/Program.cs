using Nugget;
using System;
using System.Drawing;
using Console = Colorful.Console;
using Humanizer;


namespace Nugget
{

    class Program
    {
        static void Main(string[] args)
        {
            TestHumain();
            TestConsole();
        }

        static void TestHumain()
        {

            // NUMÉRO 1
            string mot = "humain";
            string mot2 = mot.Titleize();
            Console.WriteLine($"Voici le mot {mot} capitaliser--> {mot2}");

            // NUMÉRO 2

            DateTime date1 = new DateTime(2022, 01, 01, 0, 0, 0);
            DateTime date2 = DateTime.Now;
            TimeSpan timespan = date1 - date2;
            string time = timespan.Humanize();
            Console.WriteLine($"Il a une intervalle de {time}");

            // NUMÉRO 3

            int nb = 102;
            string chiffre = nb.Ordinalize();
            Console.WriteLine($"Le Nombre ordinalisée est : {chiffre}");

            // NUMÉRO 4

            string texte = "Bonjour a tous ca va bien ?";
            string texte2 = texte.Pascalize();
            Console.WriteLine($"Voici votre texte Pascaliser : {texte2}");

            // NUMÉRO 5 

            string text = "Je m'appelle Nathan";
            string text2 = text.Truncate(15);
            Console.WriteLine($"{text2}");
        }


        static void TestConsole()
        {
            Console.WriteLine("Erreur : la valeur est invaalide", System.Drawing.Color.Red);

            //Ce NuGet permet de colorier le texte...  
        }
    }
}

using AmitieNamespace;
using ChatNamespace;
using ChienNamespace;

namespace AmitieNamespace
{

    class Program
    {
        static void Main(string[] args)
        {
            Chat chat = new Chat("Cat", "Joyeux");
            Chien chien = new Chien("Dog", "Joyeux");
            Chien chien2 = new Chien("Doggy", "Joyeux");

            if (chat.Emotion == "Facher")
            {
                Console.WriteLine("Le Chat est partie car il était pas de bonne humeur");
                chien.Emotion = "Triste";
                chien2.Emotion = "Triste";
                AfficherEmotion(chat, chien, chien2);
            }
            else
            {
                Console.WriteLine($"{chien.Nom} Et {chat.Nom}  Deviennent ami ! Cela rend très triste {chien2.Nom} car il n'a pas d'ami.");
                Console.WriteLine($"{chien2.Nom} Essaye de devenir l'ami de  {chat.Nom} en lui offrant une rose.");
                chien2.Emotion = "Triste";
                Console.WriteLine($"{chien.Nom} se sent coupable et décide de devenir l'ami de {chien2.Nom} mais c'est maintenant le chat qui est triste!");
                chien2.Emotion = "HEUREUX";
                chat.Emotion = "Triste";
                AfficherEmotion(chat, chien, chien2);
            }

        }

        static void AfficherEmotion(Chat chat, Chien chien, Chien chien2)
        {
            Console.WriteLine("*------[ Tableau des Humeurs ]------*");
            Console.WriteLine($"{chien.Nom} -----> {chien.Emotion}");
            Console.WriteLine($"{chien2.Nom} -----> {chien2.Emotion}");
            Console.WriteLine($"{chat.Nom} -----> {chat.Emotion}");
            Console.WriteLine("*------------------------------------*");
        }
    }
}

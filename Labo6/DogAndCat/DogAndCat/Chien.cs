using ChienNamespace;


namespace ChienNamespace
{

    class Chien
    {
        public string Nom { get; set; }
        public string Emotion { get; set; }

        public Chien(string nom, string emotion)
        {
            Nom = nom;
            Emotion = emotion;
        }
    }
}

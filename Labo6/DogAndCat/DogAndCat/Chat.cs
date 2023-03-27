using ChatNamespace;

namespace ChatNamespace
{
    class Chat
    {
        public string Nom { get; set; }
        public string Emotion { get; set; }

        public Chat (string nom, string emotion)
        {
            Nom = nom;
            Emotion = emotion;
        }
    }
}

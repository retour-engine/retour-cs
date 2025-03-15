namespace retour.Classes
{
    public class Object
    {
        public int id { get; }
        public string name { get; set;  }
        public Healt healt { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public string texture { get; set; }

        public void handle ()
        {
            // TODO: Обработка каждый тик
        }
    }
}

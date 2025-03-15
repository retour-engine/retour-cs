namespace retour.Classes
{
    public class DataBlock
    {
        public int idBlock;

        public int z { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public string texture { get; set; } = "error_texture";
    }

    public class ItemData
    {
        public int idItem { get; set; }

        public string name { get; set; } = "apple";
        public int count { get; set; }
        public string dysplayName { get; set; } = "Apple";
        public Dictionary<string, string[]> dataItem { get; set; }
    }
    public class Player
    {
        public Inventory? Inventory = new Inventory();
        public int id { get; set; }

        public string name { get; set; }

        public Healt healt { get; set; }
        public int x { get; set; }
        public int y { get; set; }

    }
}

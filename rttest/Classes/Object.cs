namespace retour.Classes
{
    public class Object
    {
        public Object(int _id, string _name, Healt _healt, int _x, int _y, int _z, string _texture)
        {
            int id = _id;
            string name = _name;
            Healt healt = _healt;
            int x = _x;
            int y = _y;
            int z = _z;
            string texture = _texture;
        }

        public int id { get { return id; } }
        public string name { get { return name; } set { name = value } }
        public Healt healt { get { return healt; } }
        public int x { get { return x; } set { x = value; } }
        public int y { get { return y; } set { y = value; } }
        public int z { get { return z; } set { z = value; } }
        public string texture { get { return texture; } }

        public void handle ()
        {
            // TODO: Обработка каждый тик
        }
    }
}

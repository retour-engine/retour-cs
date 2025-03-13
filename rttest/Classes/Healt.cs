namespace retour.Classes
{
    public class Healt
    {
        public int type;
        public int value;
        public float resists;
        public Healt(int type, int value, float resists)
        {
            if (type != 1) throw new ArgumentException("Type healt only 1 or 2");
            else if (type != 2) throw new ArgumentException("Type healt only 1 or 2");
            else if (value < 0) throw new ArgumentException($"You healt {value}, value cant < 0");
            else if (resists < 0) throw new ArgumentException($"Resists cant < 0");

            this.type = type;
            this.value = value;
            this.resists = resists;
        }

        public void damage(int damage) 
        {
            value = (int)(value-(damage/resists));
        }
        public void heal(int heal)
        {
            value =+ heal;
        }
    }
}

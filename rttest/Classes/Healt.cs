using retour.Methods;

namespace retour.Classes
{
    public class Healt
    {
        public Logging log = new();

        public int uid;
        public int hp { get; set; }
        public double resists { get; set; }
        public Healt()
        {
            //log.Log("ERROR", $"ObjectOnEngine[{uid}]", $"have invalid {type} type to heal"); throw new Exception($"ObjectOnEngine[{uid}]: have invalid {type} type to heal");
        }
        public void damage(int damage, int uid, string reason = "null", int damagerId = -1, bool ignoreResists = false) 
        {
            if (ignoreResists) { hp = hp - damage; }
            else if ( !ignoreResists) { hp = (int)(hp - (damage / resists)); }
            log.Log("LOG", $"Healt.Target[{uid}]", $"Damage [{damage} - r: {(int)(damage / resists)}] from [{damagerId}] reason: {reason}");
        }
        public void heal(int heal, int uid, string reason = "null")
        {
            hp =+ heal;
            if (hp > 0) { hp = 0; }
            else if (hp > 100) { hp = 100; }
            log.Log("LOG", $"Healt.Target[{uid}]", $"Heal [{heal}] from id: [{uid}] reason [{reason}]");
        }
    }
}

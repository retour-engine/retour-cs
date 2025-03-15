using retour.Methods;

namespace retour.Classes
{
    public class Healt
    {
        public Logging log = new();

        public int uid;
        public int type { get; set; } // 1 - player, 2 - object
        public int hp { get; set; }
        public double resists { get; set; }
        public Healt()
        {
            if ((type != 1) || (type != 2))
            {
                log.Log("ERROR", $"ObjectOnEngine[{uid}]", $"have invalid {type} type to heal"); throw new Exception($"ObjectOnEngine[{uid}]: have invalid {type} type to heal");
            }
        }
        public void damage(int damage, int uid, string reason = "null", int damagerId = -1, bool ignoreResists = false) 
        {
            if (ignoreResists) { hp = hp - damage; }
            else if ( !ignoreResists) { hp = (int)(hp - (damage / resists)); }

            log.Log("LOG", $"Healt.Target[{uid}]", $"Damage [{damage}] from [{damagerId}]");

        }
        public void heal(int heal, int uid, string reason = "null")
        {
            hp =+ heal;
            log.Log("LOG", $"Healt.Target[{uid}]", $"Heal [{heal}] from reason [{reason}]");
        }
    }
}

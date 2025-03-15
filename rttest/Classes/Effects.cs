namespace retour.Classes
{
    public class Effects
    {
        private int effectTime = 0;

        public string name;
        public int secondToEnd;
        public int effectType; // 0 - None, 1 - Heal on tick, 2 - Damage on tick, 3 Armour
        public double effectValue;

        public Effects(Player player) 
        {
            while (effectTime < secondToEnd) 
            { 
                if (effectType == 0)
                {
                    return;
                }

                if (effectType == 1)
                {
                    player.healt.heal((int)effectValue, player.id, $"Healing from {name} effect");
                }

                if (effectType == 2) 
                {
                    player.healt.damage((int)effectValue, player.id, $"Damage from {name} effect");
                }
                if (effectType == 3)
                {
                    player.healt.resists += effectValue;
                }
                effectTime++;
                Thread.Sleep(500);
            }
        }
    }
}

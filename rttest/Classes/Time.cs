namespace retour.Classes
{
    public class Time
    {
        public int tick = 0;
        public void s(Map map)
        {
            if (tick == -1)
            {
                Console.WriteLine("Engine has been debug mode");
                return;
            }
            else
            {
                foreach (var _object in map.Objects)
                {
                    Console.WriteLine($"{_object.Value.id}: {_object.Value.name}");
                }
                tick++;
            }
        }
    }
}

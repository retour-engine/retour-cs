namespace retour.Classes
{
    public class Time
    {
        public int tick = 0;
        public void s(Map map)
        {
            if (tick == -1)
            {
                foreach (var _object in map.Objects)
                {
                    Console.WriteLine($"{_object.Value.id}: {_object.Value.name}");
                }
                Console.WriteLine("Engine has been debug mode: %s", tick);
                return;
            }
            else tick++;
        }
    }
}

using retour.Classes;

namespace retour.Methods
{
    internal class Prints
    {
        public void DevPrints(Map map)
        {
            foreach (var block in map.mapDate)
            {
                Console.WriteLine($"{block.Value.x}, {block.Value.y}");
            }
            foreach (var player in map.players)
            {
                Console.WriteLine(player.Value.healt.hp);
            }
        }
    }
}

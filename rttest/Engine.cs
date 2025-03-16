using retour.Classes;
using retour.Methods;
namespace retour;
class Engine
{
    static Boolean runned = true;

    public static Time tickManager = new();
    public static Logging logging = new();
    public static Map Map = new(logging);
    static void Main(string[] args)
    {
        GameLoader();
        logging.Log("LOG", "Engine.Thread", "Gameloader is load!");
        while (runned)
        {
            tickManager.s(Map);
            Console.WriteLine($"tick: {tickManager.tick}");
            new Prints().DevPrints(Map);
            Thread.Sleep(500); Console.Clear();
        }
        if (!runned)
        {
            logging.Log("LOG", "Engine.Thread", "Engine has been stopped");return;
        }
    }
    static void GameLoader()
    {
        Map.createMap();
        logging.Log("LOG", "Engine.GameLoader", "Map created!");
        var newPlayer = new Player();
        {
            newPlayer.id = 0; newPlayer.name = "terra"; newPlayer.y = 0; newPlayer.x = 0; newPlayer.Inventory = new Inventory(); newPlayer.healt = new Healt();
            {
                newPlayer.healt.uid = 0;
                newPlayer.healt.hp = 50;
                newPlayer.healt.resists = 1.5;
            }
        }
        Map.spawnPlayer(newPlayer);
        var item = new ItemData();
        {
            item.name = "test";
            item.idItem = 1;
            item.count = 1;
            item.dysplayName = "test";
        }
        Map.players[0].Inventory.addItem(item);
        new Effects(Map.players[0])
        {
            effectType = 2,
            secondToEnd = 5,
            effectValue = 10,
            name = "testeffect"
        }.Run();
    }
}


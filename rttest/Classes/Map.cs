namespace retour.Classes
{
    public class Map
    {
        public int sizeMap = 4;

        public Dictionary<int, DataBlock> mapDate = new Dictionary<int, DataBlock>();
        public Dictionary<int, Player> players = new Dictionary<int, Player>();
        public Dictionary<int, Object> Objects = new Dictionary<int, Object>();

        public void createMap()
        {
            for (var x = 0; x < sizeMap / 2; x++)
            {
                for (var y = 0; y < sizeMap / 2; y++)
                {
                    var newBlock = new DataBlock();
                    {
                        newBlock.idBlock = mapDate.Count+1;
                        newBlock.x = x;
                        newBlock.y = y;
                        newBlock.z = 0;
                        newBlock.texture = "Apple";
                    }
                    mapDate.Add(mapDate.Count+1, newBlock);
                }
            }
        }
        public void spawnPlayer( Player player )
        {
            if (players.TryGetValue( player.id, out var map ) ) { throw new Exception("ID has been ocuped"); }
            players.Add(player.id, player);
        }
        public void spawnObject ( Object obj )
        {
            if (Objects.TryGetValue( obj.id, out var map ) ) { throw new Exception("ID has been ocuped"); }
            Objects.Add( obj.id, obj );
        }
    }
}

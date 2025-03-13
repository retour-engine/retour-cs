namespace retour.Classes
{
    public class Inventory
    {
        public Dictionary<int, ItemData> items = new Dictionary<int, ItemData>();

        public int maxSlots = 9;
        public int maxCount = 99;

        public void addItem(ItemData item) 
        { 
            items.Add(items.Count+1, item);
        }
        public void removeItem(int key) 
        {
            items.Remove(key);
        }
    }
}

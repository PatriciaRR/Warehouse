using System;

namespace Warehouse
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
        //List<string> allItems = new List<string> ("001A", "Notebook", 2.99) & Loop
        Item item = new Item("001A", "Notebook", 2.99);
        item.DisplayItemDetails();
          
        }
    }
}

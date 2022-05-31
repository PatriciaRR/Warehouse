using System.Collections.Generic;

namespace Warehouse
{
    public class Warehouse
    {
        public Dictionary <Item, int> Stock {get;} = new Dictionary <Item, int> ();
        
        public Warehouse(Dictionary <Item, int> InitialStock)
        {
            Stock = InitialStock;
        }
    
    }
}
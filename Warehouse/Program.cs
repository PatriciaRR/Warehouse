using System;
using System.Collections.Generic;

namespace Warehouse
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Warehouse warehouse = new Warehouse (
                new Dictionary <Item, int>
                {
                    {new Item("notebook", 2.50m, "stationary"), 100},
                    {new Item("ruler", 1.50m, "stationary"), 50},
                    {new Item("football", 40m, "sports"), 100},
                    {new Item("swimming cap", 12m, "sports"), 100},
                    {new Item("toothpaste", 3m, "hygiene"), 100},
                    {new Item("deodorant", 3.50m, "stationary"), 100}
                }
            );

            foreach(Item item in warehouse.Stock.Keys)
            {
                Console.WriteLine(
                    $"There are {warehouse.Stock[item]} of item \"{item.Name}\" in category \"{item.Category}\" at a price of \"{item.SalePrice}\" each.");
            }
          
        }
    }
}

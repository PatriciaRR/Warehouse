using System;

namespace Warehouse
{
    public class Item
    {
        
        public string Name {get;}
        public decimal SalePrice {get;}
        public string Category {get;}

        public Item (string name, decimal salePrice, string category)
        {
            Name = name;
            SalePrice = salePrice;
            Category = category;
        }

        public void DisplayItemDetails()
        {
            Console.WriteLine($"Item data:\nName: {Name} \nPrice: {SalePrice} \nCategory: {Category}");
        }
          
    }
}

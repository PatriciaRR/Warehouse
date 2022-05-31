using System;

namespace Warehouse
{
    public class Item
    {
        public string Reference {get;}
        public string Name {get;}
        public double SalePrice {get;}

        public Item (string reference, string name, double salePrice)
        {
            Reference = reference;
            Name = name;
            SalePrice = salePrice;
        }

        public void DisplayItemDetails()
        {
            Console.WriteLine($"Item data: \nRef: {Reference} \nName: {Name} \nPrice: {SalePrice}");
        }
          
    }
}

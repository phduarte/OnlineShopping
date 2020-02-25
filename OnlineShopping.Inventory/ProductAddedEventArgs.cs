using System;

namespace OnlineShopping.Inventory
{
    public class ProductAddedEventArgs : EventArgs
    {
        public Product Product { get; }
        public int Quantity { get; }

        public ProductAddedEventArgs(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
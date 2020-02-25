using System;

namespace OnlineShopping.Inventory
{
    public class ProductCreatedEventArgs : EventArgs
    {
        public Product Product { get; }

        public ProductCreatedEventArgs(Product product)
        {
            Product = product;
        }
    }
}
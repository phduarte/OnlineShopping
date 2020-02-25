using System;

namespace OnlineShopping.Inventory
{
    public class ProductRemovedEventArgs : EventArgs
    {
        public Product Product { get; }
        public int Quantity { get; }

        public ProductRemovedEventArgs(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
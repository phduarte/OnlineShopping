using System.Collections.Generic;
using System.Linq;

namespace OnlineShopping.Inventory
{
    public class Warehouse : Entity<int>
    {
        List<Product> _products = new List<Product>();

        public event ProductAddedEventHandler OnProductAdded;
        public event ProductRemovedEventHandler OnProductRemoved;
        public event ProductCreatedEventHandler OnProductCreated;

        public string Section { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }
        public IReadOnlyList<Product> Products => _products;

        public void Add(int id, int quantity)
        {
            var p = GetById(id);
            var before = p.Quantity;
            p.Quantity += quantity;
            OnProductAdded?.Invoke(this, new ProductAddedEventArgs(p, before));
        }

        public void Create(Product product)
        {
            _products.Add(product);
            OnProductCreated?.Invoke(this, new ProductCreatedEventArgs(product));
        }

        public void Remove(int id, int quantity)
        {
            var p = GetById(id);
            var before = p.Quantity;
            p.Quantity -= quantity;
            OnProductRemoved?.Invoke(this, new ProductRemovedEventArgs(p, before));
        }

        public Product GetById(int id)
        {
            return _products.First(x => x.Id.Equals(id));
        }

        public override string ToString()
        {
            return Section;
        }
    }
}
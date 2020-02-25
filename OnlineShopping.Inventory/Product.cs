namespace OnlineShopping.Inventory
{
    public class Product : Entity<int>
    {
        public string Nome { get; set; }
        public int Quantity { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public decimal Weight { get; set; }
        public ProductAvailability Availability => new ProductAvailability(Quantity, Minimum, Maximum);
        public Warehouse Warehouse { get; set; }

        public override string ToString()
        {
            return $"{Nome}: {Availability}";
        }
    }
}

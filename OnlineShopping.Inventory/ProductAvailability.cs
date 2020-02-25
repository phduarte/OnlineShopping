namespace OnlineShopping.Inventory
{
    public struct ProductAvailability
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public int Actual { get; set; }
        public string Description
        {
            get
            {
                if (Actual == 0)
                {
                    return "Vazio";
                }
                else if (Actual > Maximum)
                {
                    return "Lotado";
                }
                else if (Actual < Minimum)
                {
                    return "Acabando";
                }

                return "Disponível";
            }
        }

        public ProductAvailability(int actual, int minimum, int maximum)
        {
            Actual = actual;
            Minimum = minimum;
            Maximum = maximum;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
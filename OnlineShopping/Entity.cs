namespace OnlineShopping
{
    public abstract class Entity<T>
    {
        public virtual T Id { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}

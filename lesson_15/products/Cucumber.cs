namespace lesson_15
{
    class Cucumber : Product
    {
        private readonly int _count;
        public Cucumber(double basePrice, int count) : base("Cucumber", basePrice)
        {
            _count = count;
        }

        public int Count
        {
            get { return _count; }
        }

        public override double GetPrice()
        {
            return BasePrice * Count;
        }

        public override void PrintProductInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {BasePrice}, Count: {Count}, totalPrice: {GetPrice()}");
        }
    }
}

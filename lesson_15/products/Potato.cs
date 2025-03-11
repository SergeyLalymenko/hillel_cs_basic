namespace lesson_15
{
    class Potato : Product
    {
        private readonly int _count;
        public Potato(double basePrice, int count) : base(basePrice)
        {
            _count = count;
        }

        private int Count
        {
            get { return _count; }
        }

        public override double GetPrice()
        {
            return BasePrice * Count;
        }

        public override void PrintProductInfo()
        {
            Console.WriteLine($"Product: {GetType().Name}, Price: {BasePrice}, Count: {Count}, totalPrice: {GetPrice()}");
        }
    }
}

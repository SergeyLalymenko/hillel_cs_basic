namespace lesson_15
{
    class Product
    {
        private readonly double _basePrice;

        public Product(double basePrice)
        {
            _basePrice = basePrice;
        }

        protected double BasePrice
        {
            get { return _basePrice; }
        }

        public virtual double GetPrice()
        {
            return BasePrice;
        }

        public virtual void PrintProductInfo()
        {
            Console.WriteLine($"Product: {GetType().Name}, Price: {GetPrice()}");
        }
    }
}

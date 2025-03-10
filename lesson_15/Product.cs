namespace lesson_15
{
    class Product
    {
        private readonly string _name;
        private readonly double _basePrice;

        public Product(string name, double basePrice)
        {
            _name = name;
            _basePrice = basePrice;
        }

        public string Name
        {
            get { return _name; }
        }

        public double BasePrice
        {
            get { return _basePrice; }
        }

        public virtual double GetPrice()
        {
            return BasePrice;
        }

        public virtual void PrintProductInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {GetPrice()}");
        }
    }
}

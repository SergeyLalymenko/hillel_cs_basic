namespace lesson_15
{
    class VegetableShop
    {
        private readonly List<Product> _products = [];

        public List<Product> Products
        {
            get { return _products; }
        }

        public void AddProducts(List<Product> products)
        {
            Products.AddRange(products);
        }

        public void PrintProductsInfo()
        {
            if (Products.Count == 0)
            {
                Console.WriteLine("No products in the shop!");
                return;
            }

            double totalPrice = 0;

            foreach (Product product in Products)
            {
                double price = product.GetPrice();
                totalPrice += price;
                product.PrintProductInfo();
            }

            Console.WriteLine($"Total products price: {totalPrice}");
        }
    }
}

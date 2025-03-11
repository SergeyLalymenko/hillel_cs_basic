namespace lesson_15
{
    class VegetableShop
    {
        private readonly List<Product> _products = [];

        private List<Product> Products
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

            foreach (Product product in Products)
            {
                product.PrintProductInfo();
            }

            double totalPrice = Products.Sum((product) => product.GetPrice());

            Console.WriteLine($"Total products price: {totalPrice}");
        }
    }
}

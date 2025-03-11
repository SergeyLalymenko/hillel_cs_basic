//BasePrice та сам список продуктів по концепції мають бути закритими ззовні, навіть get.
//Необов'язково передавати на рівень базового класу ім'я продукту, для цього є спеціальний метод класу object GetType()
//Замість окремого методу GetPrice() можна перезаписати геттер властивості. Для цього постав virtual та override перед get
//Для розрахунку загальної ціни можна скористуватись LINQ

namespace lesson_15
{
    class Program
    {
        static void Main()
        {
            var products = new List<Product>()
            {
                new Carrot(15),
                new Potato(20, 4),
                new Cucumber(14, 2)
            };


            VegetableShop shop = new();
            shop.AddProducts(products);


            shop.PrintProductsInfo();
        }
    }
}

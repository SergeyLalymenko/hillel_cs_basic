//1.Додати клас VegetableShop, що може зберігати у собі різноманітні продукти. Також передбачити можливість поповнювати магазин новими продуктами.
//2. Додати класи, що являють собою продукти — Carrot, Potato, Tomato, Cucumber. Кожен овоч має приватне поле BasePrice, це ціна продукту. Але саме у картоплі та огірків ціна вказується за кілограм, тому для них ціна рахується за формулою Price = BasePrice * Count. Поле Count це кількість кілограмів продукту, це поле є тільки у картоплі і огірків, для всіх інших продуктів вважати що Price = BasePrice.
//3. Додати до класу VegetableShop можливість виводити повністю всю інформацію по наявних продуктах, зі вказуванням загальної ціни всіх продуктів.

namespace lesson_15
{
    internal class Program
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

string client = "";
string product = "";
string address = "";

for (int i = 1; i < 4; i++)
{
    Console.WriteLine("Enter client name: ");
    client = Console.ReadLine();
    Console.WriteLine("Enter product: ");
    product = Console.ReadLine();
    Console.WriteLine("Enter address: ");
    address = Console.ReadLine();

    Console.WriteLine($"Order No {i}\nClient: {client}.\nProduct: {product}.\nAddress: {address}.");
}

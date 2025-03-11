namespace lesson_16
{
    internal class Program
    {
        static void Main()
        {
            Provider provider = new();
            Sender sender = new();
            Processor processor = new(provider, sender);
            processor.Process();
        }
    }
}

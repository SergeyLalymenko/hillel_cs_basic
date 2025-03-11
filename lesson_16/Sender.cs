namespace lesson_16
{
    class Sender
    {
        public void Send(string content)
        {
            string destinationPath;

            do
            {
                Console.Write("Enter the path to the destination file: ");
            } while (!File.Exists(destinationPath = Console.ReadLine()));

            File.AppendAllText(destinationPath, content);
            Console.WriteLine("Done");
        }
    }
}

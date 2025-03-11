namespace lesson_16
{
    class Provider
    {
        public string Provide()
        {
            string sourcePath;

            do
            {
                Console.Write("Enter the path to the source file: ");
            } while (!File.Exists(sourcePath = Console.ReadLine()));

            return File.ReadAllText(sourcePath);
        }
    }
}

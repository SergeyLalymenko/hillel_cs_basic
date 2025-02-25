//Створіть окремий статичний клас. До нього треба додати рекурсивну функцію для обчислення числа Фібоначчі певного порядку. Метод приймає номер числа і повертає число Фібоначчі вказаного номеру. Вважати першим числом послідовності 0, другим — 1.
//Вхідний параметр: 3
//Вихідне значення: 1
//Вхідний параметр: 11
//Вихідне значення: 55

namespace lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Fibonacci.GetFibonacciNumber(11);
            Console.WriteLine($"Result: {result}");
        }
    }

    public static class Fibonacci
    {
        public static int GetFibonacciNumber(int n, int prevNumber = -1, int currentNumber = 1)
        {
            if (n < 1) return 0;

            int newNumber = prevNumber + currentNumber;
            prevNumber = currentNumber;
            currentNumber = newNumber;

            return n == 1 ? currentNumber : GetFibonacciNumber(n - 1, prevNumber, currentNumber);
        }
    }
}

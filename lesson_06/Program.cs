//1. Обчислення середнього заробітку: Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць. Після отримання всіх значень програма має обчислити та вивести середній заробіток.

//int employesAmount = 0;
//bool isFirstEmployeesAmountTry = true;

//do
//{
//    Console.WriteLine(isFirstEmployeesAmountTry ? "Enter employes amount from 1 to 5:" : "Invalid. Please try again:");
//    int.TryParse(Console.ReadLine(), out employesAmount);
//    isFirstEmployeesAmountTry = false;
//}
//while (employesAmount < 1 || employesAmount > 5) ;

//float salarySum = 0;
//float currentEmployeeSalary = 0;

//for (int i = 1; i <= employesAmount; i++)
//{
//    bool isFirstTry = true;
//    bool isSuccessParse = false;

//    do
//    {
//        Console.WriteLine(isFirstTry ? $"Enter {i} employee salary:" : $"Invalid. Please try again for {i} employee:");
//        isSuccessParse = float.TryParse(Console.ReadLine(), out currentEmployeeSalary);
//        isFirstTry = false;
//        if (isSuccessParse)
//        {
//            salarySum += currentEmployeeSalary;
//        }
//    } while (!isSuccessParse);
//}

//Console.WriteLine($"Middle: {salarySum / employesAmount}");

//2. Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок. Користувач повинен ввести кількість рядків графіка. Кожен рядок графіка має містити відповідну кількість зірочок.

//int rowsAmount = 0;
//bool isFirstTry = true;

//do
//{
//    Console.WriteLine(isFirstTry ? "Enter rows amount 1 or more:" : "Invalid. Please try again:");
//    int.TryParse(Console.ReadLine(), out rowsAmount);
//    isFirstTry = false;
//}
//while (rowsAmount < 1);

//for (int i = 1; i <= rowsAmount; i++)
//{
//    string row = "";

//    for (int j = 1; j <= i; j++)
//    {
//        row += "*";
//    }

//    Console.WriteLine(row);
//}

//3. Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. Просте число - це число, яке ділиться лише на 1 і на себе.

//int maxNumber = 0;
//bool isFirstTry = true;

//do
//{
//    Console.WriteLine(isFirstTry ? "Enter number 1 or more:" : "Invalid. Please try again:");
//    int.TryParse(Console.ReadLine(), out maxNumber);
//    isFirstTry = false;
//}
//while (maxNumber < 1);

//string resultNumbers = "";

//for (int currentNumber = 2; currentNumber <= maxNumber; currentNumber++)
//{
//    bool isPrime = true;

//    for (int iterableNumber = 2; (iterableNumber < currentNumber && isPrime); iterableNumber++)
//    {
//        isPrime = (currentNumber % iterableNumber) != 0;
//    }

//    if (isPrime)
//    {
//        resultNumbers += $"{currentNumber} ";
//    }
//}

//Console.WriteLine($"Result: {resultNumbers}");

//4. Перевірка паролю: Напишіть програму, яка перевіряє пароль користувача. Пароль вважається прийнятним, якщо він містить принаймні 8 символів, з яких принаймні один символ - це цифра, а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).

//using System.Text.RegularExpressions;

//Console.WriteLine("Enter password:");
//string input = Console.ReadLine();
//string pattern = @"^(?=.*\d)(?=.*[\W_]).{8,}$";
//bool isMatch = Regex.IsMatch(input, pattern);

//Console.WriteLine(isMatch ? "Password is correct." : "Password is incorrect.");

//5. Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі. Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.

//int numberAmount = 0;
//bool isFirstTry = true;

//do
//{
//    Console.WriteLine(isFirstTry ? "Enter number 1 or more:" : "Invalid. Please try again:");
//    int.TryParse(Console.ReadLine(), out numberAmount);
//    isFirstTry = false;
//}
//while (numberAmount < 1);

//int prevNumber = -1;
//int currentNumber = 1;
//string result = "";

//for (int i = 0; i < numberAmount; i++)
//{
//    int newNumber = prevNumber + currentNumber;
//    result += $"{newNumber} ";
//    prevNumber = currentNumber;
//    currentNumber = newNumber;
//}

//Console.WriteLine($"Result: {result}");

//6. Калькулятор оплати праці за годину: Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки. Після введення значень програма має обчислити та вивести оплату за день.

//float hoursInDay = 0;
//float moneyPerHour = 0;
//bool isFirstTryHours = true;
//bool isFirstTryMoney = true;

//do
//{
//    Console.WriteLine(isFirstTryHours ? "Enter hours:" : "Invalid. Please try again:");
//    float.TryParse(Console.ReadLine(), out hoursInDay);
//    isFirstTryHours = false;
//}
//while (hoursInDay <= 0);

//do
//{
//    Console.WriteLine(isFirstTryMoney ? "Enter money per hour:" : "Invalid. Please try again:");
//    float.TryParse(Console.ReadLine(), out moneyPerHour);
//    isFirstTryMoney = false;
//}
//while (moneyPerHour <= 0);

//Console.WriteLine($"Result: {hoursInDay * moneyPerHour}");

//7. Генерація таблиці множення для конкретного числа: Напишіть програму, яка запитує в користувача число, а потім генерує таблицю множення для цього числа від 1 до 10.

//float number = 0;
//bool isFirstTry = true;

//do
//{
//    Console.WriteLine(isFirstTry ? "Enter number:" : "Invalid. Please try again:");
//    isFirstTry = false;
//}
//while (!float.TryParse(Console.ReadLine(), out number));

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{number} * {i} = {number * i}");
//}

//8. Перевірка на простоту: Напишіть програму, яка перевіряє, чи є задане користувачем число простим. Число вважається простим, якщо воно ділиться лише на 1 і на себе.

//int number = 0;
//bool isFirstTry = true;

//do
//{
//    Console.WriteLine(isFirstTry ? "Enter number:" : "Invalid. Please try again:");
//    isFirstTry = false;
//}
//while (!int.TryParse(Console.ReadLine(), out number));

//if (number < 2)
//{
//    Console.WriteLine($"{number} is not prime");
//    return;
//}

//bool isPrime = true;

//for (int iterableNumber = 2; (iterableNumber < number && isPrime); iterableNumber++)
//{
//    isPrime = (number % iterableNumber) != 0;
//}

//Console.WriteLine(isPrime ? $"{number} is prime" : $"{number} is not prime");

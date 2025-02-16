//1.Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random (https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0) Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)
//2.Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.
//3. Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення (у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1, у другому – на 2, ..., в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.
//4. Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран: а) максимальний елемент масиву; б) мінімальний елемент масиву; в) координати мінімального елемента масиву. г) координати максимального елемента масиву.
//5. За допомогою enum створити програму, що буде запитувати у користувача кількість днів, а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат. Наприклад: 
//Приклад 1: Вхідний параметр: 13 Очікуваний вивід: Sunday
//Приклад 2: Вхідний параметр: 3 Очікуваний вивід: Thursday

// 1, 2
//int[] array = new int[10];
//Random random = new Random();
//int sum = 0;

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next(-10, 10);
//}

//for (int i = 0; i < array.Length; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(array[i]);
//    }
//}

//foreach (int num in array)
//{
//    sum += num;
//}

//if (sum < 0)
//{
//    Console.WriteLine("True");
//} else
//{
//    Console.WriteLine("False");
//}

// 3
//int[,] array = new int[9, 9];

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        int value = (i + 1) * (j + 1);
//        array[i, j] = value;
//    }
//}

// 4
//int[,] array = new int[5, 5];
//Random random = new Random();
//int maxNum = array[0, 0];
//int maxX = 1;
//int maxY = 1;
//int minNum = array[0, 0];
//int minX = 1;
//int minY = 1;

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i, j] = random.Next(-10, 10);
//    }
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        int value = array[i, j];

//        if (value > maxNum)
//        {
//            maxNum = value;
//            maxX = (j + 1);
//            maxY = (i + 1);
//        }

//        if (value < minNum)
//        {
//            minNum = value;
//            minX = (j + 1);
//            minY = (i + 1);
//        }
//    }
//}

//Console.WriteLine(maxNum);
//Console.WriteLine(maxX);
//Console.WriteLine(maxY);
//Console.WriteLine(minNum);
//Console.WriteLine(minX);
//Console.WriteLine(minY);

//5
//int num = 0;

//do
//{
//    Console.WriteLine("Enter number from 0:");
//} while (!int.TryParse(Console.ReadLine(), out num) || num < 0);

//num %= 7;
//Console.WriteLine($"Result: {(DaysOfWeek)num}");

//enum DaysOfWeek
//{
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}

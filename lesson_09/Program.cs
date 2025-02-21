// 1. Написати програму, що знаходить другий найбільший елемент масиву.

//int[] array = [2, 5, 6, 7, 3, 4, 7];
//int max = array[0];
//int secondMax = array[0];

//foreach (int num in array)
//{
//    if (num > max)
//    {
//        secondMax = max;
//        max = num;
//    }
//}

//Console.WriteLine(secondMax);

// 2. Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.

//int[,] matrix =
//{
//    { 1, 5, 6 },
//    { 4, 2, 3 },
//    { 9, 8, 7 }
//};

//List<int> array = [];

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        array.Add(matrix[i, j]);
//    }
//}

//array.Sort();

//int index = 0;

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        matrix[i, j] = array[index];
//        Console.WriteLine(matrix[i, j]);
//        index++;
//    }
//}

// 3. Написати програму, що буде видаляти з масиву елемент за вказаним індексом.

//List<int> array = [1, 2, 3, 4, 5];

//int index;

//do
//{
//    Console.WriteLine($"Enter index from 0 to {array.Count() - 1}:");
//} while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= array.Count());

//Console.WriteLine(array[index]);

// 4. Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

//int[,] matrix =
//{
//    { 1, 2, 3 },
//    { 1, -5, 3 },
//    { 1, 2, 7 }
//};
//int sum = 0;

//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            sum += matrix[i, j];
//        }
//    }
//}

//Console.WriteLine(sum);

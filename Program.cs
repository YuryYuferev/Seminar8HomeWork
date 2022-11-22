// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:                    В итоге получается вот такой массив:
// 1 4 7 2                                    7 4 2 1
// 5 9 2 3                                    9 5 3 2
// 8 4 2 4                                    8 4 4 2
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"\nЗадайте размер массива:");
        int m = InputNumbers("Введите m: ");
        int n = InputNumbers("Введите n: ");

        int[,] array = new int[m, n];
        CreateArray(array);
        WriteArray(array);

        Console.WriteLine($"\nУпорядоченный массив: ");
        OrderArrayLines(array);
        WriteArray(array);

        void OrderArrayLines(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1) - 1; k++)
                    {
                        if (array[i, k] < array[i, k + 1])
                        {
                            int temp = array[i, k + 1];
                            array[i, k + 1] = array[i, k];
                            array[i, k] = temp;
                        }
                    }
                }
            }
        }
        int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        void CreateArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1,10);
                }
            }
        }
        void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:      1 4 7 2
//                              5 9 2 3
//                              8 4 2 4
//                              5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"\nВведите размер массива m x n:");
        int m = InputNumbers("Введите m: ");
        int n = InputNumbers("Введите n: ");

        int[,] array = new int[m, n];
        CreateArray(array);
        WriteArray(array);
      
        int minSumLine = 0;
        int sumLine = SumLineElements(array, 0);
        for (int i = 1; i < array.GetLength(0); i++)
        {
            int tempSumLine = SumLineElements(array, i);
            if (sumLine > tempSumLine)
            {
                sumLine = tempSumLine;
                minSumLine = i;
            }
        }
        Console.WriteLine($"\nСтрока {minSumLine + 1} с наименьшей суммой элементов, равной {sumLine} ");
        int SumLineElements(int[,] array, int i)
        {
            int sumLine = array[i, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                sumLine += array[i, j];
            }
            return sumLine;
        }
        int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        void CreateArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0,10);
                }
            }
        }
        void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
*/
// Задача 62.Заполните спирально массив 4 на 4. Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
internal class Program
{
    private static void Main(string[] args)
    {
        int len = 4;
        int[,] table = new int[len, len];
        FillArraySpiral(table, len);
        PrintArray(table);
        void FillArraySpiral(int[,] array, int n)
        {
            int i = 0, j = 0;
            int value = 1;
            for (int e = 0; e < n * n; e++)
            {
                int k = 0;
                do { array[i, j++] = value++; } while (++k < n - 1);

                for (k = 0; k < n - 1; k++) array[i++, j] = value++;

                for (k = 0; k < n - 1; k++) array[i, j--] = value++;

                for (k = 0; k < n - 1; k++) array[i--, j] = value++;
                ++i; ++j;
                n = n < 2 ? 0 : n - 2;
            }
        }
        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 10)
                    {
                        Console.Write("0" + array[i, j]);
                        Console.Write(" ");
                    }
                    else Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
*/
// Задача 62 (вариант 2). Заполните спирально массив 6 на 6. Например, на выходе получается вот такой массив:
/*
internal class Program
{
    private static void Main(string[] args)
    {
        int len = 6;
        int[,] table = new int[len, len];
        FillArraySpiral(table, len);
        PrintArray(table);
        void FillArraySpiral(int[,] array, int n)
        {
            int i = 0, j = 0;
            int value = 1;
            for (int e = 0; e < n * n; e++)
            {
                int k = 0;
                do { array[i, j++] = value++; } while (++k < n - 1);

                for (k = 0; k < n - 1; k++) array[i++, j] = value++;

                for (k = 0; k < n - 1; k++) array[i, j--] = value++;

                for (k = 0; k < n - 1; k++) array[i--, j] = value++;
                ++i; ++j;
                n = n < 2 ? 0 : n - 2;
            }
        }
        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 10)
                    {
                        Console.Write("0" + array[i, j]);
                        Console.Write(" ");
                    }
                    else Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
*/


/*  Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с
 наименьшей суммой элементов: 1 строка (нумерация строк начинается с 1)*/

Main(args);
  
void Main(string[] args)
{

    Console.WriteLine("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = GetArray(rows, columns, 0, 10);
    PrintArray(array);

    Console.WriteLine($"Индекс строки с наименьшей суммой:   {GetRowNumber(array)}.  Не смогла сделать переиндексацию.");

    int[,] GetArray(int m, int n, int min, int max)
    {
        int[,] result = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(min, max + 1);
            }
        }
        return result;
    }
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    int GetRowNumber(int[,] array)
    {
        int row = 0;
        int minsum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            minsum = minsum + array[0, i];
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + array[i, j];
            }
            if (minsum > sum)
            {
                minsum = sum;
                row = i;
            }
        }
        return row;
    }
}

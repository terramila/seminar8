/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Main();
void Main()
{
    int[][] sorted = new int[4][];
    sorted[0] = new int[4];
    sorted[1] = new int[4];
    sorted[2] = new int[4];


    Random random = new Random();
    for (int i = 0; i < sorted[0].Length; i++)
        sorted[0][i] = random.Next(0, 10);
    for (int i = 0; i < sorted[1].Length; i++)
        sorted[1][i] = random.Next(0, 10);
    for (int i = 0; i < sorted[2].Length; i++)
        sorted[2][i] = random.Next(0, 10);


    Console.WriteLine("Исходный массив");
    for (int i = 0; i < sorted[0].Length; i++)
        Console.Write(sorted[0][i] + " ");
    Console.WriteLine();
    for (int i = 0; i < sorted[1].Length; i++)
        Console.Write(sorted[1][i] + " ");
    Console.WriteLine();
    for (int i = 0; i < sorted[2].Length; i++)
        Console.Write(sorted[2][i] + " ");
    Console.WriteLine();


    for (int i = 0; i < sorted[0].Length; i++)
        Array.Sort(sorted[0]);
    for (int i = 0; i < sorted[1].Length; i++)
        Array.Sort(sorted[1]);
    for (int i = 0; i < sorted[2].Length; i++)
        Array.Sort(sorted[2]);


    Console.WriteLine("\nОтсортированный массив");
    for (int i = 0; i < sorted[0].Length; i++)
        Console.Write(sorted[0][i] + " ");
    Console.WriteLine();
    for (int i = 0; i < sorted[1].Length; i++)
        Console.Write(sorted[1][i] + " ");
    Console.WriteLine();
    for (int i = 0; i < sorted[2].Length; i++)
        Console.Write(sorted[2][i] + " ");


}


/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Main(args);

void DisplayArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++) Console.Write("{0,3} ", a[i, j]);
        Console.WriteLine();
    }
}

void Main(string[] args)
{
    int n = 4;

    int[,] a = new int[n, n];

    int i = 0, j = 0;

    int value = 1;

    while (n != 0)
    {
        int k = 0;
        do { a[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) a[i++, j] = value++;
        for (k = 0; k < n - 1; k++) a[i, j--] = value++;
        for (k = 0; k < n - 1; k++) a[i--, j] = value++;

        ++i; ++j; n = n < 2 ? 0 : n - 2;
    }

    DisplayArray(a);
    Console.WriteLine();

}

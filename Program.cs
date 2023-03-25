// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// На входе - натуральное число от пользователя, например 4.
// Тогда на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//https://github.com/profimars/Task62
void CreateMatrix(string[,] A)
{
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    int k = 1;
    int i = 0;
    int j = 0;
    string kk = "";
    while (k <= n * n)
    {
        if (k < 10)
            kk = "0" + k;
        else
            kk = Convert.ToString(k);
        A[i, j] = kk;
        if (i <= j + 1 && i + j < n - 1)
            j++;
        else if (i < j && i + j >= n - 1)
            i++;
        else if (i >= j && i + j > n - 1)
            j--;
        else
            i--;
        k++;
    }
}

void PrintMatrix(string[,] A)
{
    Console.WriteLine();
    int m = A.GetLength(0);
    int n = A.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            string element = A[i, j];
            Console.Write($"{element,3}({i},{j}) ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите первое измерение матрицы m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе измерение матрицы n");
int n = Convert.ToInt32(Console.ReadLine());
string[,] A = new string[m, n];
CreateMatrix(A);
PrintMatrix(A);
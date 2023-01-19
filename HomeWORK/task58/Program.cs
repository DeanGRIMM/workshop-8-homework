// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array1.GetLength(1); j++)
            array1[i, j] = new Random().Next(0, 10);
    for (int i = 0; i < array2.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
            array2[i, j] = new Random().Next(0, 10);
}
void PrintArray(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
            Console.Write($"{array1[i, j],2} \t");
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
            Console.Write($"{array2[i, j],2} \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ProdArray(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array3[i,j]= 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    array3[i,j]+=array1[i,k]*array2[k,j];
                }
                Console.Write($" {array3[i, j],2} \t");
            }
            Console.WriteLine();
        }
    }
    return array3;
}



Console.Write("Введите количество столбцов и строк: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[n, n];
int[,] array2 = new int[n, n];
FillArray(array1, array2);
PrintArray(array1, array2);
Console.WriteLine("произведение двух матриц");
ProdArray(array1, array2);


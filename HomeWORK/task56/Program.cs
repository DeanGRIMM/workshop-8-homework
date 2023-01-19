// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2} \t");
        Console.WriteLine();
    }
}
void CountArray(int[,] array)
{
    int[] countarray = new int[10];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            countarray[array[i,j]]++;


    for (int l = 0; l < 10; l++) 
    {
       if (countarray[l] != 0)
       Console.WriteLine($" Число {l} встречается {countarray[l]}");
    }
            
}


Console.Write("Введите количество строк: ");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int numCols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[numRows, numCols];

FillArray(array);
PrintArray(array);
Console.WriteLine("Массив после замены строк:");
CountArray(array);
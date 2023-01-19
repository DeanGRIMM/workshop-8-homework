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
void SumArray(int[,] array)
{
    int SumMin1 = 0;
    int SumMin2 = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumMin1+=array[i,j];
        }
        if (SumMin2>SumMin1 || i == 0)
        {
            SumMin2 = SumMin1;
            index = i;
        }
        SumMin1 = 0;
    }
    Console.WriteLine($"строка с наименьшей суммой = {SumMin2} является строка под номером {index}");

}


Console.Write("Введите количество строк: ");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int numCols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[numRows, numCols];

FillArray(array);
PrintArray(array);
Console.WriteLine();
SumArray(array);
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.WriteLine("Введите число строк массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int [m,n];
FillRndArray(matrix);
PrintArray (matrix);
SortArray(matrix);

void PrintArray (int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Console.Write($"{matr[i, j]} ");
}
Console.WriteLine();
}
}
void FillRndArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Random rand = new Random();
matr[i, j] = rand.Next(1, 10);
}
}
}

void SortArray(int[,] matr)
{
    int [] sort = new int[n];
    int index = 0;
for (int i = 0; i<matr.GetLength(0); i++)
 {
   for (int j = 0; j<matr.GetLength(1); j++)
   {
    if (matr [i,j]> matr [i+1,j])
    {
        
        sort [index] = matr [i,j];
        index++;

    }
    else
    {
        index++;
    }

   }
 }
 for (int i = 0; i<sort.Length;i++)
 {
    Console.WriteLine(sort);
    
 }
}

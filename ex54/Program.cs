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
Console.WriteLine();
SortArray(matrix);
PrintArray (matrix);


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
for (int i = 0; i<matr.GetLength(0); i++)
 {
   for (int j = 0; j<matr.GetLength(1); j++)
   {
    for (int a = 0; a < matr.GetLength(1) - 1; a++)
      {
        if (matr[i, a] > matr[i, a + 1])
        {
          int temp = matr[i, a + 1];
          matr[i, a + 1] = matr[i, a];
          matr[i, a] = temp;
        }
      }
   }
 }
}



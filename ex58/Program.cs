// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

Console.WriteLine("Введите число строк массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrixA = new int [m,n];
int [,] matrixB = new int [m,n];
int [,] matrixMultip = new int [m,n];

FillRndArray(matrixA);
FillRndArray(matrixB);
PrintArray (matrixA);
Console.WriteLine();
PrintArray (matrixB);
Console.WriteLine();
MultipArray(matrixA, matrixB, matrixMultip);
Console.Write($"Произведение матриц будет равно следующему массиву:");
Console.WriteLine();
PrintArray (matrixMultip);

void PrintArray (int[,] matr) //печать
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

void FillRndArray(int[,] matr) //заполнение
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

void MultipArray(int[,] matrA, int[,] matrB, int[,] matrC)
{
for (int i = 0; i < matrC.GetLength(0); i++)
{
for (int j = 0; j < matrC.GetLength(1); j++)
{
matrC[i, j] = matrA[i,j]*matrB[i,j];
}
}
}

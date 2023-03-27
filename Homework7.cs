 /*
  //Task 47. Specify a two-dimensional m×n array filled with random numbers.

    void FillMatrixWithRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintMatrix(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} \t");
}
Console.WriteLine();
}
}
    Console.Write("Input a number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
*/

/*
  // Task 50. Write a program that takes the position of an element in a two-dimensional array as input and returns the value of that element or an indication that there is no such element.
    
int[,] FillMatrixWithRandom(int row, int column)
{
int[,] array = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(0, 10);
}
}
return array;
}

void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} \t");
}
Console.WriteLine();
}
}
    
Console.Write("Input a number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

  Console.Write("Input a row position: ");
 int rowPosition = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a column position: ");
 int columnPosition = Convert.ToInt32(Console.ReadLine());
 if (rowPosition > row || columnPosition > column)
 Console.WriteLine("No such element");
 else
 {
 object number = matrix.GetValue(rowPosition,columnPosition);
 Console.WriteLine(number);
 }
  */ 

/*
  // Task 52. Specify a two-dimensional array of integers. Find the arithmetic mean of the elements in each column.

int[,] FillMatrixWithRandom(int row, int column)
{
int[,] array = new int[row, column];
Random rnd = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = rnd.Next(0, 10);
}
}
return array;
}

void PrintMatrix(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
}

 void Average(int[,] array)
    {
  for(int j = 0; j < array.GetLength(1); j++)
  {
    double averageNumber = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
      averageNumber = averageNumber + array[i, j];
    }
    averageNumber = averageNumber / array.GetLength(0);
    Console.Write($"{Math.Round(averageNumber, 2)}, ");
    }
    }


Console.Write("Input a number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
Console.Write("The average number are: ");
Average(matrix);
  */

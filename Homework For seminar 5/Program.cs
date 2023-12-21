// 1. Задача Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
using System.ComponentModel.DataAnnotations;

int[,] arr = new int[3,4];

for (int i = 0; i < arr.GetLength(0); i++)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  { 
     arr[i,j]= new Random().Next(0,150);
     
  }
}
/*
void GetArrayValue(int row,int column,int[,] arr)
{
      if(rows < 0 || row > arr.GetLength(0)||column < 0 || column >arr.GetLength(1)) Console.WriteLine("Index out of range");
      else
      {
             Console.WriteLine(arr[row,column]);
      }

}
GetArrayValue(8,8,arr);*/

// 2. Задача  Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

  /*int[,] ChangeArrayFirstAndLastElemnts(int[,] arr)
  {
    int temp = arr[0,0];
    arr[0,0] = arr[arr.GetLength(0)-1,arr.GetLength(1)-1];
    arr[arr.GetLength(0)-1,arr.GetLength(1)-1] = temp;
 
    return arr;
  }

  for (int i = 0; i < arr.GetLength(0); i++)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  { 
    Console.Write(arr[i,j]+" ");
  }
  Console.WriteLine();
}
arr = ChangeArrayFirstAndLastElemnts(arr);
Console.WriteLine();
 for (int i = 0; i < arr.GetLength(0); i++)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  { 
    Console.Write(arr[i,j]+" ");
  }
  Console.WriteLine();
}
*/

// 3. задача  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*int min = 0;
int sum = 0;
int row = 0;
for (int i = 0; i <arr.GetLength(0) ; i++)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  {
      
      sum =+ arr[i,j];

  }
  if(i==0) min = sum;
  else if(min > sum) {
    min = sum ;
    row = i;
    }
  sum = 0; 
}
 for (int i = 0; i < arr.GetLength(0); i++)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  { 
    Console.Write(arr[i,j]+" ");
  }
  Console.WriteLine();
}
Console.WriteLine(row);*/

//4. задача (не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на 
//пересечении которых расположен наименьший элемент массива. Под удалением понимается создание нового двумерного массива без строки и столбца
int[,] DeleteingArrayelements(int[,]arr)
{
  int minRow = 0;
  int minColumn =0;

  for (int i = 0; i <arr.GetLength(0) ; i++)
  {   
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if(arr[i,j]<arr[minRow,minColumn]) {
        minRow = i;
        minColumn = j;
      }
    }

  }
  Console.WriteLine($"Index of min row and column {minRow},{minColumn}");

  int[,] resultArr = new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
  int resultArrRow = 0;
  int resultArrColumn = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
   
 
    for (int j = 0; j < arr.GetLength(1); j++)
    {
       if( j != minColumn && i !=minRow  ) 
        {
           resultArr[resultArrRow,resultArrColumn] = arr[i,j];
           resultArrColumn++;
         
        }
        
    }
     resultArrColumn = 0;
     if(minRow!=i)resultArrRow++;
  }
  return resultArr;
}

for (int i = 0; i < arr.GetLength(0); i++)
{
  for (int j = 0; j < arr.GetLength(1); j++)
  { 
    Console.Write(arr[i,j]+" ");
  }
  Console.WriteLine();

}

int[,] resultArr = DeleteingArrayelements(arr);


 Console.WriteLine("result");
for (int i = 0; i < resultArr.GetLength(0); i++)
{
  for (int j = 0; j < resultArr.GetLength(1); j++)
  { 
    Console.Write(resultArr[i,j]+" ");
  }
  Console.WriteLine();
}


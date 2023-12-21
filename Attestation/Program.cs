//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
/*void Printnum(int num1,int num2){
    if((num1 +1)== num2) return;
    Console.WriteLine(num1+1);
    Printnum(num1+1,num2);
}
Printnum(15,20);*/

//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/*int Akerman(int m , int n)
{
  if(m == 0) return n+1;
  else if(m>0 && n==0 ) return Akerman((m-1),1);
  else return Akerman(m-1,Akerman(m,n-1));

}
Console.WriteLine(Akerman(2,4));*/

//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
int[] arr = {1,2,3,4,5};

void PrinrArray(int[] arr,int length)
{
   if((length-1)<0) return;
   Console.WriteLine(arr[length-1]);
   PrinrArray(arr,length-1);

}
PrinrArray(arr,arr.Length);
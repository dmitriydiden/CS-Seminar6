// Реверс массива (перестановка элементов массива)
using System;
using System.Linq;
Console.Clear();

/*Вариант 1. 

int[] Array =new int[5].Select(x=>x=new Random().Next(0,10)).ToArray();
Console.WriteLine(String.Join(" ", Array));
Console.WriteLine(String.Join(" ", Array.Reverse()));
*/

/*Вариант 2.
int length=10;
int[] Array =new int[10].Select(x=>x=new Random().Next(0,20)).ToArray();
Console.WriteLine(String.Join(" ", Array));

for (int i = 0; i < length/2; i++)
{
    int k=Array[i];
    Array[i]=Array[length-i-1];
    Array[length-i-1]=k;
}
Console.WriteLine(String.Join(" ", Array));*/
//Вариант 3.
int length=10;
int[] Array =new int[10].Select(x=>x=new Random().Next(0,20)).ToArray();
Console.WriteLine(String.Join(" ", Array));

int[] Array1= new int[length];
for (int i = 0; i < length; i++)
{
    Array1[length-i-1]=Array[i];
}
Console.WriteLine(String.Join(" ", Array1));
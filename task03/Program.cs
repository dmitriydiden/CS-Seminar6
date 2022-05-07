// Задача №42 Написать программу, которая будет преобразовывать десятичное числов в двоичное
using System;
using System.Linq;
Console.Clear();
//Вариант 1
Console.Write("Введите десятичное число - ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Convert.ToString(i,2));
// Вариант 2
Console.WriteLine(DecToNum(6,2));

string DecToNum(int decNumber, int otherSystem)
{
    string res="";
    string nums = "0123456789ABCDEFG";
    while(decNumber>0)
    {
        int ost = decNumber/otherSystem;
        res=nums[decNumber-otherSystem*ost]+res;
        decNumber/=otherSystem;
    }
    return res;
}
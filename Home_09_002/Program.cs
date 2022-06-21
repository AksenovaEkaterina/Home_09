// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int SumNum (int m, int n)
{
    if(m>n) return 0;
    return SumNum(m , n-1)+n;
   
}
Console.Write(SumNum (1, 6));


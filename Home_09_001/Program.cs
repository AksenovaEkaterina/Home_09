//Задайте значения M и N. Напишите программу, которая выведет 
//все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void Num (int N, int M)
{
    if(N>M) return;
    Num (N, M-2);
    Console.Write($"{M} ");
}
Num (1,10);
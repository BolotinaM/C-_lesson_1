// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N.

int P = 0;

Console.WriteLine("Введите значиение целого числа N");
int N = int.Parse(Console.ReadLine());

if (N >= 1)
{
    while (P < N-1)
    {
        P = P+2;
        Console.Write(P);
        Console.Write(",");
        
    }
}
if (N <= 1)
{
     while (N <= P)
    {
        Console.Write(P);
        Console.Write(",");
        P = P-2;
    }
}

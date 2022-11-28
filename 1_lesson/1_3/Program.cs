// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите целое числое");
int N = int.Parse(Console.ReadLine());

int N1 = (N*(-1));

// Console.WriteLine(N1);

if (N>0)
{
    while (N1 <= N)
    {
        Console.WriteLine($"{N1}");
        N1 += 1;
    }
}
else
{
     while (N <= N1)
    {
        Console.WriteLine($"{N}");
        N += 1;
    }
}

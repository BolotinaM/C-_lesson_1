// Напишите программу вычисления модуля числа

Console.WriteLine("Введите целое числое");
int N = int.Parse(Console.ReadLine());

if (N < 0)
{
    N = N*(-1);
    Console.WriteLine(N);
}
else
{
    Console.WriteLine(N);
}
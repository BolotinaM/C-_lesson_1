// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое - меньшее.

int Max = 0;
int Min = 0;

Console.WriteLine("Введите значение первого целого числа");
int N1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение второго целого числа");
int N2 = int.Parse(Console.ReadLine());

if (N1 > N2)
{
    Max = N1;
    Min = N2;
    Console.Write("Максимальное значение = ");
    Console.WriteLine(Max);
    Console.Write("Минимальное значение = ");
    Console.WriteLine(Min);
}
if (N2 > N1)
{
    Max = N2;
    Min = N1;
    Console.Write("Максимальное значение = ");
    Console.WriteLine(Max);
    Console.Write("Минимальное значение = ");
    Console.WriteLine(Min);
}
else
{
    Console.WriteLine("Значения равнозначны");
}
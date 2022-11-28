// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел

int Max = 0;

Console.WriteLine("Введите значение первого целого числа");
int N1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение второго целого числа");
int N2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение третьего целого числа");
int N3 = int.Parse(Console.ReadLine());

if (N1 > Max)
{
    Max = N1;
}
if (N2 > Max)
{
    Max = N2;
}
if (N3 > Max)
{
    Max = N3;
}

Console.Write("Максимальное значение = ");
Console.WriteLine(Max);
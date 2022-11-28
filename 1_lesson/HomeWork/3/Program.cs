// Напишите программу, которая на вход принимает число и выдаёт,
// является ли оно чётным (дилится ли она на 2 без остатка).

Console.WriteLine("Введите значение целого числа N");
int N = int.Parse(Console.ReadLine());

if (N % 2 == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

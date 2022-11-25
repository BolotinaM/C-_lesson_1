// Создайте программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine("Введите порядковый номер дня недели, где 1 - понедельник, 7 - воскресенье");
int NumDay = int.Parse(Console.ReadLine());

if (NumDay == 1)
{
    Console.WriteLine("Monday");
}
if (NumDay == 2)
{
    Console.WriteLine("Tuesday");
}
if (NumDay == 3)
{
    Console.WriteLine("Wednesday");
}
if (NumDay == 4)
{
    Console.WriteLine("Thursday");
}
if (NumDay == 5)
{
    Console.WriteLine("Friday");
}
if (NumDay == 6)
{
    Console.WriteLine("Saturday");
}
if (NumDay == 7)
{
    Console.WriteLine("Sunday");
}
else 
{
    Console.WriteLine("Try again");   
}
internal class Program
{
    private static void Main(string[] args)
    {
        // Квадрат числа
        Console.WriteLine("Write a number");

        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(num * num);
    }
}
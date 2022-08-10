// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите любое трехзначное положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 99 || number >= 1000)
{
    Console.WriteLine("Введено не верное число");
}
else
{
    Console.WriteLine(number % 100 / 10);
}
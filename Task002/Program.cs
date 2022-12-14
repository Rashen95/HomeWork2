// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите любое положительное число, а я выведу на экран 3ю цифру данного числа: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 99)
{
    Console.Write("в данном числе меньше 3х цифр!");
}
else
{
    while (number / 10 > 99)
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}

// Пояснение
// 153 % 10 = 3
// 1534 / 10 % 10 = 153.4 % 10 = 3
// 15345 / 100 % 10 = 153.45 % 10 = 3 
// Любое число можно привети к трем знакам перед запятой с помощью деления на 10 
// Нужно лишь найти этот делитель
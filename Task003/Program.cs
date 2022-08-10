// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите цифру обозначающую день недели, а я скажу вам является ли это день выходным: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7 )
{
    Console.Write("Такого дня недели не существует");
}
else
{
    switch (number)
    {
        case 1: Console.WriteLine("Это понедельник, к сожалению он не является выходным");
        break;
        case 2: Console.WriteLine("Это вторник, к сожалению он не является выходным");
        break;
        case 3: Console.WriteLine("Это среда, к сожалению он не является выходным");
        break;
        case 4: Console.WriteLine("Это четверг, к сожалению он не является выходным");
        break;
        case 5: Console.WriteLine("Это пятница, к сожалению он не является выходным, но уже близится отдых");
        break;
        case 6: Console.WriteLine("Это суббота, да, это выходной");
        break;
        case 7: Console.WriteLine("Это воскресенье, да, это выходной");
        break;
    }
}
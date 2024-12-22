using System;
DateTime dateTime = DateTime.Now;
int d = (int)dateTime.DayOfWeek;

if (d == 0)
{
    Console.WriteLine("Воскресенье");
}
else if  (d == 1)
{
    Console.WriteLine("Понедельник");
}
else if(d == 2)
{
    Console.WriteLine("вторник");
}
else if (d == 3)
{
    Console.WriteLine("Среда");
}
else if (d == 4)
{
    Console.WriteLine("четверг");
}
else if (d == 5)
{
    Console.WriteLine("Пятница");
}
else if (d == 6)
{
    Console.WriteLine("Суббота");
}
Console.WriteLine(d);

Console.WriteLine($"сейчас {dateTime}");

    

    Console.Write("Введите Дату вашего дня рождения :");
    DateTime d2 = DateTime.Parse(Console.ReadLine());
    if (dateTime.CompareTo(d2) < 0) Console.WriteLine($" ваш день рождения через {d2 - dateTime} ");
    else if (dateTime.CompareTo(d2) == 0) Console.WriteLine($"ваш день рождения сегодня !!!!");
    else Console.WriteLine($" ваш день рождения был {dateTime - d2}  ") ;
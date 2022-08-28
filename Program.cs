// See https://aka.ms/new-console-template for more information
// Задание №2.
Console.WriteLine("Задание №2");
Console.WriteLine("Введите число 1");

int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");

int number2 = int.Parse(Console.ReadLine());

if (number1 < number2)
{
    Console.WriteLine($"{number2} max");
}
else 
{
    Console.WriteLine($"{number1} max");
}

// Задание №4.
Console.WriteLine("Задание №4");
Console.WriteLine("Введите число 1");

int number3 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");

int number4 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3");

int number5 = int.Parse(Console.ReadLine());

if (number3<number4)
{
    if (number4<number5)
    {
        System.Console.WriteLine($"{number5} максимальное число");
    }
    else 
    {
        System.Console.WriteLine($"{number4} максимальное число");
    }
}
else if (number3<number5)
{
    System.Console.WriteLine($"{number5} максимальное число");
}
else 
{ 
    System.Console.WriteLine($"{number3} максимальное число");
}


// Задание 6.
Console.WriteLine("Задание №6");
Console.WriteLine("Введите число 1");

int number6 = int.Parse(Console.ReadLine());

if (number6 % 2 == 0)
 {
    System.Console.WriteLine($"{number6} четное");
}
else 
{
    System.Console.WriteLine($"{number6} нечетное");
}

// Задание №8.
Console.WriteLine("Задание №8");
Console.WriteLine("Введите число 1");

int number7 = int.Parse(Console.ReadLine());
for (int i = 1; i < (number7 +1); i++)
{
    if (i % 2 == 0)
    { 
        System.Console.WriteLine(i);
    }
}







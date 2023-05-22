// Напишите программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
    Console.WriteLine($"{numberA} является квадратом {numberB}");
else
{
    Console.WriteLine($"{numberA} не является квадратом {numberB}");
}



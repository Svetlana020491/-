// напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)
Console.WriteLine("Введите число");

int numberA = Convert.ToInt32(Console.ReadLine());

int result = numberA * numberA;

Console.WriteLine($"квадрат числа {numberA} равен {result}");

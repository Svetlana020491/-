// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine()); // -8
number = Math.Abs(number);
int counter = - number;
while (counter < - number)
{        Console.Write($"{counter} ");
        counter++;
}
Console.WriteLine();


// напишите программу вычесления значения функции возведения числа в квадрат

int Square(int number)
{
    int result = number * number;
    return result;
}

void Task0()
{

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} * {number} = {Square(number)}");

}

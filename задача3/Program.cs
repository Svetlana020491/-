
// напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3-> среда
// 5-> пятница
//Console.WriteLine("Введите число соотсетствующие дню недели. Например: понедельник = 1, вторник = 2");
//int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число соотсетствующие дню недели");
int numberA = Convert.ToInt32(Console.ReadLine()); 
if (numberA == 1) Console.WriteLine("Сегодня Понедельник");
else if (numberA == 2) Console.WriteLine("Сегодня Вторник");
else if (numberA == 3) Console.WriteLine("Сегодня Среда");
else if (numberA == 4) Console.WriteLine("Сегодня Четверг");
else if (numberA == 5) Console.WriteLine("Сегодня Пятница");
else if (numberA == 6) Console.WriteLine("Сегодня Суббота");
else if (numberA == 7) Console.WriteLine("Сегодня Воскресенье");
else Console.WriteLine("Ошибка! Введите число от 1 до 7");
  
  
  
  

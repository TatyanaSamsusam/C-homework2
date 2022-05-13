// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Примеры:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("введите число, и я покажу его третью цифру");
int number = int.Parse(Console.ReadLine());

if(number < 100) Console.WriteLine("у этого числа нет третьей цифры");

if (number > 100)
{
    string hadNoChoice = number.ToString();
    Console.WriteLine($"третья цифра введенного числа:" + hadNoChoice[2]);
}


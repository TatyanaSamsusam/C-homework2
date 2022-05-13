// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Примеры:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("введите трехзначное число, и я покажу его вторую цифру");
int number = int.Parse(Console.ReadLine());

if(number > 99 && number < 1000) Console.WriteLine($"вы ввели число {number}");
else Console.WriteLine("число не трехзначное!");

int FindSecondDigit (int number)
{
    int sub = number / 10;
    int finaldigit = sub % 10;
    return finaldigit;
}

int secondDigitMethod = FindSecondDigit(number);
Console.WriteLine($"вторая цифра этого числа: {secondDigitMethod}");
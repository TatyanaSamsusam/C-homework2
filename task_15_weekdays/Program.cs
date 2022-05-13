// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Примеры:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите число от 1 до 7. они будут соответствовать дням недели. я скажу, является ли этот день выходным");
int number = int.Parse(Console.ReadLine());

if (number == 1) Console.WriteLine("нет, это понедельник");
if (number == 2) Console.WriteLine("нет, это вторник");
if (number == 3) Console.WriteLine("нет, это среда");
if (number == 4) Console.WriteLine("нет, это четверг");
if (number == 5) Console.WriteLine("нет, это пятница");
if (number == 6) Console.WriteLine("да, это суббота");
if (number == 7) Console.WriteLine("да, это воскресенье");
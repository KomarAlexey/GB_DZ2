// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.Clear();
// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int secondnum = num / 10 % 10;

// Console.WriteLine($"Вторая цифра в числе {num} -> {secondnum}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 100)
// {
//     Console.WriteLine($"Третий цифры нет");
//     return;
// }
// int thirdnum = num % 10;
// Console.WriteLine($"Третья цифра числа {num} -> {thirdnum}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if ((num > 7) || (num <1 ))
// {
//     Console.WriteLine($"Неверный день недели");
//     return;
// }
// if (num > 5)
// {
//     Console.WriteLine($"Да");
// }
// else
// {
//     Console.WriteLine($"нет");
// }

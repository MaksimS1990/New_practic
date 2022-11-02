// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трёхзначное число.");
int number = int.Parse(Console.ReadLine()!);
int firstDigit = (number / 100) * 10;
int SecondDigit = number % 10;
int thirdDigit = firstDigit + SecondDigit;
Console.WriteLine("После удаление второй цифры число получилось: " + thirdDigit);

Console.WriteLine("Введите любое число");
int number = int.Parse(Console.ReadLine()!);
int a = number / 10;
int temp = a % 10;
Console.WriteLine("Вторая цифра числа: " + temp);
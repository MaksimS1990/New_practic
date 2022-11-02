Console.WriteLine("введите число от 1 до 7");
int number = int.Parse(Console.ReadLine()!);

DayOffWeek(number);

void DayOffWeek(int number){
if (number > 0 && number < 8){
if (number == 1) Console.WriteLine("Понедельник");
if (number == 2) Console.WriteLine("Вторник");
if (number == 3) Console.WriteLine("Среда");
if (number == 4) Console.WriteLine("Четверг");
if (number == 5) Console.WriteLine("Пятница");
if (number == 6) Console.WriteLine("Суббота");
if (number == 7) Console.WriteLine("Воскресенье");
}
if (number > 0 && number < 6){
    Console.WriteLine("Нет, данный день не является выходным!");
}
if (number == 6 || number == 7){
    Console.WriteLine("Да! Этот день является выходным!");
}
}
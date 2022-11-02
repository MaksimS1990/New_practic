Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);

void resKrat(int a, int b){

    int result = a % b;

if (result == 0)
{
    Console.WriteLine("Да. Первое число кратно второму!");
}

else 
{
    Console.WriteLine("остаток от деления составляет: " + result);
}
}

resKrat(a, b);
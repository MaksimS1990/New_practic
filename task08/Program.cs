Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);

if (Ampersant(a, b))
{
    Console.WriteLine("Да, одно число является амперсантом другого!");
}
else
{
    Console.WriteLine("Нет,ни одно из чисел не является амперсантом другого!");
}

bool Ampersant(int a, int b)
{
    return a == b * b || b == a * a;
}
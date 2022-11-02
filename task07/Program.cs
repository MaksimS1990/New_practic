Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);

if(multiplicity(a))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

bool multiplicity(int a)
{
    return a % 7 ==0 && a % 23 == 0;
}
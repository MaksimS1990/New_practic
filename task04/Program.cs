Console.WriteLine("Введите целое число");
int input = int.Parse(Console.ReadLine()!);

if (input < 9){
    Console.WriteLine("Второй цифры нет!");
}
else
{
    void DeleteSecondDigit(int input)
    {
        int sum = 0;
        int numberPosition = 1;
        while (input > 99){
            int div = input % 10;
            sum = sum + div * numberPosition;
            numberPosition = numberPosition * 10;
            input = input / 10;
        }
        input = input / 10;
        int result = input * numberPosition + sum;
        Console.WriteLine("Число, после удаления второй цифры: " + result);
    }
    DeleteSecondDigit(input);
}
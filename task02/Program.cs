Console.WriteLine("Введите любое трехзначное число");
int number = int.Parse(Console.ReadLine()!);

if (number < 100){
    Console.WriteLine("Третьей цифры нет!");
}


if (number < 1000 && number > 99){

    getThirdDigit(number); 
    //number = number % 10;
    //Console.WriteLine("Третья цифра числа: " + number);
}

int getThirdDigit(int number){
    number = number % 10;
    Console.WriteLine("Третья цифра числа: " + number);
    return number;
}
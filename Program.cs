Console.WriteLine("Введите трехзначное  число");
int number = int.Parse(Console.ReadLine()!);

int IsSecondDigit(int number)
{
    int SecondDigit = number / 10 % 10;
    return SecondDigit;
}

int  res = IsSecondDigit(number);
Console.WriteLine(res);
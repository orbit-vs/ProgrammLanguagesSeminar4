int NumDigits(int num)
{
    if (num < 1)
    num = Math.Abs(num);

    int ind = 0;
    while ( num > 0)
    {
        num /= 10;
        ind ++;
    }

    return ind;
}    

Console.WriteLine("Программа показывает колличество цифр в веденом числе ");
Console.WriteLine("Введено число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumberDigits(num));


if (num < 0)
{
    Console.WriteLine("Введено число меньше 1. Выполнение программы прерванно.");
    return;
}



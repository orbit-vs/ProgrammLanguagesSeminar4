int SumFromOneToN(int n)
{

    if (n < 1)
        return -1; 
    
    int result = 0;

    int counter = 1;

    while(counter <= n) {
        result += counter;
        counter ++;
    }
    
    return result;
}


Console.WriteLine("Программа вычесления суммы чисел от 1 до N");
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int x);



int result = SumFromOneToN(n);

int SumFromOneToN(object n)
{
    throw new NotImplementedException();
}

Console.WriteLine($"Результат: {result}");
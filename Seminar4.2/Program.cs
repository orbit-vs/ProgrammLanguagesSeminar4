int N = getVar();
System.Console.WriteLine( multipler(N) );

int multipler(int num) {
    int outNum = 1;
    for (int i = 1; i < num + 1; outNum *= i++){}

    return outNum;
}

int getVar(){
    int varValue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.WriteLine($"Введите число: ");
        isNumeric = int.TryParse(Console.ReadLine(), out varValue);
    }

    return varValue;
}
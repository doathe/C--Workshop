static void Add()
{
    Console.WriteLine("Added!");
}
static int Add2(int number1 = 20, int number2 = 30)
{
    return number1 + number2;
}



Add();

var result = Add2(2,3);
Console.WriteLine(result);

var result2 = Add2(3);
Console.WriteLine(result2);

Console.ReadLine();